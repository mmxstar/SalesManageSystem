   M S B A M L   `   `   `  ����L  HSalesManageSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SalesManageSystemSalesManageSystem  5   	   #    SalesManageSystem.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SalesManageSystem     5   	     � Title$  登陆窗口��5   	   $	��520��6   $	��840��6#    � 
ResizeMode$ NoResize=�5	   	   ��5
      �� 5   
    �� ImageSource$&  Assets/LoginWindowBackground.jpg��6   6F   .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   6-   �� 5      $	�� 2* �6   6-   .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $��1��6I   .+�5      �� $��销售管理系统��6   $��45(�6&   $��Normal$�64   $��
0,160,0,25q�6G   �� 5      $ 
Horizontal=�6   $��40,0,0,0q�62   .+�5      �� $��	用户名��6   $��20(�6'   $��0,0,10,0q�65   �� 5      -   5         ��Name$ userNameTextBox��5      $��ds_xue��63   $	��120��6B   6Q   5      �� 5      $ 
Horizontal=�6   $��40,5,0,0q�62   .+�5      �� $��密码��6   $��20(�6&   $��5,0,10,0q�65   G� 5      -   5         G�Name$ passwordBox��5       G� Password$ 123456��64   $	��120��6F   $��15,0,0,0q�6R   5      �� 5       -   5         ��Name$ errorMessageTBlock��5       
���  ��$y�Hidden=�6F   $!��用户名或密码错误！��6Z   $��
100,10,0,0q�6k   �� 5!      -   5        $��登陆��5!      ���#87CEFA$��45,10,40,10q�67   6L   �� 5"      $��Powered by cohn.��6   $��
90,100,0,0q�60   
�������6D   5#      5$      5%      