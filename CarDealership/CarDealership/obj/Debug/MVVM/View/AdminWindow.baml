   M S B A M L   `   `   `  ����H  DCarDealership, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CarDealership.MVVM.ViewModelCarDealership.MVVM.ViewModel  5   	   K*clr-namespace:CarDealership.MVVM.ViewModelCarDealership.MVVM.ViewModel  5   	   =#clr-namespace:CarDealership.HelpersCarDealership.Helpers  5	   R   )    #CarDealership.MVVM.View.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >context*clr-namespace:CarDealership.MVVM.ViewModel     5   	   <local*clr-namespace:CarDealership.MVVM.ViewModel     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   9validationrules#clr-namespace:CarDealership.Helpers  6R     � WindowStartupLocation$  CenterScreen=�5
   	    � Icon$8 2/CarDealership;component/Images/AplicationLogo.png��5   	    � Title$ Administrator��5   	   $	��460��6   $	��800��6,    � WindowStyle$ SingleBorderWindow=�68    � DataContext 5      0  *CarDealership.MVVM.ViewModel.AdminWindowVM  5   
    � 	Resources 5       	  admin��%   &	          5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��19* �6   �� 5      $	��65* �6   ��5   
   �� 5      .��5      �  � Color$ 	#FF202688��6    � Offset$ 0Q�61   � 5      $ 	#FF29ACF0��6   $ 1Q�61   5      .+�5   
   � $
��Left=�6   $	��335��6*   $��	10,85,0,0q�67   $	��Top=�6J   $	��756��6b   $��2��6n    5      �� 5       $	��34* �6    �� 5!      $
��231* �6    	 � ColumnDefinitions	 5#      �� 5$      $
��125* �6#   �� 5%      $
��112* �6#   �� 5&      $	��15* �6#   .+�5(      �� $
��Left=�6   $��	154,1,0,0q�63   $
��Wrap=�6F   $��Add Car��6Z   
�������$��20(�6|   $	��Top=�6�   �� 5)      $��1��6   $
��Left=�6(   $��
90.8,1,0,0q�6C   $
��Wrap=�6W   $��Modify or Delete Car��6k   
�������$��20(�6�   $	��Top=�6�   $	��215��6�   $��42��6�   � 5*      $
��Left=�6   $	��250��6.   $��	21,43,0,0q�6;   $	��Top=�6N   $	��336��6f   $��2��6r    5+      �� 5,      $	��30* �6$   �� 5-      $	��32* �6$   �� 5.      $	��31* �6$   �� 5/      $	��31* �6$   �� 50      $	��30* �6$   �� 51      $	��30* �6$   �� 52      $	��29* �6$   	 55      �� 56      $	��83* �6'   �� 57      $	��85* �6'   .+�59      �� $
��Left=�6   $��53,0,0,0q�67   $
��Wrap=�6I   $��Brand��6]   
�������$��15(�6}   $	��Top=�6�   $��20��6�   $��39��6�   �� 5:      $
��Left=�6   $��
53,4.6,0,0q�67   $��1��6K   $
��Wrap=�6X   
�������$��15(�6   $��Model��6�   $	��Top=�6�   $��20��6�   $��43��6�   �� 5;      $
��Left=�6   $��
54,5.2,0,0q�67   $��2��6K   $
��Wrap=�6X   
�������$��15(�6   $��Price��6�   $	��Top=�6�   $��20��6�   $��44��6�   �� 5<      $
��Left=�6   $��
28,4.4,0,0q�67   $��3��6K   $
��Wrap=�6X   
�������$��13(�6   $��Fabrication year��6�   $	��Top=�6�   $��17��6�   $	��104��6�   �� 5=      $
��Left=�6   $��
54,3.2,0,0q�67   $��4��6K   $
��Wrap=�6X   
�������$��15(�6   $��Color��6�   $	��Top=�6�   $��20��6�   $��36��6�   �� 5>      $
��Left=�6   $��
53,4,0,7.2q�67   $��5��6K   $
��Wrap=�6X   
�������$��15(�6   $��Engine��6�   $��49��6�   �� 5?      $
��Left=�6   $��53,9,0,0q�67   $��6��6I   $
��Wrap=�6V   
�������$��15(�6}   $��Image��6�   $	��Top=�6�   $��20��6�   $��2��6�   $��49��6�   �� 5@      
 �� 
IsEditable
 . $��1��6g   $
��Left=�6w   $��27.6,-5,0,0q�6�   $	��Top=�6�   $	��120��6�   $��25��6�   ��6-   �� *Brands+ �� Text 6L   �� *	Car.Brand+6�   �� 5A      $��1��66   $
��Left=�6F   $��23��6a   $��27.6,1.8,0,0q�6m   $��1��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   �� *	Car.Model+6�   �� 5B      $��1��6   $
��Left=�6+   $��23��6F   $��27.6,2.2,0,0q�6R   $��2��6h   $
 Wrap=�6u   $	��Top=�6�   $	��120��6�   .��6�   ��5C      �� 5D       �� Path$ 	Car.Price�6"    �� ValidationRules 5E      0  *CarDealership.Helpers.NumberValidationRule  5F   "   5H      .��5I   $   5J      �� 5K      $��1��6D   $
��Left=�6T   $��23��6o   $��27.6,1.2,0,0q�6{   $��3��6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   �� $ Car.FabricationYear�6�   �� 5L      $��1��6:   $
��Left=�6J   $��23��6e   $��27.6,0.2,0,0q�6q   $��4��6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   �� $ 	Car.Color�6�   �� 5M      $
��Left=�6;   $��23��6V   $��
27.6,2,0,0q�6b   $��5��6v   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��1��6�   ��6   �� $ 
Car.Engine�6�   �� 5N      $��Choose��6   $
��Left=�6*   $��43.6,5.8,0,0q�6E   $��6��6[   $	��Top=�6h   $��78��6�    J� RenderTransformOrigin$ 0.867,0.585&�6�   $��1��6�   $��26��6�   ��6�   �� *ImageCommand+5O      �� 5P      $	��Add��6   $
��Left=�6B   $��103,254.8,0,0q�6]   $��1��6t   $	��Top=�6�   $	��217��6�   ��6#   �� *
AddCommand+6�   &   System.Windows.Controls.DataGrid  5Q      -   5        $��grdCars��5Q      ���	#FF4750F1���	#FF021D4D   AutoGenerateColumns .  $
��Left=�6�   $	��240��6�   $��
375,43,0,0q�6�   $	��Top=�6�   $	��381��6�   $��2��6�   $��3��6�   ��6p   �� *Cars+   Columns 5R      0  *System.Windows.Controls.DataGridTextColumn  5S      ,  &System.Windows.Controls.DataGridColumn   Header$ Brand��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *Brand+  5T      $ Model��6)   $	 100 68    6D   �� *Model+  5U      $ Price��6)   $	 100 68    6D   �� *Price+  5V      $ Fabrication Year��6)   $	 100 6C    6O   �� *FabricationYear+  5W      $ Color��6)   $	 100 68    6D   �� *Color+  5X      $ Engine��6)   $	 100 69    6E   �� *Engine+  5Y      $ 
Image path��6)   $	 100 6=    6I   �� *Image+   	CellStyle 5Z      �� 5[       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6$   .�5\   "   ��  �� Property �@�ToolTip �� Value 5]   &   _� 5^   *   $	��200��62   $	��200��6>   
������ .��5_   .   �� $	��Top=�6R   ��64   �� $ Image�6R   5`   +   5b   #   5c      5e      5g      �� 5h      $��Modify��6   $
��Left=�6�   $��198.8,254.8,0,0q�6�   $��1��6�   $	��Top=�6�   $	��172��6�   $��1��6�   $��2��6  ��6&   �� *ModifyCommand+��6H   ��  �� ElementName$ grdCars��$ SelectedItem�6  �� 5i      $��Delete��6   $
��Left=�6�   $��11.8,254.8,0,0q�6�   $��1��6�   $	��Top=�6�   $	��182��6�   $��1��6�   ��6&   �� *DeleteCommand+��6H   �� *SelectedItem+$ grdCars��6�   5j      �� 5k   
   $
