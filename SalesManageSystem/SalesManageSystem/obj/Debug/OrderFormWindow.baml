   M S B A M L   `   `   `  ����L  HSalesManageSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SalesManageSystemSalesManageSystem  5   	   '    !SalesManageSystem.OrderFormWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SalesManageSystem     5   	     � Title$  	订货单��5   	   $	��300��6   $	��300��6"   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5      �� .+�5      �� $��	订货单��6   $��20(�6'   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��
供应商:��6    �� 5      -   5         ��Name$ supplierTBox��5      $	��100��65   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��	部门：��6    �� 5      -   5         ��Name$ departmentComboBox��5      6=   �� 5      $��操作员：��6    �� 5      -   5        $ operatorTBox��5      66   5      �� 5       $ 
Horizontal=�6   .+�5!      �� $��经办人：��6    �� 5"      -   5        $ managerComboBox��5"      6:   �� 5#      $��发票类型：��6    �� 5$      -   5        $ invoiceTypeTBox��5$      69   5%      �� 5&      $ 
Horizontal=�6   .+�5'      �� $��订单备注:��6    �� 5(      -   5        $ 
remarkTBox��5(      5)      5*      �� 5+      $��1��6   .+�5,      �� $ 
Horizontal=�6   .+�5-      �� $��开单日期:��6    �� 5.      -   5        $ createTimeTBox��5.      5/      �� 50      $ 
Horizontal=�6   .+�51      �� $��订货单号:��6    �� 52      -   5        $ orderIDTBox��52      53      �� 54      $ 
Horizontal=�6   .+�55      �� $��包装方式:��6    �� 56      -	   5        $ packingComboBox��56      58      �� 59      $ 
Horizontal=�6   .+�5:      �� $��到货日期:��6    �� 5;      -
   5        $ arriveTimeTBox��5;      5<      �� 5=      $ 
Horizontal=�6   .+�5>      �� $��到货地点:��6    �� 5?      -   5        $ arriveAddressTBox��5?      5@      5A      5B      &   System.Windows.Controls.DataGrid  5C   
   $��1��6   �� 5D   
   $ 
Horizontal=�6   $��2��6.   .+�5E      �� -   5        $��保存��5E      6"   �� 5F      -   5        $��取消��5F      6"   5G      5H      5I      