   M S B A M L   `   `   `  ���� O  KServer Restart Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Server_Restart_FinalServer_Restart_Final  #    Server_Restart_Final.MainPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:Server_Restart_Final     c _Microsoft.Expression.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  $��0 0 100 400q�  N� Title$  MainPage�� J� Effect -  'System.Windows.Media.Effects.BlurEffect  -   	BlurP��   Radius$ 0Q� � Triggers :�  :� RoutedEvent$ Loaded��.[��� .���� .��W�  �� 
TargetName$ BlurP�� �� TargetProperty$ Radius�	 W� To$ 0X� g� Duration$ 0:0:0.5D�:� $ Unloaded��.[��� .���� .��W� $ BlurP��$ Radius�$	 100X�$ 0:0:0.01D�	 � 	Resources	    TextBox.Static.Border
 �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  OutPutTextBoxStyle �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name J� SnapsToDevicePixels ��Name3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Opacity �� Triggers P� Property P� Value �� 
TargetName	 �� To �� Triggers ]� 
Conditions �� Property �� Value  OutPutTextBoxStyle1  FocusVisual �� StrokeDashArray  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background 	 Button.MouseOver.Border 
 Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  StartServerButton ��Name  ReStartServerButton  StopServerButton  StausButton��%�  &	        &	      &	 *     &	 ?     7   7  7  &	 �    7   7  7  &	 �    &	 '	    &	 <	    &	 Q	    &		 f	    &	
 {	    &	 �	    &	 �	    &	 �	    &	 �	    &	 �	    7  7  7  7  7  7  &	     7  7  7  7  7  7  &	 R    7  7  7  7  7  7  &	 �    7  7  7  7  7  7  �� $
 	#FFABAdB3���� $
 	#FF7EB4EA���� $
 	#FF569DE5���� " ��.���  � �� �	#0D555555��  � ��8   ��  � ��# � ����  � ��$ 1q���  � ��$ 10q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border�����	#FF000000$��1q����	#AA181818 . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=�   $ 5Q�$	 0.2Q� P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8   � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8   � ��:� $ 
MouseEnter��.[��� .���� .���� $ #121212X�$ 0:0:0.3D�$ border��$ Background.Color�:� $ 
MouseLeave��.[��� .���� .���� $ 	#AA181818X�$ 0:0:0.3D�$ border��$ Background.Color� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /��� " ��.���  � �� �	#0D555555��  � ��8   ��  � ��# � ����  � ��$ 1q���  � ��$ 10q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border�����	#FF000000$��1q����	#AA36393F . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=�   $ 5Q�$	 0.2Q� P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8   � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8   � ��:� $ 
MouseEnter��.[��� .���� .���� $ #121212X�$ 0:0:0.3D�$ border��$ Background.Color�:� $ 
MouseLeave��.[��� .���� .���� $ 	#AA36393FX�$ 0:0:0.3D�$ border��$ Background.Color� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /��� .���  � �� �� .R��� $��2q� . #��� ��$��1��$	 1 2R��� $
 	#FFDDDDDD���� $
 	#FF707070���� $
 	#FFBEE6FD���� $
 	#FF3C7FB1���� $
 	#FFC4E5F6���� $
 	#FF2C628B���� $
 	#FFF4F4F4���� $
 	#FFADB2B5���� $
 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��
 �������  � ��$ 1q���  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border�����#80DEEA$��1 0 0 0q����	#AA232323 . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border�� � �� �	#0DD7CCC8�� $ border�� � �� �#8BC34AP�  � �� . . ��� $ border�� � �� �	#00000000�� $ border�� � �� �	#00000000P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��
 �������  � ��$ 1q���  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border�����#80DEEA$��1 0 0 0q����	#AA232323 . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border�� � �� �	#0DD7CCC8�� $ border�� � �� �#8BC34AP�  � �� . . ��� $ border�� � �� �	#00000000�� $ border�� � �� �	#00000000P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��
 �������  � ��$ 1q���  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border�����#80DEEA$��1 0 0 0q����	#AA232323 . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border�� � �� �	#AAf44336�� $ border�� � �� �#8BC34AP�  � �� . . ��� $ border�� � �� �	#00000000�� $ border�� � �� �	#00000000P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��
 �������  � ��$ 1q���  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border�����#80DEEA$��0 0 0 0q����	#AA232323 . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border�� � �� �	#0DD7CCC8�� $ border�� � �� �#8BC34AP�  � �� . . ��� $ border�� � �� �	#00000000�� $ border�� � �� �	#00000000P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ��.��� $
��Auto��$��20q����	#AA282828 � ColumnDefinitions �� $��50 ��� $��* ��� $��* �  � RowDefinitions  �� $��* ��� $��8* ��� $��* �.+�� $��2��$��0��$	��500��.+��� $	��IoC��
��� � �$��1q�$��25(�$��Center=�$��Center=�� $��2��$��1��$	��500��.+��� -   ! ��Name$! 	IoCOutPut��$��12(�" �� 
IsReadOnly" . $��1��# �� TextWrapping$
# Wrap=�$
��Left=�$	��Top=�"$ �� VerticalScrollBarVisibility$$ Visible=�$	��500��$	��500��$��0 0 0 0q�
���   �
���2�2�#���  � $��0��$��1��  �� $��50 ��� $��50 ��� $��50 ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -   % ��Name$% StartServerBtn��$��0��$
��Left=�
�������$��Start��$��50��$��50��
�������#���  �� -   $% StopServerBtn��$��1��
�������$
��Stop��$��50��$��50��
�������#���  �� -   $% RestartServerBtn��$��2��
�������$��Restart��$��50��$��50��
�������#���  �� -   $% 
CommandBtn��$��4��
�������$
��Auto��$��50��
�������#���  �� -   $% CommandBtn1��$��5��
�������$
��Auto��$��50��
�������#���  �� -   $% CommandBtn2��$��6��
�������$
��Auto��$��50��
�������#���  �� -	   $% CommandBtn3��$��7��
�������$
��Auto��$��50��
�������#���  �� -
   $% CommandBtn5��$��9��
�������$
��Auto��$��50��
�������#���  �� -   $% CommandBtn4��$��8��
�������$
��Auto��$��50��
�������#���  �� -   $% CommandBtn6��$��10��
�������$
��Auto��$��50��
�������#���  �� -   $% CommandBtn7��$��11��
�������$
��Auto��$��50��
�������#���  �� -   $% CommandBtn8��$��12��
�������$
��Auto��$��50��
�������#���  �� -   $% CommandBtn9��$��13��
�������$
��Auto��$��50��
�������#���  �� -   & ��Name$& 
DrawCanvas��$��1��$��0��$��0 0 0 0q�.+��� -   ' ��Name$	' Out��
�������$��23(��� $��10q�$��1��$��1�����	#0D000000.+��� -   $! OutPut��" . $��1��$
# Wrap=�$
��Left=�$	��Top=�$$ Visible=�
�������$��10(�$	��450��$	��800��$��0 0 0 0q�
���   �#���  �� -   $! ServerInput��$��10(�
����������#36393F#���  �� -   ( ��Name$( ServerState��$��12(�
�������$�� ��� .+� � -   $��
IMainFrame��$
��Auto��$
��Auto��)  � NavigationUIVisibility$) Hidden=�$��10q�$��Stretch=�$��Stretch=�� $��1�� �� $��* ��� $��2* ��� $	��100 �.+��� -   $( CrashOut��$��1��$��
60 0 100 0q�$��20��$��10(�
�������$��Last Crash:���� -   $( 
StoppedOut��$��0��$��0 0 0 0q�$��Center=�$��Center=�$��10(�
��������� $��1��$	��100��$	��100��$��Right=�.+��   �� $��* ��� $��* ��� $��* �.+��� $
��Idle��
�������$��Center=�$��Center=��� $��1��$��Starting��
�������$��Center=�$��Center=��� $��2��$��Offline��
�������$��Center=�$��Center=��� $��0�����#03A9F4$��10��$��10��$��10 10 10 10q�$
��Left=��� $��1�����#FB8C00$��10��$��10��$��10 10 10 10q�$
��Left=��� $��2�����#BDBDBD$��10��$��10��$��10 10 10 10q�$
��Left=��� $��4��$	��100��$	��100��$��Right=�.+��� ._�� .+�%  Microsoft.Expression.Shapes.Arc  -   *  Name$
* Arc1��+   ArcThickness$+ 2Q�$��Right=�$	��Top=����#BDBDBD$��50��$��50��,   
StartAngle$, 0Q�-   EndAngle$- 90Q�.   ArcThicknessUnit$. Pixel=�z��� / �� CenterX$/ 0Q�0 �� CenterY$0 50Q�1 �� Angle$
1 -360Q� :� $ Loaded��.[��� .���� .��W� $6 0(ed:Arc.RenderTransform).(RotateTransform.Angle)�$ 0X�$ 0:0:0D�:� $ Unloaded��.[��� .���� .��W� $6 0(ed:Arc.RenderTransform).(RotateTransform.Angle)�2 W� From$2 0X�$	 360X�$ 0:0:0D�  -   $
* Arc2��$+ 2Q�$��Right=�$	��Top=����#BDBDBD$��50��$��50��$, 0Q�$- 90Q�$. Pixel=�z��� $/ 0Q�$0 50Q�$	1 180Q� :� $ Loaded��.[��� .���� .��W� $6 0(ed:Arc.RenderTransform).(RotateTransform.Angle)�$
 -180X�$ 0:0:0D�:� $ Unloaded��.[��� .���� .��W� $6 0(ed:Arc.RenderTransform).(RotateTransform.Angle)�$2 0X�$	 180X�$ 0:0:0D�  -   $
* Arc3��$+ 2Q�$��Right=�$	��Top=����#BDBDBD$��50��$��50��$, 0Q�$- 90Q�$. Pixel=�z��� $/ 0Q�$0 50Q�$1 45Q� :� $ Loaded��.[��� .���� .��W� $6 0(ed:Arc.RenderTransform).(RotateTransform.Angle)�$
 -315X�$ 0:0:0D�:� $ Unloaded��.[��� .���� .��W� $6 0(ed:Arc.RenderTransform).(RotateTransform.Angle)�$2 0X�$ 45X�$ 0:0:0D�  -   $
* Arc4��$+ 2Q�$��Right=�$	��Top=����#BDBDBD$��50��$��50��$, 0Q�$- 90Q�$. Pixel=�z��� $/ 0Q�$0 50Q�$	1 -90Q� :� $ Loaded��.[��� .���� .��W� $6 0(ed:Arc.RenderTransform).(RotateTransform.Angle)�$	 -90X�$ 0:0:0D�:� $ Unloaded��.[��� .���� .��W� $6 0(ed:Arc.RenderTransform).(RotateTransform.Angle)�$2 0X�$	 -90X�$ 0:0:0D�  -   $
* Arc5��$+ 2Q�$��Right=�$	��Top=����#BDBDBD$��50��$��50��$, 0Q�$- 90Q�$. Pixel=�z��� $/ 0Q�$0 50Q�$
1 -270Q� :� $ Loaded��.[��� .���� .��W� $6 0(ed:Arc.RenderTransform).(RotateTransform.Angle)�$ 90X�$ 0:0:0D�:� $ Unloaded��.[��� .���� .��W� $6 0(ed:Arc.RenderTransform).(RotateTransform.Angle)�$2 0X�$	 270X�$ 0:0:0D�(� $	��100��$	��100��.���� $��Status��$��0 0 0 0q�$��5(�
�������