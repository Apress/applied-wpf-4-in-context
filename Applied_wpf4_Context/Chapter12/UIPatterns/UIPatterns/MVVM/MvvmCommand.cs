using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Windows.Input;

namespace UIPatterns.MVVM
{
    public sealed class MvvmCommand : ICommand
    {
        #region Implementation of ICommand

        public void Execute(object parameter)
        {
            if (execute != null)
            {
                execute(parameter);
            }
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            return canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        #endregion

        private readonly Func<object, bool> canExecute;
        private readonly Action<object> execute;

        private readonly WeakEventManagerBase<PropertyChangedEventArgs> weakEventListener;

        public MvvmCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
            weakEventListener = new WeakEventManagerBase<PropertyChangedEventArgs>(RequeryCanExecute);
        }

        public MvvmCommand AddListner<TEntity>(INotifyPropertyChanged source, Expression<Func<TEntity, object>> property)
        {
            string propertyName = GetPropertyName(property);
            PropertyChangedEventManager.AddListener(source, weakEventListener, propertyName);
            return this;
        }

        private string GetPropertyName<TEntity>(Expression<Func<TEntity, object>> expression)
        {
            var lambda = expression as LambdaExpression;
            MemberExpression memberExpression;
            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = lambda.Body as UnaryExpression;
                memberExpression = unaryExpression.Operand as MemberExpression;
            }
            else
            {
                memberExpression = lambda.Body as MemberExpression;
            }
            var constantExpression = memberExpression.Expression as ConstantExpression;
            var propertyInfo = memberExpression.Member as PropertyInfo;
            return propertyInfo.Name;
        }

        private void RequeryCanExecute(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            OnCanExecuteChanged();
        }

        public void OnCanExecuteChanged()
        {
            EventHandler handler = CanExecuteChanged;
            if (handler != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
