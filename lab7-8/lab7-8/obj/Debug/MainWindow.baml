   M S B A M L   `   `   `  ����A  =lab7-8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab7_8lab7_8  5   	       lab7_8.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:lab7_8     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      [ WWPFLocalizeExtension, Version=3.5.0.0, Culture=neutral, PublicKeyToken=c726e0262981a1eb2lex(http://wpflocalizeextension.codeplex.com  5	   	   -   5        4  .WPFLocalizeExtension.Engine.LocalizeDictionary    DesignCulture$  en��5
   	   =  7WPFLocalizeExtension.Providers.ResxLocalizationProvider   DefaultAssembly$ lab7-8��5   	      DefaultDictionary$ 	Resources��5   	   $	��500��5   !   $
��1100��6.    � Icon$ ToDoIcon.png��6R      WindowStyle#���   5   	    � Title 5   	   2  ,WPFLocalizeExtension.Extensions.LocExtension  *Title+.��5      �  � RowDefinitions 5   
   �� 5      $	��75* �6   �� 5      $	��132 �6   �� 5      $
��173* �6   �� 5      $	��89* �6    � ColumnDefinitions 5   
   �� 5      $
��173* �6   �� 5      $
��246* �6   �� 5      $
��457* �6   �� 5      $	��58* �6   �� 5      $	��58* �6   .+�5    
   � $��0��6   $��0��6   $��0,0,245,103q�6,   $��2��6A   $��2��6R    5!      �� 5"      �� 5#       5&      �� 5'      $	��45* �6#   �� 5(      $	��90* �6#   .+�5+      �� -   5         ��Name$ currentDateTextBlock��5+      $��2��66    �� TextAlignment$ Center=�6G   $	��Top=�6^   $��60(�6v   
�������$��70��6�   $��-4,20,101,0q�6�   $��./Resources/#Akrobat Bold)�6�   $��2��6�   $��22��6�   �� 5,      -   5        $ currentDayTextBlock��5,      $��1��65   $
 Left=�6E   $	��Top=�6Z   $��16(�6r   
�������$��22��6�   $��24,20,-27,0q�6�   
Среда6�   �� 5-      -   5        $ currentMonthTextBlock��5-      $��1��67   $
 Left=�6G   $	��Top=�6\   $��16(�6t   
�������$��24��6�   $��24,38,-33,0q�6�   $��2��6�   Апрель, 20206�   �� 5.      -   5        $ currenTimeTextBlock��5.      $��0��65   $��2��6E   
�������$	��Top=�6l   $��16(�6�   $ Center=�6�   $��16,10,-17,0q�6�   	 J� RenderTransformOrigin$	 
0.36,0.585&�6�   $��1��6�   
01:32:006�   50      &   System.Windows.Controls.DataGrid  52   
   -   5        
  Name$
 
dgToDoList��52   t      CanUserSortColumns . $��5��6`   $��16(�6�   $��Roboto)�6�   $��Regular"�6�      AutoGenerateColumns .  $��0,29,0,2q�6�   $��1��6�   $��2��6�   ��6   �� *TodoDataList+ �� Mode$ TwoWay=�   Columns 53      4  .System.Windows.Controls.DataGridCheckBoxColumn  55      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .  -   5        isDoneCheckBox��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 59   )      CanUserSort . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 55   )   ��  �� Path$ IsDone� �� UpdateSourceTrigger$ PropertyChanged=�   Header 58   )     *isDoneCheckBox+5:   )   5	  /MaterialDesignThemes.Wpf.DataGridComboBoxColumn	  5=       .  .  -   5        ComboBoxCategory��$	 100 5B   8   4
  .System.Windows.Controls.DataGridComboBoxColumn 
  SelectedItemBinding 5>   8   �� $ ToDoCategory� 5A   8     *ComboBoxCategory+5B   8   1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5E       .   . -	   5        todoDescription��   	MaxLength$ 50��5J   %   $ * 5K   %    5E   4   �� $ ToDoDescription� 5I   %     *todoDescription+5K   %   0  *System.Windows.Controls.DataGridTextColumn  5N       .  . -
   5        creationDate��$	 120 5S   %    5O   %   �� $ CreationDate� 5R   %     *creationDate+5S   %   4  .System.Windows.Controls.DataGridTemplateColumn  5V      -   5        deadlineDate��   SortMemberPath$ ToDoDeadline��5W   )    . $	 120 5Z   )    5Y   )     *deadlineDate+   CellTemplate 5[      �� 5\      .R�5]      �� ��6(   �� *ToDoDeadline+5^         CellEditingTemplate 5`      �� 5a      .R�5b      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *ToDoDeadline+5c      5e      	  5g       .  -   5        ComboBoxPriority��$	 120 5k   8    5g   8   �� $ ToDoPriority� 5j   8     *ComboBoxCategory+5k   8     5n      $ DaysLeft��5o   %    . -   5        daysLeft�� .  5n   %   �� $ DaysLeft� 5r   %     *
daysLeft+5s   %   5v      �� 5x   
   -   5         ��Name$ button��5y      $��EN��5z      $��Center=�5{      $��0��5|      $��3��5}      ���#00cc00  lock#���  5      $��Center=�5�      $��30��6,   $��50��68   $��	4,22,4,21q�6C   �� 5�   
   -   5        $
 save��5�      $��Center=�5�      $��3��5�      $��2��5�        SaveButtonStyle#���  5�      $��Center=�5�      $	��100��6,   $��55,29,302,28q�68   ��5�        *
saveButton+5�   8   �� 5�   
   -   5         ��Name$ SearchField��5�        SearchField#���  6'   $��30��6M   $	��120��6Y   $��1��5�      $��26,36,125,7q�6!   �� 5�   
   -   5        $ search��5�      $��Center=�5�      $��1��5�        searchButton#���  5�      $��Center=�5�      $	��100��6,   $��151,36,20,7q�68   ��5�        *searchButton+5�   8   �� 5�   
   -   5        $ clear��5�      $��Center=�5�      $��1��5�        clearButton#���  5�      $��Center=�5�      $	��100��6,   $��2��68   $��256,36,418,7q�6L   ��5�        *clearButton+5�   L   �� 5�   
   -   5        $ button1��5�      $��RU��5�      $��Center=�5�      #���  5�      $��0��5�      $��4��5�      ���#00cc00$��Center=�5�      $��50��6,   $��30��67   $��	4,22,4,21q�6C   �� 5�   
   -   5         ��Name$ lockEn��5�      $"��Деактивировать��6#   
�������$��roboto)�6O   $��14(�6c   $��2��6q   $��Center=�6�   $��Right=�6�   $��0 0 20 0q�6�   �� 5�   
   -   5         ��Name$ styleBox��5�      $��2��6%   $��30��65   $	��100��6A   $��Center=�6M     ComboBoxFlatStyle#���  6h   $
��Left=�6�   $��	90 30 0 0q�6�   ���#ffffff6�   �� 5�   
   $��3��6   $��Center=�6"   $
��10 0q�6=   .+�5�      ��   �� Orientation$  
Horizontal=�6   $��Center=�62   $
��Left=�6M   $��0 0 0 10q�6h   .+�5�      �� -   5        $ unButton��5�        doButton#���  6+   $��30��6N   $	��120��6Z   $��Center=�6�   $
��Left=�6�   ��6f     *
undoButton+6�   '  !MaterialDesignThemes.Wpf.PackIcon  5�      !   Kind$
! Undo=�6*   $��30��66   $��30��6A   $��5q�6M   ���#ffffff6X   5�      �� 5�      $  
Horizontal=�6   $��Center=�62   $
��Left=�6M   .+�5�      �� -   5        $ 
redoButton��5�      #���  6-   $��30��6P   $	��120��6\   $��Center=�6�   $
��Left=�6�   ��6h     *
redoButton+6�     5�      $
! Redo=�6*   $��30��66   $��30��6A   $��5q�6M   ���#ffffff6X   5�      5�      5�      5�      