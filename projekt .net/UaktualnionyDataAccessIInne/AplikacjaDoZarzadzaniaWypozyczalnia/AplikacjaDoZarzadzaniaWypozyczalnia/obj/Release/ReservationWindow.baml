   M S B A M L   `   `   `  ���� D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  ;    5AplikacjaDoZarzadzaniaWypozyczalnia.ReservationWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     -     �Name$  ReservWindow�� � Title$ Reservation��$	��600��$	��300��$	��600��$	��600��$	��300��$	��300�� � 	Resources 8  2AplikacjaDoZarzadzaniaWypozyczalnia.WidthConverter   WidthConverter8  2AplikacjaDoZarzadzaniaWypozyczalnia.ColorConverter  ColorConverter �� 
TargetType �� Property �� Value��%|   &	        &	      '�� 
     '�� 1         �� " ��.���  � ��$ Center=��� " ��.���  � ��$ 20 �.���  � RowDefinitions �� ���� *ActualHeight+ �� ElementName$ ReservWindow�� �� 	Converter# [  	 �� ConverterParameter$		 0,4���� ���� *ActualHeight+$ ReservWindow��# [  $		 0,6��.+�� $��1��.+��  �� �� �� �� �� �� $��0 ��� �� �� �� $��50 �.+��� $��0������ *Name+
 �� StringFormat$
 
Nazwa: {0}���� $��1������ *Type+$
 Rodzaj: {0}���� $��2������ *PricePerHour+$$
 Cena za godzinę jazdy: {0}zł���� $��3������ *FuelConsumption+$!
 Spalanie paliwa: {0}l/100km���� $��4������ *DriversLicense+$
 Wymagane prawo jazdy: {0}���� $��6������ *Vmax+$%
 Prędkość maksymalna: {0}km/h���� $��7������ *TrunkCapacity+$
 Pojemność schowka: {0}l���� $��8������ *Rating+$!
 Ocena użytkowników: {0}/5��� $��9��$��50�� � ColumnDefinitions �� �� $��90 ��� .+��� -   $��25��$��90��$��0��.��Edytuj�� -    ��Name$ 
buttonRate��$��1��$��25��$��90��$��Oceń���� -   $��25��$��90��$��2��.��
Wynajmij�� $��0������ *Image+