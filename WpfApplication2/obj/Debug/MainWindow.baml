   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	        WpfApplication2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   $	��255��65   $	��350��6D    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $# ButtonResourceDictionary.xaml?�6%   5      %    5      .��5      � $��Bottom=�6   $
��Left=�6'   $	��250��6B   $	��275��6N    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5!   
   �� -   5         ��Name$ textBox��5!      $��4��6#   $��0��67    �� TextWrapping$
 Wrap=�6D   $�� ��6X   �� 5"   
   -   5         ��Name$ button1��5"      $��1��6"   $��3��6.      calculatorKeyColor#��[  6;   �� 5#   
   -   5        $ button2��5#      $��2��6"   $��1��6.   $��3��6>   #��[  6L   �� 5$   
   -   5        $ button3��5$      $��3��6"   $��2��6.   $��3��6>   #��[  6K   �� 5%   
   -   5        $ button4��5%      $��4��6"   $��2��6.   #��[  6;   �� 5&   
   -   5        $ button5��5&      $��5��6"   $��1��6.   $��2��6>   #��[  6K   �� 5'   
   -   5        $ button6��5'      $��6��6"   $��2��6.   $��2��6>   #��[  6K   �� 5(   
   -   5        $ button7��5(      $��7��6"   $��1��6.   #��[  6;   �� 5)   
   -	   5        $ button8��5)      $��8��6"   $��1��6.   $��1��6>   #��[  6K   �� 5*   
   -
   5        $ button9��5*      $��9��6"   $��2��6.   $��1��6>   #��[  6K   �� 5+   
   -   5        $ button0��5+      $��0��6"   $��4��6.   #��[  6;   �� 5,   
   -   5        $ ACButton��5,      $��AC��6#   $��1��60   $��4��6A   �� 5.   
   -   5        $ 
menuButton��5.      $
��Menu��6%   $
��Left=�64   $	��Top=�6O   $��75��6g   $��2��6r   $��	0,-29,0,0q�6�   	 � ContextMenu	 5/      �� 50      .@�51      m� -   5        $��About��51      6G   52      54      �� 55   
   -   5        $ closeButton��55      $��X��6&   $��Right=�62   $��0,-29,-250,0q�6N   $	��Top=�6d   $��32��6|     closeKeyColor#��[ 6�   $��3��6�   �� 56   
   -   5        $ additionButton��56      $��+��6)   $��3��65   $��1��6E     operatorKeyColor#��[ 6R   �� 57   
   -   5        $ subtractionButton��57      $��-��6,   $��3��68   $��2��6H   #��[ 6U   �� 58   
   -   5        $ divideButton��58      $��/��6'   $��3��63   $��3��6C   #��[ 6P   �� 59   
   -   5        $ equalsButton��59      $��=��6'   $��3��63   $��4��6C   #��[ 6P   5:      5;      