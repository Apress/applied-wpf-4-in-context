   M S B A M L   `   `   `  ����J  FCommandHandling, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CommandHandlingCommandHandling  5   	        CommandHandling.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ,myclr-namespace:CommandHandling     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5	      $ ControlStyles.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $	��130 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6   .+�5   
   �� $��1��5      $��1��5      $��3��5       $#��WPF Command and Event routing��5!         
TitleStyle#��[  5"      �� 5#   
   $��1��5$      $��3��5%      $��2��5&       J� CommandBindings 5'      )  #System.Windows.Input.CommandBinding  5(          CommandHandling.MainWindow   MvvmCommand   Command# Z 5)      .+�5+      �� #��Z 5,      .��6@   Classic Routed5.      �� 5/        ButtonStyle#��[ 6   $��ApplicationCommands.Cut��50      ��51      �� 52      	 �� Orientation$	 
Horizontal=�6!   .+�53      �� $��/Images/Cut.png��6    $��32��54       $��32��6,   
 J� SnapsToDevicePixels
 . 55       �� 56        
LabelStyle#��[ 6$   Cut Command6U   57      59      �� 5:      #��[ 6   $��ApplicationCommands.Copy��5;      ��5<      �� 5=      $	 
Horizontal=�6!   .+�5>      �� $��/Images/Copy.png��6    $��32��5?       $��32��6,   
 .  5@       �� 5A      #��[ 6$   Copy Command6V   5B      5D      �� 5E      #��[ 6   $��ApplicationCommands.Paste��5F      ��5G      �� 5H      $	 
Horizontal=�6!   .+�5I      �� $��/Images/Paste.png��6    $��32��5J       $��32��6,   
 . 5K       �� 5L      #��[ 5M      Paste Command6P   5N      5P      5Q      �� 5R   
   $��2��5S      $��3��6   $��2��5T      $��2��6   .+�5U      �� #��[ 5V      Original Text6D   �� 5W      -   5         ��Name$ txtOriginalText��5X        	TextStyle#��[ 5W      5X      5Y      5Z      5[      