   M S B A M L   `   `   `  ����K  GCommunalPayments, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CommunalPaymentsCommunalPayments  5   	       CommunalPayments.Charges   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CommunalPayments     5   	     � Title$=  7Просмотр информации за период��5   	   $��345.429��6/   $��1062.397��6@    � WindowStyle$ 
ToolWindow=�6Q    � 
ResizeMode$ NoResize=�6j   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��255* �6   �� 5      $
��256* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridSelApartment��5      $
��Left=�61   $	��545��6L   $��2��6X   ��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5      5      �� 5   
   -   5         ��Name$ ComboDateStart��5      $��1��6+   $
��Left=�6;   $��
131,14,0,0q�6V   $	��Top=�6j   $	��153��6�   6�   �� 5   
   -   5        $ ComboDateStop��5      $��1��6*   $
��Left=�6:   $��
365,14,0,0q�6U   $	��Top=�6i   $	��153��6�    J� RenderTransformOrigin$ 0.837,-2.885&�6�   �� 5   
   -   5         ��Name$ ButtonViewCharges��5      $V��PПоказать начисления за заданный промежуток��6,   $��1��6a   $
��Left=�6q   $��
77,122,0,0q�6�   $	��Top=�6�   $	��405��6�   $��75��6�   6�   �� 5   
   $��Начисления с: ��6   $��1��6)   $
��Left=�69   $��	35,10,0,0q�6T   $	��Top=�6g   �� 5   
   $��по:��6   $��1��6   $
��Left=�6.   $��
333,10,0,0q�6I   $	��Top=�6]   $ 1.171,-1.018&�6u   �� 5   
   $����Начисления по конкретной квартире можно за выбранный период можно посмотреть,
 сделав двойной щелчок по полю с интересующей квартирой��6   $��1��6�   $
��Left=�6�   $��
24,232,0,0q�6�   $	��Top=�6�   $ 0.358,-0.713&�6   $��73��6%  5      5      