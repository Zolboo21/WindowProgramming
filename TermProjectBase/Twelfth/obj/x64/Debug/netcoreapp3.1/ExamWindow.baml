   M S B A M L   `   `   `  ����B  >Twelfth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TwelfthTwelfth  5   	   5clr-namespace:Twelfth.ViewModelTwelfth.ViewModel  5   	   /clr-namespace:Twelfth.HelperTwelfth.Helper  5   	       Twelfth.ExamWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Twelfth     5   	   .vmclr-namespace:Twelfth.ViewModel     5   	   /helperclr-namespace:Twelfth.Helper     5   	     � Title$  
ExamWindow��5
   	   $	��462��6   $	��873��6)    � 	Resources 5      "  Twelfth.Helper.DateConverter   dataConverter"  Twelfth.Helper.TimeConverter  timeConverter��%:   &	        &	        5   
   6     5   
   6   5      .��5      � .+�5   
   �� -   5         ��Name$ OkBtn��5      $��Ok��6    $
��Left=�6A   $��37��6\   $��707,373,0,0q�6h   $	��Top=�6}   $	��121��6�   �� 5   
   -   5        $ CancelBtn_Copy��5      $��Cancel��6)   $
��Left=�6R   $��37��6m   $��567,373,0,0q�6y   $	��Top=�6�   $	��121��6�   �� 5   
   -   5         ��Name$ listView��5      $
��Left=�6D   $	��287��6_   $��	32,58,0,0q�6l   $	��Top=�6   $	��799��6�   ��6%   �� *Studys+ �� View 5      �� 5      .P�5      �� $��
Patient ID��6%    �� Width$	 100��69    �� DisplayMemberBinding 6E   �� *	PatientID+�� 5      $
��Name��6%   $	 100��63    6?   �� *PatientName+�� 5      $	��Sex��6%   $ 30��62    6=   �� *Sex+�� 5      $��Accession #��6%   $	 100��6:    6F   �� *AccessionNumber+�� 5      $��
Study Date��6%   $	 100��69    6E   �� *	StudyDate+ �� 	Converter# [  �� 5      $��
Study Time��6%   $	 100��69    6E   �� *	StudyTime+# [ �� 5      $��
Num Images��6%   $ 80��69    6D   �� *	NumImages+�� 5      $��Study Description��6%   $	 200��6@    6L   �� *Description+5      5      5       5!      