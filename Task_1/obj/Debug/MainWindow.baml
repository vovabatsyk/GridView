   M S B A M L   `   `   `  ����A  =Task_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task_1Task_1  5   	       Task_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Task_1     5   	     � Title$  Application log��5   	   $	��500��6!   $	��750��6.    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ NoResize=�6_    � WindowStyle$ 
ToolWindow=�6u   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      $	��150 �6   6+   �� 5      $
��Auto �6   6,    � 	Resources 5   
      Task_1.LogsList   LogsList��%   &	          5      60   5      .+�5   
   �� -   5        $��	listView1��5      $��Stretch=�5      $��Stretch=�5      $��10q�5      
���   �#��[  5      $��Stretch=�5       �� View 5      �� 5      .P�5       ��  �� Width$	 200��6%   $
��Type��6\    �� DisplayMemberBinding 61   �� 	 �� Path$
	 Type�6\   �� 5!      $	 100��6%   $
��Date��6\    61   �� $
	 Date�6\   �� 5"      $	 100��6%   $
��Time��6\    61   �� $
	 Time�6\   �� 5#      $	 310��6%   $��Source��6^    61   �� $	 Source�6^   5$      5&      �� 5(   
   -   5        
 ��Name$
 
TextBoxRes��5(      $��1��6'   
���   �$��10q�6H    �� 
IsReadOnly . 6T   ]� 5*   
   $��2��6   $��Right=�6!   .+�5+      �� -   5        $	��150��5+      $��
0,10,20,10q�6!   .��6L   Close6S   �� 5,      -   5        $	��150��5,      $��
0,10,20,10q�6!   .��6J   Clear6Q   5-      5.      50      