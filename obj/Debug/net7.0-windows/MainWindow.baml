   M S B A M L   `   `   `  ����  BookShopWPF    BookShopWPF.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   $	��800��5   	   $	��450��6     � Title$  	Book List��5   	   $	��450��6   $	��800��6(   ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5	      �  � Color$ #3b71d3��6    � Offset$	 0.0Q�6+   � 5
      $ #6495ed��6   $	 1.0Q�6+   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��409* �6   �� 5      $	��25* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         AutoGenerateColumns$ False��6C      SelectionMode$ Extended=�6_   	   CanUserResizeRows$	 False��6x   
   CanUserSortColumns$

 True��6�      CanUserAddRows$ False��6�   $	��349��6�   $	��Top=�6�   ��6%   �� *Items+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6O      MaxWidth$ 35Q�6Y      MinWidth$ 15Q�6g      
IsReadOnly$
 True��6u   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	ProductID+6u     5      $ Название��6%   $ * 6P   $	 120Q�6Z   $
 True��6i    67   �� *Name+6i     5      $ Описание��6%   $ * 6W   $	 250Q�6a   $
 True��6p    67   �� *Description+6p     5      $ Цена��6%   $ * 6M   $ 80Q�6W   $
 True��6e    63   �� *Price+6e     5      $ Количество��6%   $ * 6[   $ 80Q�6e   $
 True��6s    69   �� *StockQuantity+6s     5      $ 
Автор��6%   $ * 6W   $	 250Q�6a   $
 True��6p    64   �� *ManufacturerID+6p   5      �� 5   
   -   5        $%��Добавить продукт��5      $	��200��6,   $	��150��6;   $��	23,0,0,23q�6J   $��68��6]   $
��Left=�6{   $��21��6�   $��Bottom=�6�   $��2��6�   ���	#A0783B486�   �� 5!   
   -   5        $/��)Редактировать продукт��5!      $	��200��61   $	��150��6@   $��
207,0,0,23q�6O   $��68��6c   $
��Left=�6�   $��21��6�   $��Bottom=�6�   $��2��6�   ���	#A0783B486�   �� 5#   
   -   5        $#��Удалить продукт��5#      $	��200��6+   $	��150��6:   $��	389,0,0,0q�6I   $��68��6\   $
��Left=�6}   $��19��6�   $��Bottom=�6�   ���	#A0FF00006�   �� 5%   
   -   5        $7��1Добавить продукт в корзину��5%      $	��200��66   $	��150��6E   $��
576,0,0,15q�6T   $	��172��6h   $
��Left=�6�   $��19��6�   $��Bottom=�6�   ���	#A0783B486�   �� 5'   
   -   5        $#��Открыть корзину��5'      $	��200��6+   $	��150��6:   $��	0,0,35,12q�6I   $��23��6m   $��Bottom=�6y   $��2��6�   $��Right=�6�   $	��172��6�   ���	#A0783B486�   5(      5)      