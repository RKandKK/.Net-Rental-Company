   M S B A M L   `   `   `  ���� D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  4    .AplikacjaDoZarzadzaniaWypozyczalnia.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  -     �Name$  MainWin�� � Title$ Rent-A-Wheel��$	��350��$	��600��$	��600��$	��350�� � 	Resources 8  2AplikacjaDoZarzadzaniaWypozyczalnia.WidthConverter   WidthConverter>  8AplikacjaDoZarzadzaniaWypozyczalnia.BoolToColorConverter  BoolToColorConverter��%   &	        &	          .��� -    �Name$
 Grid�� � ColumnDefinitions �� ���� *ActualWidth+ �� ConverterParameter$
 0,25�� �� 	Converter# [   �� ElementName$ MainWin�� �� Mode$ OneWay=��� ���� *ActualWidth+$
 0,75��# [  $ MainWin��$ OneWay=�.+��� $��0��$��2��.+�� $
��Left=�$	��315��$��10,0,0,0q�$	��116��	 J� RenderTransformOrigin$	 0.286,0.502&�.+��� -   
 ��Name$
 	textBlock��$
��Left=�$��18��$��0,10,0,0q�$
��Wrap=�$��Pojazd:��$	��Top=�$��52��$	 1.144,0.667&��� -   $
 
textBlock1��$
��Left=�$��19��$��	-3,74,0,0q�$
��Wrap=�$��Cena:��$	��Top=�$��55���� -   $
 
textBlock2��$
��Left=�$��20��$��	44,94,0,0q�$
��Wrap=�$��do��$	��Top=�$��23��$	 
0.522,0.95&��� -   $
 
textBlock3��$
��Left=�$��34��$��	1,119,0,0q�$
��Wrap=�$	��Top=�$	��105���� $�Maksymalne spalanie���� $�:���� -   $
 
textBlock4��$
��Left=�$��26��$��
57,158,0,0q�$
��Wrap=�$��l/100km��$	��Top=�$��49���� -    ��Name$ quadCheckbox��$
��Quad��$��Right=�$	��Top=�$	 
0.235,3.25&�$��17��$��	0,33,64,0q�$��52�� d� 	IsChecked �� *SearchOptions.quad+$ OneWayToSource=� �� FallbackValue$
 true���� -	   $ motoCheckbox��$��Motocykl��$
��Left=�$��1,55,0,0q�$	��Top=�$	 -0.338,0.562&�$��68�� �� *SearchOptions.motorcycle+$ OneWayToSource=�$
 true��%  Xceed.Wpf.Toolkit.IntegerUpDown  -
     Name$
 From��$
��Left=�$��1,93,0,0q�$	��Top=�$	 
-0.659,0.9&��  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value �� *SearchOptions.minprice+$ OneWayToSource=�$ 0��  -   $ To��$
��Left=�$��	67,93,0,0q�$	��Top=� �� *SearchOptions.maxprice+$ OneWayToSource=�$
 1000���� -    ��Name$ zalogujButton��$��Zaloguj��$
��Left=�$��	1,285,0,0q�$	��Top=�$	��105���� -   $ dodajButton��$��Dodaj��$
��Left=�$��	1,260,0,0q�$	��Top=�$	��105������ *OpenAddWindow+�� -   $ panelButton��$��Otworz Panel��$
��Left=�$��	1,235,0,0q�$	��Top=�$	��105��$	 -0.107,-0.35&��� ���#000000$��4��$��	1,184,0,0q�
���   �$	��Top=�$
��Left=�$	��115���� -    ��Name$ labelLog��$��Niezalogowany��$
��Left=�$��	1,198,0,0q�$	��Top=�$	��105��$��32���� -    ��Name$ listView��$��Right=�$	��Top=�$��2��$��	0,0,0,-30q����� *ActualHeight+$ 1��# [  $ MainWin��$ OneWay=����� *
Vehicles+ �� SelectedItem �� *SelectedVehicle+����  �� 
TargetType" ��.���  �� Property � �� �� Value$ 80����  � �� �� *IsFree+# [  �� View �� .P��� -   Column1��$��Zdjecie�� �� Width �� *ActualWidth+$
 0,15��# [  $ MainWin�� �� CellTemplate �� .R��� ���� *Image+���� *ActualHeight+$ Column1������ *ActualWidth+$ Column1���� $��Nazwa�� �� DisplayMemberBinding �� *Name+ �� *ActualWidth+$
 0,15��# [  $ MainWin���� $	��Typ�� �� *Type+ �� *ActualWidth+$
 0,15��# [  $ MainWin���� $��Cena za godzinę�� �� *PricePerHour+ �� StringFormat$ {0}zł/h�� �� *ActualWidth+$
 0,15��# [  $ MainWin���� $��Ocena�� �� *Rating+$ {0}/5�� �� *ActualWidth+$
 0,15��# [  $ MainWin��  -   $ consumptionBox��$
��Left=�$	��Top=�$��
10,155,0,0q�$��50�� �� *SearchOptions.maxconsumption+$ OneWayToSource=�$ 10��