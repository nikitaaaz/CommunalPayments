   M S B A M L   `   `   `  ����K  GCommunalPayments, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CommunalPaymentsCommunalPayments  5   	       CommunalPayments.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CommunalPayments     5   	     � Title$-  'Коммунальные платежи��5   	   $��545.613��6&   $��786.795��67    � WindowStyle$ 
ToolWindow=�6G    � 
ResizeMode$ NoResize=�6`   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��169* �6   �� 5      $
��612* �6    � RowDefinitions 5   
   �� 5      $
��251* �6   �� 5      $
��227* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridDirectory��5      $��
0,31,10,60q�6.   $��2��6B      AreRowDetailsFrozen . $��2��6n   o� 5   
   $��	0,0,0,244q�6   $��2��6"   .@�5      m� $��Справочники��6   .@�5      m� -   5        $)��#Справочник тарифов��5      6S   m� 5      -   5        $)��#Справочник квартир��5      6W   m� 5      -   5        $%��Справочник домов��5      6Q   m� 5      -   5        $#��Справочник улиц��5      6Q   �� 5      6   m� 5      $
��Exit��6   6+   5      m� 5      -   5        $��Расчёт��5      6'   m� 5      -   5        $��Начисления��5      6+   5$      �� 5%   
   -   5         ��Name$ addTariffButton��5%      $!��Добавить тариф��6*   $
��Left=�6C   $��483,203,0,0q�6^   $��1��6s   $	��Top=�6�   $	��117��6�   $��32��6�   $y�	Collapsed=�6�   $��1��6�   �� 5&   
   -	   5         ��Name$ textBoxNameTariff��5&      $
��Left=�6-   $��23��6H   $��
56,211,0,0q�6T   $��1��6h   	 �� TextWrapping$
	 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��160��6�   $y�	Collapsed=�6�   $��2��6�   �� 5'   
   -
   5        $ textBoxPayVal��5'      $
��Left=�6)   $��23��6D   $��
92,212,0,0q�6P   $��1��6d   $
	 Wrap=�6q   $�� ��6�   $	��Top=�6�   $	��160��6�   $y�	Collapsed=�6�   $��1��6�   (  "System.Windows.Controls.DatePicker  5(   
   -   5        
  Name$
 datePickerTariffStart��5(      $
��Left=�64   $��301,211,0,0q�6O   $��1��6d   $	��Top=�6q   $	��134��6�   $y�	Collapsed=�6�   $��1��6�   �� 5)   
   -   5         ��Name$ labelNameTariff��5)      $#��Название тарифа��6)   $
��Left=�6C   $��
85,185,0,0q�6^   $��1��6r   $	��Top=�6   $y�	Collapsed=�6�   �� 5*   
   -   5        $ labelPay��5*      $��Цена за кв м��6"   $
��Left=�69   $��132,185,0,0q�6T   $��1��6i   $	��Top=�6v   $y�	Collapsed=�6�   $��1��6�   �� 5+   
   -   5        $ 	labelDate��5+      $9��3Дата начала действия тарифа��6#   $
��Left=�6I   $��285,185,0,0q�6d   $��1��6y   $	��Top=�6�   $y�	Collapsed=�6�   $��1��6�   5,      5-      