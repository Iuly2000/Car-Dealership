   M S B A M L   `   `   `  ����H  DCarDealership, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CarDealership.MVVM.ViewCarDealership.MVVM.View  5   	   K*clr-namespace:CarDealership.MVVM.ViewModelCarDealership.MVVM.ViewModel  5   	   .    (CarDealership.MVVM.View.CreditCardWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CarDealership.MVVM.View     5   	   >context*clr-namespace:CarDealership.MVVM.ViewModel     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  creditCardWindow��5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Icon$8 2/CarDealership;component/Images/AplicationLogo.png��5   	    � Title$ 
CreditCard��5   	   $	��400��6   $	��400��6)    � DataContext 5      5  /CarDealership.MVVM.ViewModel.CreditCardWindowVM  5   
   .��5      � ��5   
   �� 5      .��5      �  � Color$ 	#FF202688��6    � Offset$ 0Q�61   � 5      $ 	#FF29ACF0��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5!   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5"      �� $��Brand:��6   $��20q�5#       
���   �	 �� TextAlignment$
	 Left=�5%       $��20(�5&       �� 5'      -   5        
 ��Name$
 brand��5'      $��20(�6T   
�������$	��180��6v   $��35��6�    �� TextAlignment$
 Left=�6�   ��6%   �� *CreditCard.Brand+ �� Mode$ OneWay=�6�   5*      �� 5,   
   $��1��6   $ 
Horizontal=�6"   .+�5-      �� $��Country:��6   $��20q�5.       
���   �$
	 Left=�50       $��20(�51       �� 52      -   5        $
 country��52      $��20(�6W   
�������$	��180��6y   $��35��6�   $
 Left=�6�   ��6'   �� *CreditCard.Country+$ OneWay=�6�   53      �� 55   
   $��2��6   $ 
Horizontal=�6"   .+�57      �� $��Bank:��6   $��20q�58       
���   �$
	 Left=�5:       $��20(�5;       �� 5<      -   5        $

 bank��5<      $��20(�6R   
�������$	��180��6t   $��35��6�   $
 Left=�6�   ��6$   �� *CreditCard.Bank+$ OneWay=�6�   5>      �� 5@   
   $��3��6   $ 
Horizontal=�6"   .+�5A      �� $��Balance:��6   $��20q�5B       
���   �$
	 Left=�5D       $��20(�5E       �� 5F      -   5        $
 balance��5F      $��20(�6X   
�������$	��180��6z   $��35��6�   $
 Left=�6�   ��6'   �� *CreditCard.Balance+$ OneWay=�6�   5G      �� 5H   
   -   5         ��Name$ 	btnModify��5U   !   $��4��5I   !   $��Modify��5J   !   $	��130��5K   !   $��40��5L   !   $��25 0 0 0q�5M   !      MaterialDesignRaisedButton#��[  5N   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5O   !   $��2q�5P   !   ���	#FFB83D40
�������$��Center=�5S   !    � ToolTip$ Modify��5T   !   ��5V   !   �� *ModifyCommand+$ OneWay=���5W   !   ��  �� ElementName$ creditCardWindow��5X      5Y      