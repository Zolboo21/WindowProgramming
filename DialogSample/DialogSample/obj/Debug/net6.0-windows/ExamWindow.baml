   M S B A M L   `   `   `  ����G  CDialogSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DialogSampleDialogSample  5   	   ?$clr-namespace:DialogSample.ViewModelDialogSample.ViewModel  5   	   9!clr-namespace:DialogSample.HelperDialogSample.Helper  5   	       DialogSample.ExamWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DialogSample     5   	   3vm$clr-namespace:DialogSample.ViewModel     5   	   4helper!clr-namespace:DialogSample.Helper     5   	     � Title$  
ExamWindow��5
   	   $	��450��6   $	��900��6)    � DataContext 5      0  *DialogSample.ViewModel.ExamWindowViewModel  5   
    � 	Resources 5      '  !DialogSample.Helper.dataConverter   dataConverter'  !DialogSample.Helper.timeConverter  timeConverter��%:   &	        &	        5   
   6     5   
   6   5      .��5      � .+�5   
   �� -   5         ��Name$ 	CancelBtn��5      $��Cancel��6$   $
��Left=�6M   $��594,365,0,0q�6h   $	��Top=�6}   $��30��6�   $	��109��6�   �� 5   
   -   5        $ OkBtn��5      $��Ok��6    $
��Left=�6A   $��727,365,0,0q�6\   $	��Top=�6q   $��30��6�   $	��109��6�   �� 5   
   -   5         ��Name$ listView��5      $	��800��6D   $��47,40,53,109q�6Q   ��6%   �� *Studys+ �� View 5      �� 5      .P�5      �� $��
Patient ID��6%    �� Width$	 100��69    �� DisplayMemberBinding 6E   �� *	PatientID+�� 5      $
��Name��6%   $	 100��63    6?   �� *PatientName+�� 5      $	��Sex��6%   $ 30��62    6=   �� *Sex+�� 5      $��Accession #��6%   $	 100��6:    6F   �� *AccessionNumber+�� 5      $��
Study Date��6%   $	 100��69    6E   �� *	StudyDate+ �� 	Converter# [  �� 5      $��
Study Time��6%   $	 100��69    6E   �� *	StudyTime+# [ �� 5      $��
Num Images��6%   $ 80��69    6D   �� *	NumImages+�� 5      $��Study Description��6%   $	 200��6@    6L   �� *Description+5       5"      5#      5$      