   M S B A M L   `   `   `  ����F  BBookShopWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BookShopWPFBookShopWPF  5   	       BookShopWPF.AddWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BookShopWPF     5   	   $	��450��5   	   $	��800��6     � Title$  	AddWindow��5	   	   $	��450��6   $	��800��6(   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��109* �6   �� 5      $
��291* �6   .+�5   
   �� -   5         ��Name$ AddBlockName��5      $
��Left=�6*   $
��Wrap=�6E   $8��2Добавление нового продукта��6Y   $	��Top=�6{   $��35��6�   $	��348��6�   $��8,10,0,0q�6�    �� TextAlignment$ Center=�6�   $��20(�6�   $��1��6�   �� 5   
   $
��Left=�6   $��	35,95,0,0q�6/   $
��Wrap=�6B   $6��0Введите название продукта��6V   $	��173��6w   $��16��6�   $	��Top=�6�   �� 5   
   $
��Left=�6   $��
35,129,0,0q�6/   $
��Wrap=�6C   $6��0Введите описание продукта��6W   $	��173��6x   $��16��6�   $	��Top=�6�   �� 5   
   $
��Left=�6   $��
35,180,0,0q�6/   $
��Wrap=�6C   $.��(Введите цену продукта��6W   $	��Top=�6t   $	��173��6�   �� 5   
   $
��Left=�6   $��35,0,0,0q�6/   $
��Wrap=�6A   $:��4Введите количество продукта��6U   $��Center=�6x   $	��173��6�   �� 5   
   $
��Left=�6   $��
35,243,0,0q�6/   $
��Wrap=�6C   $8��2Введите категории продукта��6W   $	��Top=�6y   $	��202��6�   $��2��6�   �� 5   
   $
��Left=�6   $��
35,279,0,0q�6/   $
��Wrap=�6C   $2��,Введите автора продукта��6W   $	��Top=�6v   $	��202��6�   $��2��6�   �� 5   
   -   5        $��NameBox��5      $
��Left=�6!   $��	24,95,0,0q�6<    �� TextWrapping$
 Wrap=�6O   $�� ��6c   $	��224��6k   $��1��6w   $��18��6�   $	��Top=�6�   6�   �� 5   
   -   5         ��Name$ DescriptionBox��5      $
��Left=�6*   $��
24,129,0,0q�6E   $
 Wrap=�6Y   $�� ��6m   $	��496��6u   $��1��6�   $��41��6�   $	��Top=�6�   �� 5   
   -   5        $ PriceBox��5      $
��Left=�6$   $��
24,180,0,0q�6?   $
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��224��6�   $��1��6�   �� 5   
   -   5        $ QuantityBox��5      $
��Left=�6'   $��24,0,0,0q�6B   $
 Wrap=�6T   $�� ��6h   $��Center=�6p   $	��224��6�   $��1��6�   �� 5   
   -   5        $ CategoryIDBox��5      $
��Left=�6)   $��
24,243,0,0q�6D   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��224��6�   $��1��6�   �� 5   
   -   5        $ ManufacturerBox��5      $
��Left=�6+   $��
24,277,0,0q�6F   $
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��224��6�   $��1��6�   �� 5   
   -   5         ��Name$ 	AddButton��5      $��Добавить��6$   $
��Left=�67   $��
44,389,0,0q�6R   $	��Top=�6f   $��92��6~   
���   �6�   �� 5   
   -	   5        $ 
EditButton��5      $��Изменить��6%   $
��Left=�68   $��	44,0,0,25q�6S   $��92��6f   
���   �$��20��6�   $��Bottom=�6�   �� 5   
   -
   5        $��Отмена��5      $
��Left=�6"   $��
171,0,0,25q�6=   $��92��6Q   
���   �$��2��6   $��20��6�   $��Bottom=�6�   5       5!      