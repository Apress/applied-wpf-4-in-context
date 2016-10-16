using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter01.DataTemplate
{
    public sealed class PersonList : List<Person>
    {
        public PersonList()
        {
            this.Add(new Person { FirstName = "John", LastName = "Doh", DateOfBirth = DateTime.Now.AddYears(-30) });
            this.Add(new Person { FirstName = "Mary", LastName = "Pane", DateOfBirth = DateTime.Now.AddYears(-20) });
            this.Add(new Person { FirstName = "Luke", LastName = "Perry", DateOfBirth = DateTime.Now.AddYears(-28) });
        }
    }
}
