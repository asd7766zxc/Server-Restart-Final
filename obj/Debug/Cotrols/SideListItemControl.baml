   M S B A M L   `   `   `  ����O  KServer Restart Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Server_Restart_FinalServer_Restart_Final  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5
      .    (Server_Restart_Final.SideListItemControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Server_Restart_Final     5      9system&clr-namespace:System;assembly=mscorlib     5
      $��60��5      $��0q�5	        � 	Resources  5         LatoThin  LatoRegular  LatoBold  	LatoHeavy  FontAwesome �� 
TargetType  	BaseStyle �� Property �� Value  BaseTextBlockStyle �� BasedOn  FontSizeRegular  FontSizeSmall 	 FontSizeLarge 
 ChatIcon  UserIcon  PngIcon  CogIcon  ToolIcon  BackgroundLight  BackgroundLightBrush �� Color  BackgroundTransparency  BackgroundTransparencyBrush  BackgroundTransparent  BackgroundTransparentBrush  BackgroundVeryLight  BackgroundVeryLightBrush  ForegroundMain  ForegroundMainBrush  ForegroundVeryDark  ForegroundVeryDarkBrush  ForegroundLight  ForegroundLightBrush  ForegroundLogoGreen  ForegroundLogoGreenBrush  ForegroundLogoRed   ForegroundLogoRedBrush ! 
ButtonFace " ButtonFaceBrush # ButtonTrack $ ButtonTrackBrush % Button.Static.Background & Button.Static.Border ' Button.MouseOver.Background ( Button.MouseOver.Border ) Button.Pressed.Background * Button.Pressed.Border + Button.Disabled.Background , Button.Disabled.Border - Button.Disabled.Foreground . ContentStyle �� 
TargetType ��Name J� InputBindings	 d� MouseAction
 �� Command �Name � ColumnDefinitions �� 	Converter6   0Server_Restart_Final.BooleanToVisbilityConverter �� ConverterParameter �� Padding4   .Server_Restart_Final.StringRGBToBrushConverter �� RelativeSource �� CornerRadius J� Effect-  'System.Windows.Media.Effects.BlurEffect   Radius �� Triggers �� Value �� Binding �� 
TargetName :� RoutedEvent	 �� To g� Duration �� 
TargetName �� TargetProperty P� Property P� Value��%B  &	        &	 >     &	      &	 �     &	 �     &	 <    7   &	 �    7   '�� �    7  '�� �    7  '��     7  '�� *    7  '�� L    7  &	 n    &	 �    &		 �    &	
 �    &	 �    &	 �    &	     &	      &	 9    &	 X    7  &	 p    &	 �    7  &	 �    &	 �    7  &	 �    &	     7  &	     &	 8    7  &	 P    &	 q    7  &	 �    &	 �    7  &	 �    &	 �    7  &	 �    &	      7  &	! 2    &	" S    7 ! &	# k    &	$ �    7 # &	% �    &	& �    &	' �    &	(     &	) $    &	* G    &	+ j    &	, �    &	- �    &	. �    7  7  7 ! 7 + *�5   
   *&pack://appliction;,,,/Fonts/#Lato Thin)�6N   *�5   
   -)pack://appliction;,,,/Fonts/#Lato Regular)�6T   *�5   
   *&pack://appliction;,,,/Fonts/#Lato Bold)�6N   *�5   
   +'pack://appliction;,,,/Fonts/#Lato Heavy)�6P   *�5   
   ,(pack://appliction;,,,/Fonts/#FontAwesome)�6S   �� 5   
   " ��6   .�5      ��  � ��8   6+   5      �� 5   
   " ��6   .�5      ��  � ��8   6+   5      �� 5   
   " ��6   8   6-   �� 5   
   " ��6   8   6,   �� 5   
   " ��6   8   6.   �� 5   
   " ��6   8   60   �� 5   
   " ��6   8   6/   X�5!   
   20Q�64   X�5"   
   14Q�62   X�5#   
   30Q�62   ��5%   
   w��6,   ��5&   
   U��6,   ��5'   
   v��6+   ��5(   
   x��6+   ��5)   
   x��6,   ��5+   
   #efefef��61   �� 5,   
   8   67   ��5.   
   	#0DB2EBF2��6:   �� 5/   
   8   6>   ��51   
   	#00B2EBF2��69   �� 52   
   8   6=   ��54   
   #fafafa��65   �� 55   
   8   6;   ��57   
   #686868��60   �� 58   
   8   66   ��5:   
   	#AA181818��66   �� 5;   
   8   6:   ��5=   
   #ffffff��61   �� 5>   
   8   67   ��5@   
   	#FF8BC34A��67   �� 5A   
   8   6;   ��5C   
   	#FFf44336��65   �� 5D   
   8   69   ��5F   
   	#AA404040��6.   �� 5G   
   8   62   ��5I   
   	#0000��6+   �� 5J   
   8   63   �� 5P   
   $ 	#FFDDDDDD��6;   �� 5Q   
   $ #0000��67   �� 5R   
   $ 	#AA404040��6>   �� 5S   
   $ #0000��6:   �� 5T   
   $ 	#ADC4E5F6��6<   �� 5U   
   $ 	#AD2C628B��68   �� 5V   
   $ #0000��6=   �� 5W   
   $ #0000��69   �� 5X   
   $ 	#FF594849��6=   �� 5]   
   " ��6%   .�5^      ��  � �� 5_      �� 5`      " ��6&   .R�5a      �� $ 
background��6!   ���	#00000000
�������$��0 0 0 1q�6`    5b      d� 5c   "   $	 	LeftClicke�6/   
 6G   �� *OpenPageCommand+._�5e   &   � $ 	container��6+   
������  5f   "   �� 5h   &   $
��Auto �67   �� 5i   &   $��* �67   .+�5k   "   �� ���	#FF9CCC65$	��4.5��6@   $
��Left=�6M   y�6h   �� *NewContentAvailable+   $
 True���� 5l   "   $��0��6)   $ 8q�69   ._�5m   &   �� ��6-   �� *ProfilePictrueRGB+   ��5n   )   �� *ActualHeight+ �� *Self+ 5o   )   �� *ActualHeight+ �� *Self+._�5p   *   � .+�5q   .   (� .��5r   2   �� $��Center=�5s   4   $��Center=�5t   4   $��0q�5u   4   ��5r   8   �� *ProfilePictrue+ 5v   6     5w   :   $ 0Q�6E   6R   5y   3   5z   /   5{   +   5|   '   5}   #   �� 5~   "   $��1��6)   $ 0 0 8 0q�69   ._�5   &   �� $��Center=�61   .+�5�   *   �� $��20(�64   $��CharacterEllipsis=�6B   
�������8��  ��6v   �� *Name+6�   5�   '   5�   #   5�      5�       5�      �� 5�      $
 True��6I    6*   �� *
IsSelected+.a�5�   "   �� $ 
background��6?   8   � ��6W   5�      :� 5�      $ 
MouseEnter��6+   .[�5�   "   �� .��5�   &   �� .��5�   *   �� 8  $ 0:0:0.3D�6Z   $ 	container��6m   $ Background.Color�6�   5�   '   5�   #   5�      :� 5�      $ 
MouseLeave��6+   .[�5�   "   �� .��5�   &   �� .��5�   *   �� $ TransparentX�69   $ 0:0:0.3D�6J   $ 	container��6]   $ Background.Color�6   5�   '   5�   #   5�      P� 5�       � {� .  . �5�   "   �� $ 	container��6?   8   � ��6V   5�      5�      5�      5�      5�      .��5�      �� #��[. 5�      5�      