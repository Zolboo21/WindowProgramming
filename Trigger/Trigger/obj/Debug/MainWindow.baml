   M S B A M L   `   `   `  ����B  >Trigger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TriggerTrigger  5   	       Trigger.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Trigger     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         ButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers �� Value	 �� Binding
 �� ElementName �� Path P� Property P� Value  Trigger.HalfConverter  halfConverter��%�  &	        &	 z    �� 5
   
   " ��6$   .�5      ��  � ��
 �2͚�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� #��z��6%   #��z��6E   $ 10��5   %   $��1q�67   
���  ��#��z��6]   ._�5   "   �� $��Center=�63   $��Center=�6P   5      5       5      �� 5      $ 10��6]   	 6*   �� $
 textBox��$
 text�.a�5   "   ��  � ��
 �����6?   5      P� 5       �@J�IsMouseOver . . �5   "   ��  � ��
 � ���6?   5      P� 5       � �� . . �5   "   ��  � ��
 ��  �6?   5      5       5"      5#        5$   
   6   5%      .��5&      � .+�5'   
   �� -   5         ��Name$ button��5'      #��[  6!   $��Button��6F   $��Center=�6W   $��Center=�6t   $	��113��6�   $	��131��6�   z�5(      �� 5)      -   5        animatedTransform�� �� Angle$ 0Q�5)   =    �� CenterX 5*   "   �� $
 button��$ Width� �� 	Converter# [  �� CenterY 5+   "   �� $
 button��$ Width�# [  � Triggers 5-      :� 5.       :� RoutedEvent$ Button.Click��6   .[�5/      �� .��50      �� .��51      W�  �� 
TargetName$ animatedTransform��52   !    �� TargetProperty$ Angle�53   !    W� From$ 0X�54   !   	 W� To$	 360X�6*    g� Duration$ 0:0:1D�63   55      56      57      59      5:      5;      