   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	         WpfApp3.MainWindowViewMode  5
   
   .��5      � $	��120��6   $	��300��6   .+�5   
   �� -   5         ��Name$ textBlock_Euro��5      $
��Left=�6,   $��30��6G   $��	22,32,0,0q�6S   $��Amount in Euro ��6f   $
��Wrap=�6}   $	��Top=�6�   $	��136��6�   �� 5   
   -   5        $ textBlock_US��5      $
��Left=�6*   $��31��6E   $��	22,74,0,0q�6Q   $��Amount in US ��6d   $
��Wrap=�6y   $	��Top=�6�   $	��136��6�   �� 5   
   -   5        $ textBlock_US_Value��5      $
��Left=�60   $��16��6K   $��
160,72,0,0q�6W   $
��Wrap=�6�   $	��Top=�6�   $��60��6�   ��6k   ��  �� Path$ Dollars�6�   �� 5   
   -   5         ��Name$ textBox_EuroValue��5      $
��Left=�6-   $��22��6H   $��
158,32,0,0q�6T    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��60��6�   ��6h   �� $ Euros� �� UpdateSourceTrigger$ PropertyChanged=�6�   5      5      