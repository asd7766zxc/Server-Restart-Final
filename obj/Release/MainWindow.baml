   M S B A M L   `   `   `  ���� O  KServer Restart Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Server_Restart_FinalServer_Restart_Final  %    Server_Restart_Final.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:Server_Restart_Final     -     �Name$
  Main�� � WindowStyle$
 None=�$��0 0 0 0q� � AllowsTransparency . 
������  � SizeToContent$ WidthAndHeight=� � Title$ Server Restart�� � 	Resources    BackgroundTransparency  BackgroundTransparencyBrush �� Color  ForegroundLight  ForegroundLightBrush  ForegroundMain  ForegroundMainBrush  BackgroundVeryLight  BackgroundVeryLightBrush  LatoThin 	 LatoRegular 
 LatoBold  	LatoHeavy  FontAwesome  	BaseStyle �� 
TargetType  WindowControlButton �� BasedOn'  !System.Windows.Shell.WindowChrome	 �� Property
 �� Value �� ScaleX �� 
TargetType �� Padding �� Triggers P� Property P� Value  	Hoverless  WindowCloseButton%   Server_Restart_Final.MainWindow �� FallbackValue ��Name �� CornerRadius J� Effect-  'System.Windows.Media.Effects.BlurEffect   Radius3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Opacity � RowDefinitions K� ZIndex � ColumnDefinitions   IsHitTestVisibleInChrome �� Orientation  FocusVisual J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ControlListbtn ��Name  �� Triggers! �� 
TargetName��%C  &	        &	      7   &	      &	 .     7  &	 8     &	 I     7  &	 S     &	 d     7  &	 n     &		 �     &	
 �     &	     &	 2    &	 l    &	 q    7  7  7  &	 �    &	 Z    7  7  '  �    7  7  7  7  7  7  7  7  7  7  7  &	 �    &	     &	 *    &	 ?    &	 T    &	 i    &	 ~    &	 �    &	 �    &	 �    &	 �    7  7  7  7  7  7  7  7  7  7  ��	#0DB2EBF2���� 8   ��#ffffff���� 8   ��#686868���� 8   ��#fafafa���� 8   *�*&pack://appliction;,,,/Fonts/#Lato Thin)�*�-)pack://appliction;,,,/Fonts/#Lato Regular)�*�*&pack://appliction;,,,/Fonts/#Lato Bold)�*�+'pack://appliction;,,,/Fonts/#Lato Heavy)�*�40pack://appliction;,,,/Fonts/#fontawesome-webfont)��� �� " ��8   .���  	 �@ IsHitTestVisibleInChrome
 . �� 	 � ��

 ���� �� 	 � ��$
 8q��� 	 � ��$
 Stretch=��� 	 � ��8
  �� 	 �@�LayoutTransform
 �� $	 1.5Q��� 	 � ��
 �� " ��.R��� # z��#��z��._��� $��Center=�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� 	 � ��8
  �� " ��.��� 	 � ��

 ���� �� 	 � ��$
 0q��� 	 � ��
 �� " ��.R��� # z��#��z��._��� $��Center=�$��Center=��� " ��8    P�  �@J�IsMouseOver . . ��� 	 � ��

 �  ���� 	 � ��8
  �� "  .��� 	 � ��
 �� " �.R���  �� *OuterMarginSizeThickness+$ 10��._�� .+��� $ 	Container��
������  �� *WindowCornerRadius+�� 
������ $��1q����	#0D1E1E1E   $ 1Q���  �� *WindowCornerRadius+���� *ForegroundLightBrush+$ #��   $ 1Q�$	 0.2Q��  �� ���� *TitleHeightGridLenght+$ 32���� $��2 ��� $
��Auto ��� $��* �.+�� $��1��$��1�����#03A9F4� ���	#CC282828$��0��$ 1�� �� $
��Auto ��� $��* ��� $
��Auto �.+��� 8��   . $��2��$��	0,0,632,0q����� *MenuCommand+(� $��0��$��1��$��2q�.���� .+��� 8�� $
��1000(�$��0,0,0,-5q��� $�Server��8��  �� $�Restart��8��  �� $�Beta TS Dev��8�� �� $��2��$ 
Horizontal=�.+��� 8�� 8�� $��_������ *MinimizeCommand+�� 8�� 8�� $	��[ ]������ *MaximizeCommand+�� 8��	 8��
 $��X������ *CloseCommand+�� $��2�� �� *InnerContentPadding+._��� #��z���� .��� 	 � ��
 �� .R��� $��2q� . #��� ��$��1��$	 1 2R��� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#AA121212���� $ 	#AA3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.��� 	 �@�FocusVisualStyle8
   �� 	 � ��8
  �� 	 � ��8
  �� 	 � ��#
 � ���� 	 � ��$
 1q��� 	 � ��$
 Center=��� 	 � ��$
 Center=��� 	 � ��$
 1q��� 	 � ��
 �� " ��.R��� $ border��#��z��#��z��#��z�� . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z��  P�  �@��IsDefaulted . . ��� $! border��#
 � ��	 � ��P�  �@J�IsMouseOver . . ��� $! border��8
  	 � ���� $! border��8
  	 � ��P�  � �� . . ��� $! border��8
  	 � ���� $! border��8
  	 � ��P�  � {� .  . ��� $! border��8
  	 � ���� $! border��8
  	 � ���� $! contentPresenter��8
 	 	 � ��"   WindowChrome"   #   CornerRadius$# 0��$   GlassFrameThickness$$ 0q�%   ResizeBorderThickness% �� *ResizeBorderThickness+&   CaptionHeight& �� *TitleHeight+.���� $
��Auto��$
��Auto��._�� $��Stretch=�$��Stretch=� �� $��25 ��� $
��Auto �.+�� -   $��MainGrid��$��1��$��Stretch=�$��Stretch=� �� $
��Auto ��� $
��Auto � �� $
��Auto ��� $��* ����� ' j� ViewportUnits$' Absolute=�( j� Viewport$( 0 0 2948 1197�) �� ImageSource$9) 3/Background/Material-Backgrounds-07-2048-x-1197.png��.+� � -   $��	MainFrame��$��1��$��10 0 10 300q�$��Stretch=�$��Stretch=�$
��Auto��$
��Auto��*  � NavigationUIVisibility$* Hidden=����� *CurrentPage++ �� 	Converter+ 8   2Server_Restart_Final.ApplicationPageValueConverter  *   $Server_Restart_Final.SideMenuControl  -   ,  Name$, SideMenu��$��0��$��0��$��	0 300 0 0q�$��Center=�.��*   $Server_Restart_Final.SideListControl   � -   $��LoadingFrame��$��0q�$��Stretch=�$��Stretch=�$
��Auto��$
��Auto��$* Hidden=�.   (Server_Restart_Final.LeftSideMenuControl  $��1��$	��220��$��Right=�$��	0 0 0 120q�-	   'Server_Restart_Final.TopMenuListControl	  