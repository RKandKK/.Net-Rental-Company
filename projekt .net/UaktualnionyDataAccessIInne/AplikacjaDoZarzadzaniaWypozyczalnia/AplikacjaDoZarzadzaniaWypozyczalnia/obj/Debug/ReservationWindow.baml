   M S B A M L   `   `   `  ����D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  5   	   ;    5AplikacjaDoZarzadzaniaWypozyczalnia.ReservationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     5   	   -   5          �Name$  ReservWindow��5   t    � Title$ Reservation��6	   $	��600��6   $	��300��6*   $	��600��66   $	��600��6F   $	��300��6V   $	��300��6e    � 	Resources 5	      8  2AplikacjaDoZarzadzaniaWypozyczalnia.WidthConverter   WidthConverter8  2AplikacjaDoZarzadzaniaWypozyczalnia.ColorConverter  ColorConverter �� 
TargetType �� Property �� Value��%�   &	        &	      '�� &     '�� w       5
   
   68     5   
   68   �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   6E   5      �� 5   
   " ��6   .�5      ��  � ��$ 20 �6'   64   5      5      .��5      �  � RowDefinitions 5   
   �� 5      ��6   �� *ActualHeight+ �� ElementName$ ReservWindow�� �� 	Converter# [  	 �� ConverterParameter$		 0,4��6�   �� 5      ��6   �� *ActualHeight+$ ReservWindow��# [  $		 0,6��6�   .+�5   
   � $��1��6   .+�5      �  5      �� 5      6&   �� 5      6&   �� 5      6&   �� 5      6&   �� 5      6&   �� 5       $��0 �6$   61   �� 5!      6&   �� 5"      6&   �� 5#      6&   �� 5$      $��50 �6$   62   .+�5&      �� $��0��6P   ��6   �� *Name+
 �� StringFormat$
 
Nazwa: {0}��6_   �� 5'      $��1��6P   ��6   �� *Type+$
 Rodzaj: {0}��6_   �� 5(      $��2��6j   ��6   �� *PricePerHour+$$
 Cena za godzinę jazdy: {0}zł��6y   �� 5)      $��3��6k   ��6   �� *FuelConsumption+$!
 Spalanie paliwa: {0}l/100km��6z   �� 5*      $��4��6h   ��6   �� *DriversLicense+$
 Wymagane prawo jazdy: {0}��6w   �� 5+      $��6��6a   ��6   �� *Vmax+$%
 Prędkość maksymalna: {0}km/h��6p   �� 5,      $��7��6e   ��6   �� *TrunkCapacity+$
 Pojemność schowka: {0}l��6t   �� 5-      $��8��6`   ��6   �� *Rating+$!
 Ocena użytkowników: {0}/5��6o   � 5.      $��9��6   $��50��6$    � ColumnDefinitions 5/      �� 50      6-   �� 51      $��90 �6+   68   �� 52      6-   .+�54      �� -   5        $��25��54      $��90��6)   $��0��64   .��6Y   Edytuj6a   �� 55      -   5         ��Name$ 
buttonRate��55      $��1��61   $��25��6A   $��90��6M   $��Oceń��6q   �� 56      -   5        $��25��56      $��90��6)   $��2��64   .��6U   
Wynajmij6_   57      58      59      �� 5:   
   $��0��6)   ��6   �� *Image+68   5;      5<      