   M S B A M L   `   `   `  ����R  NRestaurantBillingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:RestaurantBillingAppRestaurantBillingApp  5   	   %    RestaurantBillingApp.BillWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:RestaurantBillingApp     5   	   -   5          � Title$'  !Restaurant Billing Calculator App��5   	   $	��700��63   $	��650��6@    � WindowStartupLocation$ CenterScreen=�5	        � 	Resources 5
         buttonStyle1 �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6%   .�5      ��  � ��$ 75��6&   63   �� 5       � ��$ 30��6'   64   �� 5       � �� �#8000006=   �� 5       � ��
 �����6;   5      5      .��5      � $	��600��6   .+�5   
   �� $��Bill Details��6   $��0,20,0,0q�6'   $��Center=�5      $	��Top=�6.   $��20(�5      $
��Bold"�6   �� 5   
   -   5         ��Name$ 	billField��5      $��50,70,50,60q�6&    �� TextWrapping$
 Wrap=�5      ���#FFF8DC$��Courier New)�5       �� 
IsReadOnly . $��100, 20, 100, 20q�5      ���#8000006-   �� 5   
   -   5        	 ��Name$	 btnExit��5   !   $��15(�6   $
��Exit��62   $��Right=�5      $��
0,30,50,25q�6-   $��Bottom=�5      $	��100��6,   #��[  5       5!      5"      5#      