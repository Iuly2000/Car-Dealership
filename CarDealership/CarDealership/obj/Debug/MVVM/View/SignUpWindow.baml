   M S B A M L   `   `   `  ����H  DCarDealership, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CarDealership.MVVM.ViewCarDealership.MVVM.View  5   	   K*clr-namespace:CarDealership.MVVM.ViewModelCarDealership.MVVM.ViewModel  5   	   *    $CarDealership.MVVM.View.SignUpWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CarDealership.MVVM.View     5   	   >context*clr-namespace:CarDealership.MVVM.ViewModel     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  signUp��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Icon$8 2/CarDealership;component/Images/AplicationLogo.png��5   	    � Title$ SignUp��5   	   $	��450��6   $	��800��6%   ��5      �� 5   
    �� ImageSource$2 ,/CarDealership;component/Images/SignUpBG.jpg��6   6R    � DataContext 5      1  +CarDealership.MVVM.ViewModel.SignUpWindowVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� 
������$��0,0,3,0q�6+   ._�5      �� $��0��6   .+�5      �� $��Personal Information:��6   $��20q�5       
���   � �� TextAlignment$
 Left=�5       $��50(�5        $��Freestyle Script)�5!       �� 5#       �� Orientation$ 
Horizontal=�6   .+�5$      �� $��Name:��6    $��20q�5%       
���   �$
 Left=�5'       $��20(�5(       �� 5)      -   5        	 ��Name$
	 name��5)      $��20(�6,   
�������$	��180��6N   $��35��6Z   
 �� TextAlignment$

 Left=�6f   5,      �� 5.      $ 
Horizontal=�6   .+�5/      �� $��Email:��6   $��20q�50       
���   �$
 Left=�52       $��20(�53       �� 54      -   5        $	 email��54      $��20(�6-   
�������$	��180��6O   $��35��6[   $

 Left=�6g   55      �� 57      $ 
Horizontal=�6   .+�58      �� $��	Password:��6   $��20q�59       
���   �$
 Left=�5;       $��20(�5<       G� 5=      -   5         G�Name$ password��5=   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ********��5>   &   
���   �$	��180��5@   &   $��35��5A   &   $��Bottom=�5B   &   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD944485E   &   5F      �� 5H      $ 
Horizontal=�6   .+�5I      �� $��PhoneNumber:��6   $��20q�5J       
���   �$
 Left=�5L       $��20(�5M       �� 5N      -   5        $	 phoneNumber��5N      $��20(�63   
�������$	��180��6U   $��35��6a   $

 Left=�6m   5O      �� 5P      -   5         ��Name$ btnLogin��5[   !   $��Create Account��5P      $	��130��5Q   !   $��40��5R   !   $��25 0 0 0q�5S   !      MaterialDesignRaisedButton#��[  5T   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5U   !   $��2q�5V   !   ���	#FFB83D40
�������$
��Left=�5Y   !    � ToolTip$ Create Account��5Z   !   ��5\   !   �� *SignUpCommand+ �� Mode$ OneWay=���5]   !   ��  �� ElementName$ signUp��5^      5_      �� 5`   
   $��1��6   .+�5a      �� $��Credit Card Information:��6   $��20q�5b       
���   �$
 Left=�5d       $��50(�5e       $��Freestyle Script)�5f       �� 5g      $ 
Horizontal=�6   .+�5h      �� $��Brand:��6   $��20q�5i       
���   �$
 Left=�5k       $��20(�5l       �� 5m      -   5        $	 brand��5m      $��20(�6)   
�������$	��180��6K   $��35��6W   $

 Left=�6c   5p      �� 5r      $ 
Horizontal=�6   .+�5s      �� $��Country:��6   $��20q�5t       
���   �$
 Left=�5v       $��20(�5w       �� 5x      -   5        $	 country��5x      $��20(�6+   
�������$	��180��6M   $��35��6Y   $

 Left=�6e   5y      �� 5{      $ 
Horizontal=�6   .+�5|      �� $��Bank:��6   $��20q�5}       
���   �$
 Left=�5       $��20(�5�       �� 5�      -	   5        $
	 bank��5�      $��20(�6(   
�������$	��180��6J   $��35��6V   $

 Left=�6b   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Balance:��6   $��20q�5�       
���   �$
 Left=�5�       $��20(�5�       �� 5�      -
   5        $	 balance��5�      $��20(�6+   
�������$	��180��6M   $��35��6Y   $

 Left=�6e   5�      5�      5�      5�      