   M S B A M L   `   `   `  ����F  BBookShopWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BookShopWPFBookShopWPF  5   	       BookShopWPF.CartWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BookShopWPF     5   	   $	��450��5      $	��800��6     � Title$  
CartWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         AutoGenerateColumns$ False��6C      SelectionMode$ Extended=�6_      CanUserResizeRows$ False��6x      CanUserSortColumns$
 True��6�      CanUserAddRows$ False��6�   $	��349��6�   $	��Top=�6�   ��6%   �� *Items+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6O   
   MaxWidth$
 35Q�6Y      MinWidth$ 15Q�6g      
IsReadOnly$
 True��6u   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	ProductID+6u     5      $ Название��6%   $	 * 6P   $	 120Q�6Z   $
 True��6i    67   �� *Name+6i     5      $ Описание��6%   $	 * 6W   $	 250Q�6a   $
 True��6p    67   �� *Description+6p     5      $ Цена��6%   $	 * 6M   $ 80Q�6W   $
 True��6e    63   �� *Price+6e     5      $ Количество��6%   $	 * 6[   $ 80Q�6e   $
 True��6s    69   �� *StockQuantity+6s     5      $ 
Автор��6%   $	 * 6W   $	 250Q�6a   $
 True��6p    64   �� *ManufacturerID+6p   5      �� 5   
   -   5        $7��1Удалить продукт из корзины��5      $	��250��6N   $	��200��6]   $��	23,0,0,27q�6l   $��68��6   $
��Left=�6�   $��17��6�   $��Bottom=�6�   �� 5   
   -   5        $#��Оплатить товары��5      $	��200��6?   $	��150��6N   $��
255,0,0,26q�6]   $��68��6q   $
��Left=�6}   $��17��6�   $��Bottom=�6�   �� 5   
   -   5         ��Name$ TotalCostText��5      $	��150��6+   $��	0,0,45,27q�6:   $
��Wrap=�6M   $%��Итого к оплате: 100��6a   $	��101��6|   $��Right=�6�   $��16��6�   $��Bottom=�6�   �� 5   
   -   5        $*��$Вернуться к товарам��5      $	��200��6A   $	��150��6P   $��
439,0,0,25q�6_   $��68��6s   $
��Left=�6   $��17��6�   $��Bottom=�6�   5      5      