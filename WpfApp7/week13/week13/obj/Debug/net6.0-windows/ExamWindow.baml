   M S B A M L   `   `   `  ����A  =week13, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:week13week13  5   	   3clr-namespace:week13.ViewModelweek13.ViewModel  5   	       week13.ExamWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:week13     5   	   -vmclr-namespace:week13.ViewModel     5   	     � Title$  
ExamWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5
      *  $week13.ViewModel.ExamWindowViewModel  5   
   .��5      � .+�5   
   �� -   5        $��cancel��5   &   $
��Left=�67   $��324,329,0,0q�6R   $	��Top=�6g   $��30��6   $	��192��6�   �� 5   
   -   5        $��ok��5   "   $
��Left=�6/   $��582,329,0,0q�6J   $	��Top=�6_   $��35��6w   $	��164��6�   �� 5   
   -   5         ��Name$ listView��5      $��28,39,10,110q�6E   ��6%   �� *Studys+ �� View 5      �� 5      .P�5      �� $��
Patient ID��6%    �� Width$	 100��69    �� DisplayMemberBinding 6E   �� *	PatientID+�� 5      $
��Nmae��6%   $	 100��63    6?   �� *PatientName+�� 5      $	��Sex��6%   $ 30��62    6=   �� *Sex+�� 5      $��Accession #��6%   $	 100��6:    6F   �� *AccessionNumber+�� 5      $��
Study Date��6%   $	 100��69    6E   �� *	StudyDate+�� 5      $��
Study Time��6%   $	 100��69    6E   �� *	StudyTime+�� 5      $��
Num Images��6%   $ 80��69    6D   �� *	NumImages+�� 5      $��Study Description��6%   $	 200��6@    6L   �� *Description+5      5      5       5!      