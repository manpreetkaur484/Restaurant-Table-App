   M S B A M L   `   `   `  ����R  NRestaurantBillingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:RestaurantBillingAppRestaurantBillingApp  5   	   %    RestaurantBillingApp.MenuWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:RestaurantBillingApp     5   	   -   5          � Title$$  Restaurant Bill Calculator App��5   	   $	��650��60   $	��910��6=    � WindowStartupLocation$ CenterScreen=�6`    � 	Resources 5	         buttonStyle2 �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6%   .�5      ��  � ��$	 170��6&   64   �� 5       � ��$ 40��6'   64   �� 5       � �� �#8000006=   �� 5       � ��
 �����6;   �� 5       � ��$ 15(�6)   66   5      5      .��5      � ���#FFF8DC.+�5   
   �� $��
Menu Items��6   $
��Left=�6%   $	��Top=�6A   $��30(�6Y   $��DemiBold"�6g   $��	25,15,0,0q�6}   �� 5   
   -   5         ��Name$ 
billNumber��5      $��Bill: 0��6$   $��Right=�66   $��
25,25,30,0q�6R   $	��Top=�6f   $��25(�6~   $��SemiBold"�6�   �� 5   
   $��Beverage Menu��6   $
��Left=�6*   $	��Top=�6E   $	��250��5      $	��410��6!   $��	25,80,0,0q�6-   $��Italic$�5      $��15(�6&   $��cursive)�64   ���#800000.��5      �� -   5         ��Name$ listBeverage��5      $��7,7,7,7q�6,   $��Courier New)�5       ���#F5DEB3$��0q�5"      $��Disabled=�5#      ��5      �� ��5%      �� 5'      .R�5(      ��  �� Orientation$ 
Horizontal=�6%   .+�5)      �� ��6'   �� 	 d� 	IsChecked	 5*   '   �� *
IsSelected+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ 	LostFocus=�5+   :   5,      5-      50      51      �� 53   
   $��MainCourse Menu��6   $	��Top=�6-   $��Right=�6E   $	��410��54      $	��250��6    $��	0,80,25,0q�6-   $��Italic$�55      $��15(�6&   $��cursive)�64   ���#800000.��56      �� -   5        $ listMainCourse��56      $��7,7,7,7q�6.   $��Disabled=�6?   $��Courier New)�57   /   ���#F5DEB3$��0q�6]   ��6   �� ��59      �� 5;      .R�5=      �� $ 
Horizontal=�6%   .+�5>      �� ��6'   �� 	 6;   �� *
IsSelected+$
 TwoWay=�6k   5?      5A      5E      5F      �� 5G   
   $��Appetizer Menu��6   $��Bottom=�6+   $
��Left=�6F   $	��410��5H      $	��200��6    $��	25,0,0,80q�6-   $��Italic$�5I      $��15(�6&   $��cursive)�64   ���#800000.��5K      �� -   5        $ listAppetizer��5K      $��7,7,7,7q�6-   $��Disabled=�6>   $��Courier New)�5L   )   ���#F5DEB3$��0q�6W   ��6   �� ��5N      �� 5P      .R�5R      �� $ 
Horizontal=�6%   .+�5S      �� ��6'   �� 	 6;   �� *
IsSelected+$
 TwoWay=�5T      5V      5Y      5[      �� 5]   
   $��Dessert Menu��6   $��Bottom=�6)   $��Right=�6D   $	��410��5^      $	��200��6   $��	0,0,25,80q�6,   $��Italic$�5_      $��15(�6&   $��cursive)�64   ���#800000.��5b      �� -   5        $ listDessert��5b      $��7,7,7,7q�6+   $��Disabled=�6<   $��Courier New)�5c   )   ���#F5DEB3$��0q�6W   ��6   �� ��5f      �� 5g      .R�5i      �� $ 
Horizontal=�6%   .+�5j      �� ��6'   �� 	 6;   �� *
IsSelected+$
 TwoWay=�5k      5m      5q      5r      �� 5t   
   -   5         ��Name$ btnViewOrderBill��5t   $   $��	30,0,0,20q�6   $��View Order and Bill��6>   $
��Left=�5u      $��Bottom=�6-   #��[  5v      67   �� 5x   
   -   5        $ btnClear��5x   '   $��325,0,325,20q�6   $��Clear��69   $��Center=�5y      $��Bottom=�6/   #��[  5z      67   �� 5|   
   -	   5        $ btnExit��5|   %   $��	0,0,30,20q�6   $
��Exit��66   $��Right=�5}      $��Bottom=�6.   #��[  5~      67   5�      5�      