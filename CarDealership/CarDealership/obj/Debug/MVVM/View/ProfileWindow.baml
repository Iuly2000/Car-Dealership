   M S B A M L   `   `   `  ����H  DCarDealership, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CarDealership.MVVM.ViewCarDealership.MVVM.View  5   	   K*clr-namespace:CarDealership.MVVM.ViewModelCarDealership.MVVM.ViewModel  5   	   +    %CarDealership.MVVM.View.ProfileWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CarDealership.MVVM.View     5   	   >context*clr-namespace:CarDealership.MVVM.ViewModel     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  profileWindow��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$8 2/CarDealership;component/Images/AplicationLogo.png��5   	    � Title$ ClientProfile��5   	   $	��400��6   $	��400��6,    � DataContext 5      2  ,CarDealership.MVVM.ViewModel.ProfileWindowVM  5   
   .��5      � ��5   
   �� 5      .��5      �  � Color$ 	#FF202688��6    � Offset$ 0Q�61   � 5      $ 	#FF29ACF0��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5!   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5"      �� $��Name:��6   $��20q�5#       
���   �	 �� TextAlignment$
	 Left=�5%       $��20(�5&       �� 5'      -   5        
 ��Name$

 name��5'      $��20(�6M   
�������$	��180��6o   $��35��6{    �� TextAlignment$
 Left=�6�   ��6$   �� *Client.Name+ �� Mode$ OneWay=�6�   5*      �� 5,   
   $��1��6   $ 
Horizontal=�6"   .+�5-      �� $��Email:��6   $��20q�5.       
���   �$
	 Left=�50       $��20(�51       �� 52      -   5        $
 email��52      $��20(�6O   
�������$	��180��6q   $��35��6}   $
 Left=�6�   ��6%   �� *Client.Email+$ OneWay=�6�   53      �� 55   
   $��2��6   $ 
Horizontal=�6"   .+�57      �� $��New Password:��6   $��20q�58       
���   �$
	 Left=�5:       $��20(�5;       G� 5<      -   5         G�Name$ password��5<   &   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ********��5>   &   
���   �$	��180��5@   &   $��35��5A   &   $��Bottom=�5B   &   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD94448y�5=   &   ��  �� ElementName$ 	checkPass�� �� Path$ 	IsChecked�    BooleanToVisibilityConverter �� 	Converter# [  5E   &   �� 5F      -   5         ��Name$ 	checkPass��5F      5H      5I      �� 5K   
   $��3��6   $ 
Horizontal=�6"   .+�5L      �� $��PhoneNumber:��6   $��20q�5M       
���   �$
	 Left=�5O       $��20(�5P       �� 5Q      -   5        $
 phoneNumber��5Q      $��20(�6[   
�������$	��180��6}   $��35��6�   $
 Left=�6�   ��6+   �� *Client.PhoneNumber+$ OneWay=�6�   5R      �� 5S   
   -   5         ��Name$ 	btnModify��5`   !   $��4��5T   !   $��Modify��5U   !   $	��130��5V   !   $��40��5W   !   $��25 0 0 0q�5X   !     MaterialDesignRaisedButton#��[ 5Y   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5Z   !   $��2q�5[   !   ���	#FFB83D40
�������$��Center=�5^   !    � ToolTip$ Modify��5_   !   ��5a   !   �� *ModifyCommand+$ OneWay=���5b   !   �� $ profileWindow��5c      5d      