   M S B A M L   `   `   `  ����C  ?GetAClue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:GetAClue.ViewModelsGetAClue.ViewModels  5   	       GetAClue.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ] YDevExpress.Mvvm.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   5   	   4
viewModels!clr-namespace:GetAClue.ViewModels   5   	     � Title$  
MainWindow��5	   	   $	��800��6   $
��1100��6)    � 
ResizeMode$ NoResize=�6�    � DataContext 66   1  +DevExpress.Mvvm.UI.ViewModelSourceExtension     Type'   !GetAClue.ViewModels.MainViewModel"   � 	Resources 5         	BoolToVis��%   &	        �� 5   
   6'   5      .��5      � .+�5   
   � -   5         �Name$ 	Framework��5      
�������.+�5      �� ���	#FFEAC67A$
��Left=�6)   $	��770��6D   $	��Top=�6Q   $	��415��6i   �� 5      ���	#FF552727$
��Left=�6)   $	��105��6D   $	��Top=�6Q   $
��1095��6i   $��
0,665,-1,0q�6v   �� 5      -   5         ��Name$ Start��5      $��START NEW GAME��6$   $��887,702,51,33q�5      $��Tw Cen MT Condensed)�6C   $��18(�6d   ���	#FF0A1612��5   =   �� *StartGameCommand+��5   ,   Z�  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5      -   5        $ 
RoomButton��5      $
��ROOM��6)   $��641,702,366,33q�6`   $��Tw Cen MT Condensed)�5   ,   $��18(�6M   ���	#FF040000
�������{�5   8   �� *RoomButtonEnabler+��5      Z� ��5   ,   �� *EnableRoomCommand+5       �� 5!      -   5        $ WeaponButton��5!      $��WEAPON��6+   
�������$��551,702,456,33q�5"      $��Tw Cen MT Condensed)�6D   $��18(�6e   {�5!   <   �� *WeaponButtonEnabler+��5"   -   Z� ��5#      �� *EnableWeaponCommand+5$      �� 5%      -   5        $ SuspectButton��5%      $��SUSPECT��6,   
�������$��461,702,546,33q�5&   (   
�������$��Tw Cen MT Condensed)�6T   $��18(�5'      {�5%   >   �� *SuspectButtonEnabler+��5'   #   �� *EnableSuspectCommand+5(      �� 5)      -   5        $ EnterButton��5)      $��ENTER��6*   
�������$��731,702,276,33q�5*      $��Tw Cen MT Condensed)�6D   $��18(�6e   
���   �{�5)   :   �� *EnterButtonEnabler+��5*   -   Z� ��5+   (   �� *EnterButtonCommand+5,      �� 5-      -   5         ��Name$ GuessesLabel��5-      $
��Left=�6,   $��40��6G   $��	20,40,0,0q�6S   	 �� TextWrapping$
	 Wrap=�5.      $��GUESSES:��6*   $	��Top=�6:   $	��375��6R   
���   �$��Tw Cen MT Condensed)�5/   @   $��24(�6a   
 �� TextAlignment$
 Center=�50      ��5.   ^   Z� ��5/      Z� 50      �� 51      -   5         ��Name$ Counter��51      $
��Left=�6)   $��
248,40,0,0q�6D   $
��Wrap=�6X   $	��Top=�52   G   $��35��6_   $��44��6k    �� TextAlignment$ Center=�6v   
�������$��22(�53   +   ��52      �� *CounterDisplay.DisplayCounter+53   +   �� 54      -	   5         ��Name$ GuessCategories��54      $B��<        Room: 	       Weapon: 	                    Suspect: ��6-   $
��Left=�6|   $��
20,106,0,0q�6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.536,-0.227&�6�   $	��375��6�   
���   �$��24��6  �� 55      -
   5        $ RoomCategory��55      $
��Left=�56      $��
20,132,0,0q�63   $
��Wrap=�6G   $	��Top=�6[   $��16(�57      $��95��6&   $	��433��61   $ Center=�58      $��0��6/   $��	Tw Cen MT)�6?   
���   ���55   .   �� *GuessDisplay.RoomTextbox+58   V   �� 59      -   5        $ WeaponCategory��59      $
��Left=�5:      $��115,132,0,0q�6,   $
��Wrap=�6A   $	��Top=�6U   $��16(�5;      $��95��6   $	��433��6*   $ Center=�5<      $��0��6(   $��	Tw Cen MT)�68   
���   ���59   0   �� *GuessDisplay.WeaponTextbox+5<   O   �� 5=      -   5        $ SuspectCategory��5=      $
��Left=�5>      $��210,132,0,0q�6,   $
��Wrap=�6A   $	��Top=�6U   $��16(�5?      $	��185��6   $	��433��6+   $ Center=�5@      $��0��6(   $��	Tw Cen MT)�68   
���   ���5?   8   �� *GuessDisplay.SuspectTextbox+5@   O   �� 5A      -   5         ��Name$ TransparentClueLogo��5A      $��19,578,715,6q�61   $$��Images/TransparentClueLogo.png��6G   $
��Fill=�6o   5C      � 5E   
   -   5        $ Instructions��5E      y�5F      �� *InstructionOption+ �� 	Converter# [   �� FallbackValue$ visible�� �� UpdateSourceTrigger$ PropertyChanged=�.+�5G      �� -   5        $ InstructionTextBlock��5G      $
��Left=�66   $��565,240,0,0q�6Q   $
��Wrap=�6f   $	��Top=�6z   $	��235��6�   $	��375��6�   $��16(�6�   �� 6�   $�Instructions: ��6�   �� 6�   �� 6�   �� 6�   �� 6�   $;�5You're trying to discover the murderer of Mr. Boddy. ��6�   �� 67  �� 6C  �� 6I  �� 6U  $���To win, you must guess correctly the room, weapon, and suspect. When you guess an option correctly, an '*' will replace your guesses. If you guess that option incorrectly, your incorrect guess will come after the '*'. Let's hope you have a good memory.��6Y  �� 6_  �� 6k  �� 6q  �� 6}  $*�$You only have 10 guesses, good luck.��6�  6�  5H      � 5J   
   -   5        $ 
RoomOption��5J      $��	3,0,536,0q�6#   y�5K      �� *
RoomOption+# [  $ 	Collapsed��$ PropertyChanged=�.+�5L      �� -   5        $
 Room��5L      $��485,119,-440,124q�6"   $!��Images/RoomTransparency.png��6<   $
��Fill=�6a   �� 5N      -   5        $ InstructionsForRoom��5N      $
��Left=�65   $��488,49,-438,0q�6P   $
��Wrap=�5O      $��CHOOSE A ROOM��6,   $	��Top=�6A   $��50��6Y   $	��505��6e   $��48(�5P      $��	Tw Cen MT)�6&   $ Center=�6=   $��0��6T   
���   �6d   	� 5R      -   5         	�Name$ Lounge��5R      $
��Left=�6R   $��597,578,-77,0q�5S      $	��Top=�61   $��35��6I    d� 	IsChecked 5R   *   �� *LoungeRadioButton+5S   I   	� 5T      -   5        $ Study��5T      $
��Left=�6P   $��844,573,-324,0q�5U      $	��Top=�62   $��35��6J    5T   )   �� *StudyRadioButton+5U   J   	� 5V      -   5        $
 Hall��5V      $
��Left=�6N   $��683,410,-163,0q�5W      $	��Top=�62   $ 0.556,0.452&�6J   $��35��6n    5V   (   �� *HallRadioButton+5W   n   	� 5X      -   5        $ Library��5X      $
��Left=�6T   $��885,423,-355,0q�5Y      $	��Top=�62   $��25��6J    5X   +   �� *LibraryRadioButton+5Y   J   	� 5Z      -   5        $ 
DiningRoom��5Z      $
��Left=�6Z   $��523,423,0,0q�5[      $	��Top=�6/   $ 1.156,-2.69&�6G   $��30��6k    5Z   .   �� *DiningRoomRadioButton+5[   k   	� 5\      -   5        $ Kitchen��5\      $
��Left=�6T   $��568,275,-41,0q�5]      $	��Top=�61   $ 2.133,-1.81&�6I   $��28��6m    5\   +   �� *KitchenRadioButton+5]   m   	� 5^      -   5        $ Ballroom��5^      $
��Left=�6V   $��716,223,-186,0q�5_      $	��Top=�62   $ 5.356,-0.452&�6J   $��25��5`       5^   ,   �� *BallroomRadioButton+5`      	� 5a      -   5        $ Conservatory��5a      $
��Left=�6^   $��848,257,-318,0q�5b      $	��Top=�62   $ 1.389,0.591&�6J   $��25��6n    5a   0   �� *ConservatoryRadioButton+5b   n   	� 5c      -   5        $ BilliardRoom��5c      $
��Left=�6^   $��826,340,-299,0q�5d      $	��Top=�62   $ 5.333,-7.976&�6J   $��28��5e       5c   0   �� *BilliardRoomRadioButton+5e      5f      � 5h   
   -   5        $ WeaponOption��5h      y�5i      �� *WeaponOption+# [  $ 	Collapsed��$ PropertyChanged=�.+�5j      �� -   5        $ Weapons��5j      $��431,264,37,264q�6%   $"��Images/transparentWeapon.png��6=   $
��Fill=�6c   �� 5k      -   5        $ InstructionsForWeapons��5k      $
��Left=�68   $��428,164,0,0q�6S   $
��Wrap=�5l      $��CHOOSE A WEAPON��6,   $	��Top=�6C   $��81��6[   $	��628��6g   $��48(�5m      $��	Tw Cen MT)�6&   $ Center=�6=   
���   �6T   	� 5o      -   5        $ Candlestick��5o      $��CANDLESTICK��6\   $
��Left=�5p      $��457,506,0,0q�65   $	��Top=�6J   $��24(�6b   $��Tw Cen MT Condensed)�5q      $��33��6;   
���   � 5o   /   �� *CandlestickRadioButton+5q   G   	� 5r      -    5        $ Revolver��5r      $��REVOLVER��6V   $
��Left=�5s      $��598,506,0,0q�65   $	��Top=�6J   $��24(�6b   $��Tw Cen MT Condensed)�5t      $��33��6;   
���   � 5r   ,   �� *RevolverRadioButton+5t   G   	� 5u      -!   5        $ Knife��5u      $��KNIFE��6P   $
��Left=�5v      $��715,506,0,0q�65   $	��Top=�6J   $��24(�6b   $��Tw Cen MT Condensed)�5w      $��33��6;   
���   � 5u   )   �� *KnifeRadioButton+5w   G   	� 5x      -"   5        $ LeadPipe��5x      $��	LEAD PIPE��6V   $
��Left=�5y      $��812,506,0,0q�65   $	��Top=�6J   $��24(�6b   $��Tw Cen MT Condensed)�5z      $��32��6;   
���   � 5x   ,   �� *LeadPipeRadioButton+5z   G   	� 5{      -#   5        $ Wrench��5{      $��WRENCH��6R   $
��Left=�5|      $��930,506,0,0q�65   $	��Top=�6J   $��24(�6b   $��Tw Cen MT Condensed)�5}      $��31��6;   
���   �$��84��6Z    5{   *   �� *WrenchRadioButton+5}   Z   5~      � 5�   
   -$   5        $ SuspectsOption��5�      y�5�      �� *SuspectOption+# [  $ 	Collapsed��$ PropertyChanged=�.+�5�      �� -%   5        $ Suspects��5�      $��410,250,14,261q�6&   $$��Images/SuspectsTransparent.png��6>   $
��Fill=�6f   �� 5�      -&   5        $ InstructionsForSuspects��5�      $
��Left=�69   $��415,164,0,0q�6T   $
��Wrap=�5�      $��CHOOSE A SUSPECT��6,   $	��Top=�6D   $��81��6\   $	��665��6h   $��48(�5�      $��	Tw Cen MT)�6&   $ Center=�6=   
���   �6T   	� 5�      -'   5        $ ColonelMustard��5�      $��COLONEL 
MUSTARD��5�      $��24(�69   $��Tw Cen MT Condensed)�6G   $
��Left=�5�      $��464,513,0,0q�65   $	��Top=�6J   
���   � 5�   2   �� *ColonelMustardRadioButton+5�   b   	� 5�      -(   5        $ MrGreen��5�      $��
MR. 
GREEN��6T   $��24(�5�      $��Tw Cen MT Condensed)�6(   $
��Left=�6I   $��584,514,0,0q�6d   $	��Top=�5�      
���   � 5�   +   �� *MrGreenRadioButton+5�   2   	� 5�      -)   5        $ ProfessorPlum��5�      $��PROFESSOR 
PLUM��5�      $��24(�68   $��Tw Cen MT Condensed)�6F   $
��Left=�5�      $��674,514,0,0q�65   $	��Top=�6J   
���   �$	��100��5�       5�   1   �� *ProfessorPlumRadioButton+5�      	� 5�      -*   5        $ MissScarlet��5�      $��MISS 
SCARLET��5�      $��24(�66   $��Tw Cen MT Condensed)�6D   $
��Left=�5�      $��786,514,0,0q�65   $	��Top=�6J   
���   � 5�   /   �� *MissScarletRadioButton+5�   b   	� 5�      -+   5        $ 
MrsPeacock��5�      $��MRS. 
PEACOCK��5�      $��24(�66   $��Tw Cen MT Condensed)�6D   $
��Left=�5�      $��874,514,0,0q�65   $	��Top=�6J   
���   � 5�   .   �� *MrsPeacockRadioButton+5�   b   	� 5�      -,   5        $ MrsWhite��5�      $��MRS. 
WHITE��6V   $��24(�5�      $��Tw Cen MT Condensed)�6(   $
��Left=�6I   $��968,514,0,0q�6d   $	��Top=�5�      
���   � 5�   ,   �� *MrsWhiteRadioButton+5�   2   5�      � 5�   
   --   5        $ GameOver��5�      .+�5�      �� -.   5        $ YouWin��5�      $��YOU WIN!��6(   $��48(�68   $��	Tw Cen MT)�6F   $ Center=�6]   $
��Left=�6t   $��480,295,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $��65��6�   $	��525��6�   y�5�      �� *YouWinVisibility+# [  $ 	Collapsed��$ PropertyChanged=��� 5�      -/   5        $ YouLose��5�      $��	YOU LOSE!��6)   $��48(�6:   $��	Tw Cen MT)�6H   $ Center=�6_   $
��Left=�6v   $��480,295,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $��65��6�   $	��525��6�   y�5�      �� *YouLoseVisibility+# [  $ 	Collapsed��$ PropertyChanged=�5�      5�      5�      