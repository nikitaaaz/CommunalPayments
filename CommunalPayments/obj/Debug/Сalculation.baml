   M S B A M L   `   `   `  ����K  GCommunalPayments, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CommunalPaymentsCommunalPayments  5   	   #    CommunalPayments.Сalculation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CommunalPayments     5   	     � Title$  Сalculation��5   	   $��327.631��6   $��856.759��6.    � 
ResizeMode$ NoResize=�6>   .��5	      � .+�5
   
   �� $����Выберите месяц и тарифный план, по которому расчитать. Двойной щелчок по квартире даёт право выбрать тариф.��6   $
��Left=�6�   $��	10,10,0,0q�6�   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGrigNoRes��5      $
��Left=�6*   $	��246��6E   $��	10,41,0,0q�6R   $	��Top=�6e   $	��658��6}   ��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5      5      �� 5   
   -   5         ��Name$ 	ComboDate��5      $
��Left=�6&   $��
686,41,0,0q�6A   $	��Top=�6U   $	��153��6m   ��6y   �� *
data_start+ �� SelectedIndex 6�   �� *
data_start+5      5      5      