   M S B A M L   `   `   `  ����H  DCarDealership, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CarDealership.MVVM.ViewModelCarDealership.MVVM.ViewModel  5   	   +    %CarDealership.MVVM.View.HistoryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:CarDealership.MVVM.ViewModel     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Icon$8 2/CarDealership;component/Images/AplicationLogo.png��5	   	    � Title$ History��5
   	   $	��450��6   $	��800��6&    � DataContext 5      2  ,CarDealership.MVVM.ViewModel.HistoryWindowVM  5   
   6"   .��5      � ��5   
   �� 5      .��5      �  � Color$ 	#FF202688��6    � Offset$ 0Q�61   � 5      $ 	#FF29ACF0��6   $ 1Q�61   5      .+�5   
   � $
��Left=�6   $	��371��6*   $��	10,39,0,0q�67   $	��Top=�6J   $	��774��6b    � RowDefinitions 5      �� 5      $	��43* �6    �� 5      $
��296* �6     � ColumnDefinitions 5      �� 5      $
��386* �6#   �� 5      $
��389* �6#   .+�5      �� $��Center=�6   
������� �� TextAlignment$ Center=�6H   $��25(�6_   $��Freestyle Script)�6m   $��132,10,147.6,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $��33��6�   $	��106��6�   $��	Cars Sold��6�   �� 5       $��Center=�6   
�������$ Center=�6H   $��25(�6_   $��Freestyle Script)�6m   $��153.4,10,129.4,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $��33��6�   $	��106��6�   $��Cars Loaned��6�   $��1��6�   &   System.Windows.Controls.DataGrid  5!      -   5        	  Name$	 grdCars��5!      ���	#FF4750F1���	#FF021D4D
   AutoGenerateColumns
 .     
IsReadOnly . $
��Left=�6�   $	��286��6�   $��0,47,0,0q�6�   $	��Top=�6�   $	��376��6�   $��2��6  ��6r   �� *
CarsSold+   Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Brand��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *Brand+  5$      $ Model��6)   $	 100 68    6D   �� *Model+  5%      $ Price��6)   $	 100 68    6D   �� *Price+  5&      $ Fabrication Year��6)   $	 100 6C    6O   �� *FabricationYear+  5'      $ Color��6)   $	 100 68    6D   �� *Color+  5(      $ Engine��6)   $	 100 69    6E   �� *Engine+  5)      $ 
Image path��6)   $	 100 6=    6I   �� *Image+   	CellStyle 5*      �� 5+       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6$   .�5,   "   ��  �� Property �@�ToolTip �� Value 5-   &   _� 5.   *   $	��200��62   $	��200��6>   
������ .��5/   .   �� $	��Top=�6R   ��64   ��  �� Path$ Image�6R   50   +   52   #   53      55      57        58      -   5        $	 grdCars_Loaned��58      ���	#FF4750F1���	#FF021D4D
 .   . $
��Left=�6�   $	��286��6�   $��10.4,0.8,0,0q�6�   $	��Top=�6	  $	��368��6!  $��1��6-  $��1��6=   �� SelectedItem 6]   �� *Car+��6�   �� *
CarsLoaned+ 5:        5;      $ Brand��6)   $	 100 68    6D   �� *Brand+  5<      $ Model��6)   $	 100 68    6D   �� *Model+  5=      $ Price��6)   $	 100 68    6D   �� *Price+  5>      $ Fabrication Year��6)   $	 100 6C    6O   �� *FabricationYear+  5?      $ Color��6)   $	 100 68    6D   �� *Color+  5@      $ Engine��6)   $	 100 69    6E   �� *Engine+  5A      $ 
Image path��6)   $	 100 6=    6I   �� *Image+ 5B      �� 5C      "  6$   .�5D   "   ��  �@�ToolTip 5E   &   _� 5F   *   $	��200��62   $	��200��6>   
������ .��5G   .   �� $	��Top=�6R   ��64   �� $ Image�6R   5H   +   5J   #   5K      5M      5O      �� 5P      $��See the loan period��6   $
��Left=�6R   $��326,291.8,0,0q�6m   $��1��6�   $	��Top=�6�   $	��155��6�   $��2��6�   ��63   �� *
SeeCommand+6�   �� 5Q      
�������$��1��6x   $
��Left=�6�   $��100.4,291.8,0,0q�6�   $��1��6�   $
��Wrap=�6�   $	��Top=�6�   $	��134��6�   $��32��6  ��6   �� *	StartDate+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6  �� 5R      
�������$��1��6v   $
��Left=�6�   $��239.4,291.8,0,0.2q�6�   $��1��6�   $
��Wrap=�6�   $	��139��6�    J� RenderTransformOrigin$ 0.944,0.528&�6�   ��6   �� *	EndDate+$ TwoWay=�$ PropertyChanged=�6�   5S      �� 5T   
   $��Center=�6   
�������$ Center=�6E   $��40(�6\   $��Freestyle Script)�6j   $��342,-44,319.6,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��105��6�   $	��132��6�   �� 6�   �� 6�   �� 6�   $�History��6�   �� 6  �� 6  6!  5U      5V      