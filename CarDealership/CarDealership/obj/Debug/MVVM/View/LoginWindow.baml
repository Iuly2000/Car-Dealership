   M S B A M L   `   `   `  ����H  DCarDealership, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CarDealership.MVVM.ViewCarDealership.MVVM.View  5   	   K*clr-namespace:CarDealership.MVVM.ViewModelCarDealership.MVVM.ViewModel  5   	       CarDealership.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CarDealership.MVVM.View     5   	   >context*clr-namespace:CarDealership.MVVM.ViewModel     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  login��5	   	    � Icon$8 2/CarDealership;component/Images/AplicationLogo.png��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Login��5   	   $	��450��6   $	��800��6$    � WindowStyle$ SingleBorderWindow=�60    � DataContext 5      0  *CarDealership.MVVM.ViewModel.LoginWindowVM  5   
   .��5      � ��5   
   �� 5      .��5      �  � Color$ 
BlueViolet��6    � Offset$ 1Q�62   � 5      $	 Red��6   $ 0Q�6+   5      .+�5   
   �� $	��390��6   $	��Top=�6    �� CornerRadius$ 	0 0 180 0��66   
������5      �� 5   
   	 �� Orientation$	 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $.��(/CarDealership;component/Images/Logo.PNG��6   $	��230��6J   $	��200��6V   $��Bottom=�6c   $��Right=�6~   $��0 55 0 0q�6�   5      �� 5       $	��350��6   .+�5!      �� $��20 40q�6   .+�5"      �� $��
User Login��6    $��20q�5#       
�������
 �� TextAlignment$
 Center=�5%       $��40(�5&       $��Freestyle Script)�5'       �� 5(      $	 
Horizontal=�6!   $��10q�6:   .+�5)      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��26��5*   5   $��26��5+   5   
�������5,   5   �� 5-      -   5         ��Name$ txtemail��5-   "   $
��10 0q�5.   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter Email��5/   "   
�������$	��250��51   "   
������� �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD9444854   "   55      �� 56      $	 
Horizontal=�6!   $��10q�6:   .+�57        $
 Lock=�62   $��26��58   2   $��26��59   2   
�������5:   2   G� 5;      -   5         G�Name$ txtpassword��5;   &   $
��10 0q�5<   &   $ ********��5=   &   
�������$	��250��5?   &   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD944485B   &   5C      �� 5D      $��Center=�5E   !   $	 
Horizontal=�5F   !   .+�5I      �� -   5         ��Name$ btnLogin��5R   !   $��Login��5I   !   $��78��5J   !   $��35��5K   !      MaterialDesignRaisedButton#��[  5L   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5M   !   $��2q�5N   !   ���#D94448
������� � ToolTip$ Login��5Q   !   ��5S   !   �� *LoginCommand+ �� Mode$ OneWay=���5T   !   ��  �� ElementName$ login���� 5U      $��Don't have an account?��6    $��24��6A   5W      �� 5X      -   5        $ 	btnSignUP��5a   !   $��SignUp��5X   !   $��78��5Y   !   $��35��5Z   !   #��[  5[   !   $ 10��5\   !   $��2q�5]   !   ���#D94448
�������$ SignUp��5`   !   ��5b   !   �� *SignUpCommand+$ OneWay=�5c      5d      5e      5f      5g      5h      