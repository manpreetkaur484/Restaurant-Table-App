   M S B A M L   `   `   `  ����R  NRestaurantBillingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:RestaurantBillingAppRestaurantBillingApp  5   	   %    RestaurantBillingApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:RestaurantBillingApp     5   	     � Title$#  Restaurant Billing Calculator��5   	   $	��450��6/   $	��700��6<    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$ ThreeDBorderWindow=�6.    � 	Resources 5
         buttonStyle1 �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6%   .�5      ��  � ��$ 75��6&   63   �� 5       � ��$ 30��6'   64   �� 5       � �� �#8000006=   �� 5       � ��
 �����6;   �� 5       � ��$ 15(�6)   66   5      5      .��5      � .+�5   
   �� $��Waiter's Information��6   $��130,90,130,90q�61   ���#800000.��5      � $��0q�6   ���#F5DEB3 � RowDefinitions 5      �� 5      $
��179* �6$   �� 5      $	��12* �6$   .+�5      �� $��Table Number:��6   $
��Left=�60   $��	45,25,0,0q�5      $	��Top=�6+   �� 5      -   5         ��Name$ TableNumber��5      $
��Left=�6/   $��
150,30,0,0q�5       $	��Top=�6/   $	��200��5!      $��23��6&   ���#FFF8DC	 �� TextWrapping$
	 Wrap=�5"      �� 5$      $��Waiter's Name:��6   $
��Left=�61   $��	45,80,0,0q�5%      $	��Top=�6+   �� 5'      -   5        $ 
WaiterName��5)   4   $
��Left=�5'      $	��Top=�66   $��
150,85,0,0q�5(      $
	 Wrap=�6/   $	��200��5)      $��23��6'   ���#FFF8DC5*      �� 5,      -   5        
 ��Name$
 btnOk��5,   .   $��150,124,0,0q�6   $��OK��6=   $
��Left=�5-      $	��Top=�65   #��[  5.   0   �� 50      -   5        $
 	btnCancel��50   .   $��275,124,0,0q�6   $��Clear��6A   $
��Left=�51      $	��Top=�65   #��[  52   4   54      55      56      57      