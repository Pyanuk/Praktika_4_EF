   M S B A M L   `   `   `  ����H  DPraktika_1_EF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Praktika_1_EFPraktika_1_EF  5          Praktika_1_EF.FirstPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Praktika_1_EF     5        N� Title$  	FirstPage��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ NAME_COFFEEDataGrid��5         AutoGenerateColumns .  $��0,111,10,210q�6L      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID_NAME_COFFEE_HOUSE+  5      $ Название��6%    67   �� *TITLE+  5      $ 
Адрес��6%    64   �� *ADDRESS_COFFEE_HOUSE+5      �� 5   
   -   5         ��Name$ insert��5      $#��Добавить данные��6"   $��
0,430,10,0q�6<   6Q   �� 5   
   -   5        $ delete��5      $#��Удаление данных��6"   $��0,405,10,20q�6<   6Q   �� 5   
   -   5        $ update��5      $'��!Обновление данных��6"   $��0,385,10,45q�6>   6S   �� 5   
   -   5        $ 	poick_dan��5      $��Поиск данных��6&   $��0,366,10,65q�6=   6R   �� 5   
   -   5        $ filter_dani��5      $��Очистить��6(   $��0,347,10,84q�6;   6P   �� 5   
   -   5         ��Name$ 
filter_dan��5      $��0,324,10,107q�6(   6>   �� 5   
   -   5         ��Name$ poick��5      $��0,262,10,166q�6!   ��67   �� *SelectedItem.TITLE+	 �� ElementName$	 NAME_COFFEEDataGrid��.��6|   
 � 	Resources
 5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name ��Name J� IsHitTestVisible ��Name �� Triggers P� Property P� Value �� 
TargetName��%I  '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5       " ��6.   .R�5!   "   � .+�5"   &   �� $ border��6-   #��z��5#      #��z��5$      #��z��5%      �� 5&   &   $ 	watermark��60   $L��FВведите название кофейни для поиска ...��5'      $��2q�5(      
�������$y�	Collapsed=�5*       .  5+      �� 5,   &   $ PART_ContentHost��63   5-   #    5.   "   P� 5/   &    � ��$  ��6>   . �50   *   �� $ 	watermark��61    � y�$ Visible=�6^   51   '   53      55      56      57      .��6!   58      �� 5;   
   -	   5        $
 text��5;      $��0,304,10,124q�6    ��66   �� *SelectedItem.TITLE+$	 NAME_COFFEEDataGrid��.��6{   
 5<      ��%5  '��       �� 5=      " ��6   .�5>      ��  � �� 5?      �� 5@      " ��6.   .R�5A   "   � .+�5B   &   �� $ border��6-   #��z��5C      #��z��5D      #��z��5E      �� 5F   &   $ 	watermark��60   $8��2Введите название кофейни ...��5G       $��2q�5H       
�������$y�	Collapsed=�5J        .  5K       �� 5L   &   $ PART_ContentHost��63   5M   #    5N   "   P� 5O   &    � ��$  ��6>   . �5P   *   �� $ 	watermark��61    � y�$ Visible=�6^   5Q   '   5S      5U      5V      5W      .��6!   5X      �� 5]   
   -
   5        $ addressTextBox��5]      $��0,284,10,146q�6*   ��6@   �� *#!SelectedItem.ADDRESS_COFFEE_HOUSE+$	 NAME_COFFEEDataGrid��.��6�   
 5^      ��%  '��       �� 5_      " ��6   .�5`      ��  � �� 5a      �� 5b      " ��6.   .R�5c   "   � .+�5d   &   �� $ border��6-   #��z��5e      #��z��5f      #��z��5g      �� 5h   &   $ 	watermark��60   $"��Введите адрес...��5i       $��2q�5j       
�������$y�	Collapsed=�5l        .  5m       �� 5n   &   $ PART_ContentHost��63   5o   #    5p   "   P� 5q   &    � ��$  ��6>   . �5r   *   �� $ 	watermark��61    � y�$ Visible=�6^   5s   '   5u      5w      5x      5y      .��6!   5z      5{      5|      