��Wrap=�6   $��Administrator��6(   $��298,7,305.6,46.6q�6=   
������� �� TextAlignment$ Center=�6j   $��40(�6�   $��Freestyle Script)�6�   �� 5l   
   $
��🔙��6   $��25(�6>   $��0q�6L   
������ $
��Left=�6y   $	��Top=�6�   $��68��6�   $��41��6�   ��6   �� *BackCommand+6�   �� 5m   
   $
��🔄��6   $��25(�6A   $��0q�6O   
������ $
��Left=�6|   $��68,0,0,0q�6�   $	��Top=�6�   $��63��6�   $��41��6�   $ 0.549,0.526&�6�   ��6   �� *RefreshCommand+6�   �� 5n   
   $
��Left=�6   $��
522,17,0,0q�6/   $
��Wrap=�6C   $��Account Balance:��6W   
�������$ Center=�6�   $��20(�6�   $	��Top=�6�   $��24��6�   $	��159��6�   �� 5o   
   $
��Left=�6   $��23��6-   $��
686,18,0,0q�69   $
 Wrap=�6M   $	��Top=�6z   $��99��6�   ��6a   �� *	Balance+6�   �� 5p   
   $
��Left=�6   $��
522,46,0,0q�6/   $
��Wrap=�6C   $��	Add Money��6W   
�������$ Center=�6{   $��15(�6�   $	��Top=�6�   $��25��6�   $��85��6�   �� 5q   
   $
��Left=�6   $��23��6-   $��
612,41,0,0q�69   $
 Wrap=�6M   $	��Top=�6x   $��69��6�   ��6a   �� *Money+6�   �� 5r   
   $	��Add��6   $
��Left=�6C   $��
686,47,0,0q�6^   $	��Top=�6r   $��80��6�   $��19��6�   $��10(�6�   ��6   �� *AddMoneyCommand+6�   �� 5s   
   $��Car History��6   $��0q�6J   
������ $
��Left=�6w   $��	10,35,0,0q�6�   $	��Top=�6�   $	��106��6�   $��31��6�   ��6'   �� *HistoryCommand+6�   5z      5{      