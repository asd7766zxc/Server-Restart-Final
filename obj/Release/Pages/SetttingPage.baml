   M S B A M L   `   `   `  ���� O  KServer Restart Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Server_Restart_FinalServer_Restart_Final  '    !Server_Restart_Final.SetttingPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:Server_Restart_Final     -   $��	0 0 0 120q�  N� Title$  SetttingPage�� J� Effect -  'System.Windows.Media.Effects.BlurEffect  -   	BlurP��   Radius$ 0Q� � Triggers :�  :� RoutedEvent$ Loaded��.[��� .���� .��W�  �� 
TargetName$ BlurP�� �� TargetProperty$ Radius�	 W� To$ 0X� g� Duration$ 0:0:0.5D�:� $ Unloaded��.[��� .���� .��W� $ BlurP��$ Radius�$	 100X�$ 0:0:0.01D�	 � 	Resources	    FocusVisual
 �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  OutPutTextBoxStyle1 �� 
TargetType-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name ��Name3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Opacity �� Triggers P� Property P� Value �� 
TargetName	 �� To �� Triggers ]� 
Conditions �� Property �� Value  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border 	 Button.Pressed.Background 
 Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  OpenFileButton ��Name  ListBox.Static.Background  ListBox.Static.Border  ListBox.Disabled.Background  ListBox.Disabled.Border  ListBoxStyle1 �� Padding ! SliderThumb.Static.Foreground $  SliderThumb.MouseOver.Background   SliderThumb.MouseOver.Border " SliderThumb.Pressed.Background  SliderThumb.Pressed.Border # SliderThumb.Disabled.Background  SliderThumb.Disabled.Border ! SliderThumb.Static.Background  SliderThumb.Static.Border  SliderThumbHorizontalTop  � UseLayoutRounding! F�Name" �� Stretch  SliderThumbHorizontalBottom  SliderThumb.Track.Border    SliderThumb.Track.Background ! RepeatButtonTransparent  " SliderThumbHorizontalDefault # SliderHorizontal# � RowDefinitions$ m�Name% m� Fill& m� 	Placement' ��Name( ]�Name) ]� DecreaseRepeatButton* �� DecreaseLarge+ ]� IncreaseRepeatButton, �� IncreaseLarge- ]� Thumb. n�Name/ � OverridesDefaultStyle $ SliderThumbVerticalLeft % SliderThumbVerticalRight & SliderThumbVerticalDefault ' SliderVertical0 � ColumnDefinitions ( SliderStyle1 ) ReStartServerButton��%�(  &	        &	 N     &	 c     &	 x     &	 �     7  7  7  &	 �    &	 �    &	     &	     &		 -    &	
 B    &	 W    &	 l    &	 �    &	 �    7   7  7  7  7  7  &	 d    &	 y    &	 �    &	 �    &	 �    7  7  7  7  &	     &	 $    &	 9    &	 N    &	 a    &	 t    &	 �    &	 �    &	 �    &	 �    7  7  7  7  7  7  7  7  &	 �    7  7  7  7  7  7  7  7  &	 �    &	  �    &	!     &	" �    7  7  7  7  7  7  7  7  &	# �    7  7   7 ! 7 ! 7 " 7  7  &	$ �    7  7  7  7  7  7  7  7  &	% �    7  7  7  7  7  7  7  7  &	& v    7  7  7  7  7  7  7  7  &	'     7  7   7 ! 7 ! 7 & 7 $ 7 % &	( �!    7  7 # 7 ' &	) �"    7   7  7  7  7  7  �� .��� 
 � �� �� .R��� $��2q� . #��� ��$��1��$	 1 2R��� $ 	#FFABAdB3���� $ 	#FF7EB4EA���� $ 	#FF569DE5���� " ��.��� 
 � �� �	#0D555555�� 
 � ��8   �� 
 � ��# � ���� 
 � ��$ 1q��� 
 � ��$ 5q��� 
 �@ TabNavigation$
 None=��� 
 � ��$
 Left=��� 
 �@�FocusVisualStyle Z� �� 
 �@J�	AllowDrop . �� 
 �@��PanningMode$ VerticalFirst=��� 
 �@��IsFlicksEnabled .  �� 
 � �� �� " ��.R��� $ border�����	#FF000000$��1q����	#AA36393F . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=�   $ 5Q�$	 0.2Q� P�  � {� .  . ��� $ border��
 �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8  
 � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8  
 � ��:� $ 
MouseEnter��.[��� .���� .���� $ #121212X�$ 0:0:0.3D�$ border��$ Background.Color�:� $ 
MouseLeave��.[��� .���� .���� $ 	#AA36393FX�$ 0:0:0.3D�$ border��$ Background.Color� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./��� 
 �@��SelectionBrush# � /��� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.��� 
 �@�FocusVisualStyle8   �� 
 � ��8  �� 
 � ��8  �� 
 � ��# � ���� 
 � ��$ 1q��� 
 � ��$ Center=��� 
 � ��$ Center=��� 
 � ��$ 1q��� 
 � �� �� " ��.R��� $ border�����#6CB2EF$��0 0 0 0q����	#AA1E1E1E . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��
 � �� �#6CB2EFP�  �@J�IsMouseOver . . ��� $ border��
 � �� �	#AA101010P�  � �� . . ��� $ border��
 � �� �#0000P�  � {� .  . ��� $ border��8  
 � ���� $ border��8  
 � ���� $ contentPresenter��8  
 � ���� $ 	#AA36393F���� $ 	#FF000000���� $ 	#FFFFFFFF���� $ 	#FFD9D9D9���� " ��.��� 
 � ��8   �� 
 � ��8  �� 
 � ��$ 1q��� 
 � ��# � ���� 
 � ��$ Disabled=��� 
 � ��$ Disabled=��� 
 � �� . �� 
 �@��PanningMode$
 Both=��� 
 �@��IsFlicksEnabled .  �� 
 � ��$ Center=��� 
 � �� �� " ��.R��� $ Bd��#��z��#��z��#��z��$ 1q� . ._��� |�.  #��z��.���� # z    $ 5Q�$	 0.2Q� P�  � {� .  . ��� $ Bd��8  
 � ���� $ Bd��8  
 � ��]�  ��  �@��
IsGrouping . �� " �@%�IsVirtualizingWhenGrouping .  ./��� 
 � �� .  �� $ 	#AA36393F���� $ 	#FFDCECFC���� $ 	#FF7Eb4EA���� $ #6CB2EF���� $ #6CB2EF���� $ #6CB2EF���� $ #6CB2EF���� $ #6CB2EF���� $ #6CB2EF���� " n�.R�� $��Center=�  . $��Center=�.+�F� $
! grip�������    ��[ �    ��[ `�S `�S �`�S     �ا ��[ �ا ��[ ��ا ��[ �ا ���ا ����ا �������    ����[ ��[ 	8��  $
" Fill=� . 8�� $��1��  . $��Center=� P�  �@J�IsMouseOver . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  �@n�
IsDragging . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  � {� .  . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ���� " n�.R�� $��Center=�  . $��Center=�.+�F� $
! grip�������     � �     � `�S ��`�S ���`�S ���ا  � �ا  � ��ا  � �ا �ا ��ا     �         �  � 	8��  $
" Fill=� . 8�� $��1��  . $��Center=� P�  �@J�IsMouseOver . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  �@n�
IsDragging . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  � {� .  . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ���� $ 	#AA36393F���� $ 	#AA36393F���� " ��.��� 
 �@�OverridesDefaultStyle . �� 
 � ��
 ���� �� 
 � |� .  �� 
 � �� .  �� 
 � �� �� " ��.R��� #��z��#��z��#��z���� " n�.R�� $��Center=�  . $��Center=�.+�F� $
! grip��d����        �        �ا �ا ��ا     �ا ���ا ����ا �������    ��	8��  $
" Fill=� . 8�� $��1��  . $��Center=� P�  �@J�IsMouseOver . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  �@n�
IsDragging . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  � {� .  . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ���� " ��.R��� $ border��#��z��#��z��#��z�� . ._�� # �� $
��Auto ��� $
��Auto �#��z���� $
��Auto �.+�m� $$ TopTick��#% z��$��4��$��0,0,0,2q�$	& Top=�$��0��$y�	Collapsed=�m� $$ 
BottomTick��#% z��$��4��$��0,2,0,0q�$& Bottom=�$��2��$y�	Collapsed=��� $ TrackBackground��8��  $��1q�8�� $	��4.0��$	��5,0q�$��1��$��center=�._��� $��-6,-1q�.+��� $' PART_SelectionRange��#��� ��$	��4.0��$y�Hidden=�]� $( 
PART_Track��$��1��) �� #��Z* 8�� + �� #��Z, 8�� - n� $. Thumb��|�.  $��18��/ . 8�� $��Center=�$��11�� P�  �@��TickPlacement$ TopLeft=�. ��� $ TopTick��
 � y�$ Visible=��� $ Thumb��8  
 � ���� $ TrackBackground��
 � ��$ 5,2,5,0q�P�  �@��TickPlacement$ BottomRight=�. ��� $ 
BottomTick��
 � y�$ Visible=��� $ Thumb��8  
 � ���� $ TrackBackground��
 � ��$ 5,0,5,2q�P�  �@��TickPlacement$
 Both=�. ��� $ TopTick��
 � y�$ Visible=��� $ 
BottomTick��
 � y�$ Visible=�P�  �@��IsSelectionRangeEnabled . . ��� $ PART_SelectionRange��
 � y�$ Visible=�P�  �@J�IsKeyboardFocused . . ��� $ Thumb��
 � ��
 ��  ��� " n�.R�� $��Center=�  . $��Center=�.+�F� $
! grip���������[ �ا Ӏ�[ �ا `�S `�S �    `�S ��[ ��[ Ӏ�[     ����Ӏ�    ���ا ���ا Ӏ��ا ��[ �ا ��[ �ا 	8��  $
" Fill=�8��  P�  �@J�IsMouseOver . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  �@n�
IsDragging . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  � {� .  . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ���� " n�.R�� $��Center=�  . $��Center=�.+�F� $
! grip������� � �ا � � �ا ��`�S ��`�S Ӏ�`�S  �  � � �     �        �ا �ا �    �ا  � �ا  � �ا 	8��  $
" Fill=�8��  P�  �@J�IsMouseOver . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  �@n�
IsDragging . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  � {� .  . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ���� " n�.R�� $��Center=�  . $��Center=�.+�F� $
! grip��+���� �  � ѠI � ѠI�y� � � �y� 	8��  $
" Fill=�8��  P�  �@J�IsMouseOver . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  �@n�
IsDragging . . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ��P�  � {� .  . ��� $
 grip��8  
 � ���� $
 grip��8  
 � ���� " ��.R��� $ border��#��z��#��z��#��z�� . ._�� 0 �� $
��Auto ��� #��z��$
��Auto ��� $
��Auto �.+�m� $$ TopTick��$��0��#% z��$��0,0,2,0q�$
& Left=�$y�	Collapsed=�$��4��m� $$ 
BottomTick��$��2��#% z��$��2,0,0,0q�$& Right=�$y�	Collapsed=�$��4���� $ TrackBackground��8��  $��1q�8�� $��1��$��center=�$	��0,5q�$	��4.0��._��� $��-1,-6q�.+��� $' PART_SelectionRange��#��� ��$y�Hidden=�$	��4.0��]� $( 
PART_Track��$��1��) �� #��Z* 8�� + �� #��Z, 8�� - n� $. Thumb��|�.  $��11��/ . 8�� $	��Top=�$��18�� P�  �@��TickPlacement$ TopLeft=�. ��� $ TopTick��
 � y�$ Visible=��� $ Thumb��8  
 � ���� $ TrackBackground��
 � ��$ 2,5,0,5q�P�  �@��TickPlacement$ BottomRight=�. ��� $ 
BottomTick��
 � y�$ Visible=��� $ Thumb��8  
 � ���� $ TrackBackground��
 � ��$ 0,5,2,5q�P�  �@��TickPlacement$
 Both=�. ��� $ TopTick��
 � y�$ Visible=��� $ 
BottomTick��
 � y�$ Visible=�P�  �@��IsSelectionRangeEnabled . . ��� $ PART_SelectionRange��
 � y�$ Visible=�P�  �@J�IsKeyboardFocused . . ��� $ Thumb��
 � ��
 ��  ��� " ��.��� 
 �@��IsPressAndHoldEnabled .  �� 
 � ��
 ���� �� 
 � ��
 ���� �� 
 � ��8   �� 
 � ��8   P�  �@��Orientation$ Vertical=�. ��� 
 � ��8  �� " ��.��� 
 �@�FocusVisualStyle8   �� 
 � ��8  �� 
 � ��8  �� 
 � ��
 ������� 
 � ��$ 1q��� 
 � ��$ 1q��� 
 � ��$ Center=��� 
 � ��$ Center=��� 
 � ��$ 1q��� 
 � �� �� " ��.R��� $ border�����#80DEEA$��0 0 0 0q����	#AA232323 . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��# � ��
 � ��P�  �@J�IsMouseOver . . ��� $ border��
 � �� �	#0DD7CCC8�� $ border��
 � �� �#8BC34AP�  � �� . . ��� $ border��
 � �� �	#00000000�� $ border��
 � �� �	#00000000P�  � {� .  . ��� $ border��8  
 � ���� $ border��8  
 � ���� $ contentPresenter��8  
 � ��.��� $
��Auto��$
��Auto��$��20q����#00000 �� $��50 ��� $��* �.+��� ���	#AA1E1E1E$��0 0 1 0q����#6CB2EF._�� # �� $��50 ��� $��50 ��� $��* ��� $��* �.+��� -   1 ��Name$1 OpenFilePicker_Btn��#���  .���� $��10q�$&�� /Images/icons8-external-link.png���� -   $1 SaveFilePicker_Btn��$��1��#���  .���� $��10q�$)��#/Images/icons8-receive-file-100.png��� $��1��# �� $��* ��� $��* ��� $��* �.+��� $�� 10 10 10 10q�$��0��$��0 1 0 1q����	#AA1E1E1E._�� .+��� $��0��$��0 0 0 1q����#6CB2EF$	��Top=�$��Stored Data��$��17(�$��0 0 0 0q�$��Center=�
��������� -   2 ��Name$2 Settings��$��0��$��	20 0 20 0q�$��Center=�$�� ��
��������� $�� 10 10 10 10q�$��1��$��0 1 0 1q����	#AA1E1E1E._�� .+��� $��0��$��Data Buffer��$��0 0 0 1q����#6CB2EF$	��Top=�$��17(�$��0 0 0 0q�$��Center=�
��������� -   $2 	Settingsa��$��0��$��	20 0 20 0q�$��Center=�$�� ��
��������� $
��Auto��$��10 10 10 10q�$��2��$��0 1 0 1q����	#AA1E1E1E._�� $
��Auto��0 �� �� �� # �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+�� $��1��$��0��# �� $��* ��� $��* ��� $��* �.+��� -   3 ��Name$3 UserFroceCheck��$��0��$	��200��$��Center=�$��Center=�$!��使用者停滯自動掌管��
��������� -   4 ��Name$4 SQLServerLocation��$��1��
�������$	��200��$��Center=�$��Server Location��#���  �� -	   $4 ServerRestartTimes��$��2��
�������$	��200��$��Center=�$��Center=�$��Server Restart Times��#���  � $��1��$��1��# �� $��* ��� $��* ��� $��* ��� $��* �.+��� -
   5 ��Name$5 MemorySlider��$��3��
�������$	��200��$��30��$��Center=�$��Center=�#��� ( �� -   $4 	parameter��$��1��
�������$��30��$	��200��6 �� TextWrapping$
6 Wrap=�$��Center=�$��Center=�$��	Parameter��#���  �� -   $4 ValueSearch��$��2��
�������$��30��$	��100��$
6 Wrap=�$��10 0 0 0q�$��Center=�$
��Left=�$��	-Xmx4096M��#���  �� -   $4 ValueSearchMinimize��$��2��
�������$��30��$	��100��$
6 Wrap=�$��0 0 40 0q�$��Center=�$��Right=�$��	-Xms4096M��#���  �� $��1��$��	Edit Data��$��0 0 0 1q����#6CB2EF$	��Top=�$��17(�$��0 0 0 0q�$��Center=�
��������� -   7 ��Name$7 CommandEditList��$��2��$��1��
�������$	��200��$	��200��$	��Top=�$��Right=�#���  ���� .R�� $	��0,2q�0 �� $��* ��� $��30 �.+��� 
����������� *	command+�� 
�������$��1������ *commandindex+�� -   $4 CommandEdit��$��2��$��2��
�������$	��200��$��Center=�$��Right=�$��Command��#���  �� -   $4 CommandEditNum��$��2��$��2��
�������$��30��$��Center=�$��Right=�$��0��#���  �� -   $1 DelBtn��$��2��$��0��
�������$��50��$��50��$��Remove��$��Bottom=�$��Right=�#��� ) 