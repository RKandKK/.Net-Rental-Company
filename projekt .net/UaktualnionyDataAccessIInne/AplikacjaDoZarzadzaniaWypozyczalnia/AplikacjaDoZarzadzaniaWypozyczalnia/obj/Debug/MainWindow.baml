   M S B A M L   `   `   `  ����D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  5   	   4    .AplikacjaDoZarzadzaniaWypozyczalnia.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     5   	   X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          �Name$  MainWin��5
   	    � Title$ Rent-A-Wheel��5	   	   $	��350��6   $	��600��6+   $	��600��67   $	��350��6F    � 	Resources 5      8  2AplikacjaDoZarzadzaniaWypozyczalnia.WidthConverter   WidthConverter>  8AplikacjaDoZarzadzaniaWypozyczalnia.BoolToColorConverter  BoolToColorConverter��%:   &	        &	        5   
   6     5   
   6%   5      .��5      � -   5         �Name$
 Grid��5       � ColumnDefinitions 5   
   �� 5      ��6   �� *ActualWidth+ �� ConverterParameter$
 0,25�� �� 	Converter# [   �� ElementName$ MainWin�� �� Mode$ OneWay=��� 5      ��6   �� *ActualWidth+$
 0,75��# [  $ MainWin��$ OneWay=�.+�5   
   �� $��0��6   $��2��6%   .+�5      � $
��Left=�6   $	��315��6.   $��10,0,0,0q�6;   $	��116��6M   	 J� RenderTransformOrigin$	 0.286,0.502&�6Y   .+�5      �� -   5        
 ��Name$
 	textBlock��5      $
��Left=�6/   $��18��6J   $��0,10,0,0q�6V   $
��Wrap=�6h   $��Pojazd:��6|   $	��Top=�6�   $��52��6�   $	 1.144,0.667&�6�   �� 5      -   5        $
 
textBlock1��5      $
��Left=�60   $��19��6K   $��	-3,74,0,0q�6W   $
��Wrap=�6j   $��Cena:��6~   $	��Top=�6�   $��55��6�   �� 5      -   5        $
 
textBlock2��5      $
��Left=�60   $��20��6K   $��	44,94,0,0q�6W   $
��Wrap=�6j   $��do��6~   $	��Top=�6�   $��23��6�   $	 
0.522,0.95&�6�   �� 5      -   5        $
 
textBlock3��5      $
��Left=�60   $��34��6K   $��	1,119,0,0q�6W   $
��Wrap=�6j   $	��Top=�6~   $	��105��6�   �� 6�   $�Maksymalne spalanie��6�   �� 6�   $�:��6�   6�   �� 5      -   5        $
 
textBlock4��5      $
��Left=�60   $��26��6K   $��
57,158,0,0q�6W   $
��Wrap=�6k   $��l/100km��6   $	��Top=�6�   $��49��6�   �� 5      -   5         ��Name$ quadCheckbox��5      $
��Quad��6L   $��Right=�6�   $	��Top=�6�   $	 
0.235,3.25&�6�   $��17��6  $��	0,33,64,0q�6  $��52��6#   d� 	IsChecked 6[   �� *SearchOptions.quad+$ OneWayToSource=� �� FallbackValue$
 true��6#  �� 5      -	   5        $ motoCheckbox��5      $��Motocykl��6M   $
��Left=�6�   $��1,55,0,0q�6�   $	��Top=�6�   $	 -0.338,0.562&�6�   $��68��6"   6`   �� *SearchOptions.motorcycle+$ OneWayToSource=�$
 true��6"  %  Xceed.Wpf.Toolkit.IntegerUpDown  5      -
   5          Name$
 From��5   %   $
��Left=�6�   $��1,93,0,0q�6�   $	��Top=�6�   $	 
-0.659,0.9&�6�   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 6U   �� *SearchOptions.minprice+$ OneWayToSource=�$ 0��6�     5      -   5        $ To��5   %   $
��Left=�6�   $��	67,93,0,0q�6�   $	��Top=�6�    6S   �� *SearchOptions.maxprice+$ OneWayToSource=�$
 1000��6�   �� 5      -   5         ��Name$ zalogujButton��5      $��Zaloguj��60   $
��Left=�6B   $��	1,285,0,0q�6]   $	��Top=�6p   $	��105��6�   6�   �� 5       -   5        $ dodajButton��5       $��Dodaj��6.   $
��Left=�6>   $��	1,260,0,0q�6Y   $	��Top=�6l   $	��105��6�   ��6�   �� *OpenAddWindow+�� 5!      -   5        $ panelButton��5!      $��Otworz Panel��6.   $
��Left=�6E   $��	1,235,0,0q�6`   $	��Top=�6s   $	��105��6�   $	 -0.107,-0.35&�6�   6�   �� 5"      ���#000000$��4��6+   $��	1,184,0,0q�66   
���   �$	��Top=�6X   $
��Left=�6p   $	��115��6�   �� 5#      -   5         ��Name$ labelLog��5#      $��Niezalogowany��6*   $
��Left=�6B   $��	1,198,0,0q�6]   $	��Top=�6p   $	��105��6�   $��32��6�   5$      5%      �� 5&   
   -   5         ��Name$ listView��5&      $��Right=�6%   $	��Top=�6�   $��2��6S  $��	0,0,0,-30q�6c  ��6A   �� *ActualHeight+$ 1��# [  $ MainWin��$ OneWay=���6�   �� *
Vehicles+ �� SelectedItem 6�   �� *SelectedVehicle+��5'      �� 5(       �� 
TargetType" ��6   .�5)      ��  �� Property � �� �� Value$ 80��6/   �� 5*       � �� 63   �� *IsFree+# [ 5+       �� View 5-      �� 5.      .P�5/      �� -   5        Column1��$��Zdjecie��5/   6    �� Width 6G   �� *ActualWidth+$
 0,15��# [  $ MainWin�� �� CellTemplate 50      �� 51      .R�52   "   �� ��6(   �� *Image+��6A   �� *ActualHeight+$ Column1����6v   �� *ActualWidth+$ Column1��53      55      �� 56      $��Nazwa��6%    �� DisplayMemberBinding 64   �� *Name+ 6Z   �� *ActualWidth+$
 0,15��# [  $ MainWin���� 57      $	��Typ��6%    62   �� *Type+ 6X   �� *ActualWidth+$
 0,15��# [  $ MainWin���� 58      $��Cena za godzinę��6%    6>   �� *PricePerHour+ �� StringFormat$ {0}zł/h�� 6�   �� *ActualWidth+$
 0,15��# [  $ MainWin���� 59      $��Ocena��6%    64   �� *Rating+$ {0}/5�� 6r   �� *ActualWidth+$
 0,15��# [  $ MainWin��5:      5<        5=   
   -   5        $ consumptionBox��5=      $
��Left=�6�   $	��Top=�6�   $��
10,155,0,0q�6�   $��50��6�    6W   �� *SearchOptions.maxconsumption+$ OneWayToSource=�$ 10��6�   5>      5?      