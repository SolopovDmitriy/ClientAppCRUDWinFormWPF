   M S B A M L   `   `   `  ����O  KADO_Disconnected_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ADO_Disconnected_WPFADO_Disconnected_WPF  5   	   %    ADO_Disconnected_WPF.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ADO_Disconnected_WPF     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ QueryBox��5   [   $��0��6   $��0��6   $��2��6/   $��10q�6C   $��80��6O   6�   �� 5   
   -   5         ��Name$ ExecuteTrigger��5   r   $��0��6   $��2��6   $��10, 15, 10, 15q�6.   $��50��6F   $��24(�6R   $
��Bold"�6`   $	��Top=�6�   .��6  Execute query6  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridView��5      $��1��6)   $��0��66   $��2��6F   $��2��6Z   $��10q�6k   6�   �� 5   
   -   5        $ execDataSet��5   �   $��0��6   $��2��6   $��10, 15, 10, 12q�6.   $��50��6F   $��Bottom=�6R   $��24(�6m   $
��Bold"�6{   .��6�   Execute data set6�   �� 5   
   -   5        $ customUpdate��5   �   $��1��6   $��2��6   $��10, 0, 10, 5q�6.   $��50��6D   $	��Top=�6P   $��24(�6h   $
��Bold"�6v   .��6�   Custom Update6�   �� 5   
   -   5        $ LogBox��5   t   $��1��6   $��2��6   $��2��6/   $��10q�6@   $	��100��6L   $��Bottom=�6Y    �� 
IsReadOnly$
 True��6�    �� TextWrapping$
 Wrap=�6�   6�   5      5      