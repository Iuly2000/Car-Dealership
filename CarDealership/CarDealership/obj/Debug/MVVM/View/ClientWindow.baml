   M S B A M L   `   `   `  ����H  DCarDealership, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CarDealership.MVVM.ViewCarDealership.MVVM.View  5   	   K*clr-namespace:CarDealership.MVVM.ViewModelCarDealership.MVVM.ViewModel  6=   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   *    $CarDealership.MVVM.View.ClientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CarDealership.MVVM.View     5   	   >context*clr-namespace:CarDealership.MVVM.ViewModel     6=   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          �Name$  clientWindow��5
   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Icon$8 2/CarDealership;component/Images/AplicationLogo.png��5   	    � Title$ Client��5   	   $	��450��6   $	��800��6%    � DataContext 5      1  +CarDealership.MVVM.ViewModel.ClientWindowVM  5   
   .��5      � ��5   
   �� 5      .��5      �  � Color$ 	#FF202688��6    � Offset$ 0Q�61   � 5      $ 	#FF29ACF0��6   $ 1Q�61   5      .+�5   
   �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5      �� $��2��6   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   $��	35,0,50,0q�6S   $	��179��6f   .+�5      �� $
��Wrap=�5       $��Client Name:��5!      
�������	 �� TextAlignment$	 Center=�5#      $��15(�5$      $	��Top=�5%      $��24��5&      �� 5'      $
��Wrap=�5(      
�������$
	 Left=�5+      $��15(�5,      $	��Top=�5-      $��24��5.      $��80��5/      ��5)      �� *Client.Name+5/      50      �� 51      $��Center=�6   $ 
Horizontal=�6:   .+�52      �� $
��Wrap=�54      $��Account Balance:��55      
�������$	 Center=�57      $��15(�58      $	��Top=�59      $��24��5:      �� 5<      $
��Wrap=�5=      
�������$
	 Left=�5@      $��15(�5A      $	��Top=�5B      $��24��5C      $��80��5D      ��5>      �� *CreditCard.Balance+5D      5E      5G      �� 5H      $��1��6   .+�5I      �� 
�������$	��Top=�5K      $ ��Welcome to our DealerShip!��5M      $��Freestyle Script)�5N      $
��Left=�5O      $��35(�5P      $��35��5Q      5R      5S      5V      � 5X   
   $
��Left=�6   $	��321��6*   $��	32,63,0,0q�67   $	��Top=�6J   $	��729��6b    5Y      �� 5Z      $
��364* �6#   �� 5[      $
��365* �6#   .+�5]      �� $��0��6   .+�5^      �� $ 
Horizontal=�6   .+�5`      �� -   5        
 ��Name$
 
profileBtn��5`   /   $��Profile��6   ��6C   �� *ProfileCommand+�� 5a      -   5        $
 creditCardBtn��5a   1   $��	Card Info��6   ��6H   �� *CreditCardCommand+�� 5b      -   5        $
 buyBtn��5b   /   $��Buy Car��6   ��6?   �� *BuyCarCommand+��6a   ��  �� ElementName$ grdCars�� �� Path$ SelectedItem��� 5c      -   5        $
 loanBtn��5c   0   $��Loan Car��6   ��6A   �� *LoanCarCommand+��6d   �� $ clientWindow���� 5d      -   5         ��Name$ 	loanCheck��5d      5e      �� 5g      $ 
Horizontal=�6   y�5h      �� $ 	loanCheck��$ 	IsChecked�    BooleanToVisibilityConverter �� 	Converter# [  .+�5j      �� $��Starting date:��6   $��18(�65   
�������6C   (  "System.Windows.Controls.DatePicker  5k      -   5          Name$ 	startDate��5k   !    �� Today   DisplayDateStart# Z 64   �� 5l      $��Ending date:��6   $��18(�63   
�������6A     5m      -   5        $ endDate��5m   !    62   �� $ 	startDate��$ SelectedDate�5n      �� 5o      -	   5        $
 
historyBtn��5o   +   $��History��6   ��6?   �� *HistoryCommand+5p      �� 5q      $��1��6   .+�5s      ]� .+�5t      �� $��Cars for sale/loan:��6    ���	#FF29ACF0
�������$��20(�5w      $��SemiBold"�5x      $	 Center=�5y      $	��Top=�5z      5{      &   System.Windows.Controls.DataGrid  5|      -
   5          Name$ grdCars��5|      ���	#FF4750F1���	#FF021D4D   
IsReadOnly .    AutoGenerateColumns .  $	��290��6�   $	��360��6�   ��6�   �� *Cars+   Columns 5}      0  *System.Windows.Controls.DataGridTextColumn  5~      ,  &System.Windows.Controls.DataGridColumn   Header$ Brand��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *Brand+  5      $ Model��6-   $	 100 6<    6H   �� *Model+  5�      $ Price��6-   $	 100 6<    6H   �� *Price+  5�      $ Fabrication Year��6-   $	 100 6G    6S   �� *FabricationYear+  5�      $ Color��6-   $	 100 6<    6H   �� *Color+  5�      $ Engine��6-   $	 100 6=    6I   �� *Engine+  5�      $ Image��6-   $	 100 6<    6H   �� $ Image�   	CellStyle 5�      �� 5�   "    �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6(   .�5�   &   ��  �� Property �@�ToolTip �� Value 5�   *   _� 5�   .   $	��200��66   $	��200��6B   
������ .��5�   2   �� $	��Top=�6V   ��68   �� $ Image�6V   5�   /   5�   '   5�   #   5�      5�      5�      5�      �� 5�   
   $
��🔙��6   $��25(�6>   $��0q�6L   
������ $
��Left=�6y   $	��Top=�6�   $��68��6�   $��41��6�   ��6   �� *BackCommand+6�   �� 5�   
   $
��🔄��6   $��25(�6A   $��0q�6O   
������ $
��Left=�6|   $��68,0,0,0q�6�   $	��Top=�6�   $��63��6�   $��41��6�    J� RenderTransformOrigin$ 0.549,0.526&�6�   ��6   �� *RefreshCommand+6�   5�      5�      