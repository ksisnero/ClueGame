   M S B A M L   `   `   `  ���� C  ?GetAClue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:GetAClue.ViewModelsGetAClue.ViewModels      GetAClue.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ] YDevExpress.Mvvm.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   4
viewModels!clr-namespace:GetAClue.ViewModels     � Title$  
MainWindow�� � WindowStyle$ SingleBorderWindow=�$
��1070��$	��824�� � DataContext 1  +DevExpress.Mvvm.UI.ViewModelSourceExtension     Type'   !GetAClue.ViewModels.MainViewModel"   � 	Resources    	BoolToVis��%   &	        �� .��� .+�� -   $��Guesses�����	#FFF1F1F1$	��420��$
��Left=� � RowDefinitions �� $	��20* ��� $	��60* ��� $	��40* ��� $
��450* ��� $
��198* � � ColumnDefinitions �� $	��160 ��� $	��130 ��� $	��130 ��� $��0* �.+��� -    ��Name$ GuessesLabel��$��GUESSES:��
���   �$��Tw Cen MT Condensed)�$��24(� �� TextAlignment$ Center=�$��Center=�$��3��$
��0,18q�$��1��$��26���� -   $ Counter��$
��Wrap=�
���   �$��Tw Cen MT Condensed)�$��22(�$ Center=�$��Right=�$��Center=�$��45��$��24��$��1��$��1��$��0q����� *CounterTextbox+�� -   $ RoomCategory��$
��Wrap=�
���   �$��	Tw Cen MT)�$��16(�$ Center=�$��0q�$��3��$��2������ *RoomTextbox+�� -   $ WeaponCategory��$
��Wrap=�
���   �$��	Tw Cen MT)�$��16(�$ Center=�$��1��$��0q�$��3������ *WeaponTextbox+�� -   $ SuspectCategory��
���   �$��	Tw Cen MT)�$��16(�$ Center=�$��0q�$��3������ *SuspectTextbox+�� -   $ Suspect��$
��Wrap=�$��Suspect��$ Center=�$��	0,11,0,12q�$��2��$��0��$��Center=�$��14(�$��18���� -   $ Weapon��$
��Wrap=�$��Weapon��$ Center=�$��	0,11,0,12q�$��2��$��1��$��14(�$��Center=�$��18���� -	   $
 Room��$
��Wrap=�$
��Room��$��Center=�$ Center=�$��	0,11,0,12q�$��2��$��2��$��14(�$��18��� -
   	 �Name$	 
RoomOption��y��� *ChooseRoomOptionVisible+
 �� 	Converter#
 [   �� FallbackValue$ 	Collapsed�� �� UpdateSourceTrigger$ PropertyChanged=� �� $
��425* ��� $
��637* � �� $	��90* ��� $
��475* ��� $	��92* �.+��� -    ��Name$ 	RoomImage��$!��Images/RoomTransparency.png��$
��Fill=�$��Center=�$��Center=�$	��460��$	��492��$��1��$��0q�$��1���� -   $ InstructionsForRoom��$
��Wrap=�$��CHOOSE A ROOM��$��Center=�$��50��$��48(�$��	Tw Cen MT)�$ Center=�$��1��
���   �$��0q�$��2��	� -    	�Name$ Lounge��$
��Left=�$��185,471,0,0q�$	��Top=�$��35��$��1��$��1�� d� 	IsChecked �� *LoungeRadioButton+	� -   $ Study��$
��Left=�$��415,469,0,0q�$	��Top=�$��35��$��1��$��1�� �� *StudyRadioButton+	� -   $
 Hall��$
��Left=�$��300,331,0,0q�$	��Top=�$��35��$��1��$��1�� �� *HallRadioButton+	� -   $ Library��$
��Left=�$��455,324,0,0q�$	��Top=�$��25��$��1��$��1�� �� *LibraryRadioButton+	� -   $ 
DiningRoom��$
��Left=�$��160,281,0,0q�$	��Top=�$��30��$��1��$��1�� �� *DiningRoomRadioButton+	� -   $ Kitchen��$
��Left=�$��167,189,0,0q�$	��Top=�$��28��$��1��$��1�� �� *KitchenRadioButton+	� -   $ Ballroom��$
��Left=�$��295,139,0,0q�$	��Top=�$��25��$��1��$��1�� �� *BallroomRadioButton+	� -   $ Conservatory��$
��Left=�$��425,169,0,0q�$	��Top=�$��25��$��1��$��1�� �� *ConservatoryRadioButton+	� -   $ BilliardRoom��$
��Left=�$��397,246,0,0q�$	��Top=�$��28��$��1��$��1�� �� *BilliardRoomRadioButton+� -   $	 WeaponOption��$��Right=�$	��638��y��� *ChooseWeaponOptionVisible+#
 [  $ 	Collapsed��$ PropertyChanged=� �� $
��155* ��� $
��310* ��� $
��192* � �� $	��26* ��� $
��135* ��� $
��130* ��� $
��115* ��� $
��120* ��� $
��112* ��� $��0* �.+��� -   $ Weapons��$"��Images/transparentWeapon.png��$��6��$��3��$	��637��$��Right=��� -   $ InstructionsForWeapons��$
��Wrap=�$��CHOOSE A WEAPON��$��48(�$��	Tw Cen MT)�$ Center=�
���   �$��1��$��Bottom=�$��54��$��5��	� -   $ Candlestick��$��CANDLESTICK��$	��Top=�$��24(�$��Tw Cen MT Condensed)�$��33��
���   �$��1��$��2��$��0q� �� *CandlestickRadioButton+	� -   $ Revolver��$��REVOLVER��$	��Top=�$��24(�$��Tw Cen MT Condensed)�$��33��
���   �$��2��$��2��$��0q� �� *RevolverRadioButton+	� -   $ Knife��$��KNIFE��$	��Top=�$��24(�$��Tw Cen MT Condensed)�$��33��
���   �$��3��$��2��$��0q� �� *KnifeRadioButton+	� -   $ LeadPipe��$��	LEAD PIPE��$	��Top=�$��24(�$��Tw Cen MT Condensed)�$��32��
���   �$��4��$��2��$��0q� �� *LeadPipeRadioButton+	� -   $ Wrench��$��WRENCH��$	��Top=�$��24(�$��Tw Cen MT Condensed)�$��31��
���   �$��5��$��2��$��0q� �� *WrenchRadioButton+� -   $	 OptionsButtons��$��Bottom=�$��64�����	#FFC5BCBC �� $	��150 ��� �� $��85 ��� $��85 ��� $��85 ��� $	��172 � �� $��0* ��� $	��63* �.+��� -    ��Name$ 
NextButton��$
��BACK��
�������$��Tw Cen MT Condensed)�$��18(�$��3��$��1��$��Center=�$��Center=�$��	8,19,7,19q�$��26��$��70��{��� *BackButtonEnabled+���� *BackCommand+�� -    $ 
BackButton��$
��NEXT��
�������$��Tw Cen MT Condensed)�$��18(�$��1��$��4��$��Center=�$��Center=�$��	3,19,2,19q�$��26��$��70��{��� *NextButtonEnabled+���� *NextCommand+�� -!   $ EnterButton��$��ENTER��
�������$��Tw Cen MT Condensed)�$��18(�$��5��$��1��$��Center=�$��36,19q�$��26��{��� *EnterButtonEnabler+���� *EnterButtonCommand+�� -"   $ StartButton��$��START NEW GAME��
�������$��Tw Cen MT Condensed)�$��18(�$��1��$��0��$��Center=�$��Center=�$��18,19q�$��26��$	��114��{��� *StartButtonEnabler+���� *StartGameCommand+� -#   $	 SuspectsOption��$	��642��$��Right=�y��� *ChooseSuspectOptionVisible+#
 [  $ 	Collapsed��$ PropertyChanged=� �� $
��155* ��� $
��320* ��� $
��180* ��� $��2* � �� �� $
��110* ��� $
��125* ��� $
��105* ��� $	��95* ��� $	��95* ��� $
��112* �.+��� -$   $ Suspects��$$��Images/SuspectsTransparent.png��$��1��$��7��$��
-19,0,20,0q��� -%   $ InstructionsForSuspects��$
��Wrap=�$��CHOOSE A SUSPECT��$	��Top=�$��81��$��48(�$��	Tw Cen MT)�$ Center=�
���   �$��1��$��1��$��6��	� -&   $ ColonelMustard��$��COLONEL 
MUSTARD��$��24(�$��Tw Cen MT Condensed)�$��Center=�$	��Top=�
���   �$��1��$��2��$��58��$��86��$��15,0,9,0q� �� *ColonelMustardRadioButton+	� -'   $ MrGreen��$��
MR. 
GREEN��$��24(�$��Tw Cen MT Condensed)�$��Center=�$	��Top=�
���   �$��2��$��2��$��58��$��74��$��	31,0,20,0q� �� *MrGreenRadioButton+	� -(   $ ProfessorPlum��$��PROFESSOR 
PLUM��$��24(�$��Tw Cen MT Condensed)�$��Center=�$	��Top=�
���   �$	��100��$��3��$��2��$��58��$��4,0,1,0q� �� *ProfessorPlumRadioButton+	� -)   $ MissScarlet��$��MISS 
SCARLET��$��24(�$��Tw Cen MT Condensed)�$��Center=�$	��Top=�
���   �$��4��$��2��$��58��$��96��$��2��$��9,0,85,0q� �� *MissScarletRadioButton+	� -*   $ 
MrsPeacock��$��MRS. 
PEACOCK��$��24(�$��Tw Cen MT Condensed)�$��Center=�$	��Top=�
���   �$��5��$��2��$��58��$��94��$��2��$��	6,0,107,0q� �� *MrsPeacockRadioButton+	� -+   $ MrsWhite��$��MRS. 
WHITE��$��24(�$��Tw Cen MT Condensed)�$��Center=�$	��Top=�
���   �$��6��$��2��$��58��$��80��$
��16,0q� �� *MrsWhiteRadioButton+� -,   $	 GameOver��$��1��$��2��.+��� --   $ YouWin��$��YOU WIN!��$��48(�$��	Tw Cen MT)�$ Center=�$
��Left=�$��480,295,0,0q�$
��Wrap=�$	��Top=�$��65��$	��525��y��� *YouWinVisible+#
 [  $ 	Collapsed��$ PropertyChanged=��� -.   $ YouLose��$��	YOU LOSE!��$��48(�$��	Tw Cen MT)�$ Center=�$
��Left=�$��480,295,0,0q�$
��Wrap=�$	��Top=�$��65��$	��525��y��� *YouLoseVisible+#
 [  $ 	Collapsed��$ PropertyChanged=