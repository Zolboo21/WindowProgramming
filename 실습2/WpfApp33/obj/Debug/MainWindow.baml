   M S B A M L   `   `   `  ����C  ?WpfApp33, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp33WpfApp33  5   	   9!clr-namespace:WpfApp33.PropertiesWpfApp33.Properties  5   	       WpfApp33.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp33     5   	   1res!clr-namespace:WpfApp33.Properties     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
        WpfApp33.ImageConverter   imageConverter  WpfApp33.HalfConverter  helfConverter 	 label �� 
TargetType �� Property �� Value �� ScaleX �� ScaleY �� Triggers :� RoutedEvent	 �� TargetProperty
 W� From	 W� To g� Duration��%0  &	        &	      &	 &       5   
   6     5   
   6   �� 5   
   " ��6   .�5      ��  � z� 5      �� 5      scaleTransform��$ 1Q�6=   $ 1Q�6H   5       5      :� 5      $ 
MouseEnter��6   .[�5      �� .��5      �� .��5      W� $	 RenderTransform.ScaleX�5   )   $
 1X�5   )   $ 2X�62   $ 0:0:1D�69   W� 5      $	 RenderTransform.ScaleY�5   !   $
 1X�5   !   $ 2X�6*   $ 0:0:1D�61   5      5      5      :� 5       $ 
MouseLeave��6   .[�5!      �� .��5"      �� .��5#      W� $	 RenderTransform.ScaleX�5$   !   $
 2X�5%   !   $ 1X�6*   $ 0:0:1D�61   W� 5&      $	 RenderTransform.ScaleY�5'   !   $
 2X�5(   !   $ 1X�6*   $ 0:0:1D�61   5)      5*      5+      5-      5.      .��5/      � .+�50   
   �� -   5         ��Name$ label��50      #��[ 6    J� RenderTransformOrigin$ 0.5, 0.5&�6>   $��한림대학교��6_   $
��Left=�6o   $��256,150,0,0q�6�   $	��Top=�6�   $��72��6�   $	��262��6�   $��50(�6�   �� 51   
   -   5        $ label2��51      $	��179��6    $��Hallym University��6-   $��Right=�6I   $��0,268,319.333,0q�6e   $	��Top=�6~   $��20(�6�   $
��Bold"�6�    � Triggers 52      :� 53      $ Loaded��6   .[�54      �� .��55      �� .��56      W� $	 Width�57   %   $
 0X�58   %   $ 0:0:2D�6/   59      5:      5;      5=      �� 5>   
   -   5         ��Name$ image��5>       J� Opacity$ 0Q�6   $
��Left=�6�   $	��100��6�   $��
300,23,0,0q�6�   $	��Top=�6�   $	��164��6�   ��6+   �� #   WpfApp33.Properties.Resources   Hallym �� Source# Z  �� 	Converter# [   5?      :� 5@      $ Loaded��6   .[�5A      �� .��5B      �� .��5C      W� $	 Opacity�5D   !   $
 0X�5E   !   $ 1X�6*   $ 0:0:2D�61   5F      5G      5H      5J      5K      5L      