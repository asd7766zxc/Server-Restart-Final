   M S B A M L   `   `   `  ���� O  KServer Restart Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Server_Restart_FinalServer_Restart_Final  .    (Server_Restart_Final.LeftSideMenuControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:Server_Restart_Final       � 	Resources     FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray)   #Server_Restart_Final.ResizablePanel �� 
TargetType �� 
TargetType � DataContext �� RelativeSource	 � ColumnDefinitions
 � RowDefinitions"   Server_Restart_Final.Resizer � Cursor   ThumbDirection  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 SideMenuButton �� CenterX �� Angle ��Name ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%  &	        '  N     &	 `    &	 u    &	 �    &	 �    &	 �    &	 �    &	 �    &	 �    &		     &	
     7   7  7  7  7  7 	 �� .���  � �� �� .R��� $��2q� . #��� ��$��1��$	 1 2R��� "  .���  � �� �� "  .R��  ��  �� *TemplatedParent+	 �� $��5 ��� $��* ��� $��5 �
 �� $��5 ��� $��* ��� $��5 �.+�  $ SizeWE��
������ $��3��$��1��$��0��$
 Left=��� $��1��$��1��#��z��#��z���� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R�� z��� $ 25Q�$ 90Q�
 �� $
��1.3* ��� $��5* �.+��� $ border��
������ $��0q����#3F3F46 . ._��� $ contentPresenter��$y�Hidden=�|�.  #��z��#��z����. # z #��z���� $ ContentLabel��$��Center=�$��1��$��12(�$��2q����#B7B7B8#��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border�� � �� �#007ACC�� $ ContentLabel�� � �� �#007ACCP�  � �� . P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ��.��� $
��Auto��$
��Auto��	 �� $��* ��� $��25 �.+��� -    ��Name$ 
Maincanvas��$
��Auto��$
��Auto��.+�  $��0�� �� Left$ 0��
 �� Top$ 0��$��Stretch=�$��Stretch=����� *ActualHeight+ �� ElementName$ 
Maincanvas������ *ActualWidth+$ 
Maincanvas��.�� � -     �Name$ PageContent��$��0q�$��Stretch=�$��Stretch=�$
��Auto��$
��Auto��  � NavigationUIVisibility$ Hidden=�� $��1��$��25��$
��Auto��$��Right=����#2d2d30
 �� $	��105 ��� $	��110 ��� $��* �.+��� -   $��Solution Explorer��$��	0 -25 0 0q�#��� 
 $��25��$	��101���� -   $��1��$��Performance View��$��	0 -35 0 0q�#��� 
 $��25��$	��110��