   M S B A M L   `   `   `  ���� D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  4    .AplikacjaDoZarzadzaniaWypozyczalnia.RateWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  
RateWindow��$	��218��$	��300�� � 
ResizeMode$ NoResize=�.��� .+��� -    ��Name$ label��$
��Imie��$
��Left=�$��25��$��	19,10,0,0q�$	��Top=�$	��101���� -   $ 
label_Copy��$��Nazwisko��$
��Left=�$��25��$��	19,35,0,0q�$	��Top=�$	��101���� -   $ label_Copy1��$��PESEL��$
��Left=�$��25��$��	19,60,0,0q�$	��Top=�$	��101���� -   $ label_Copy2��$��Ocena��$
��Left=�$��25��$��	19,85,0,0q�$	��Top=�$	��101���� -    ��Name$ textBoxImie��$
��Left=�$��25��$��
146,10,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��102���� -   $ textBoxNazwisko��$
��Left=�$��25��$��
146,35,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��102���� -   $ textBoxPESEL��$
��Left=�$��25��$��
146,62,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��102��%  Xceed.Wpf.Toolkit.IntegerUpDown  -     Name$ rating��$
��Left=��  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Maximum$ 5X�   Minimum$ 0X�$��
146,85,0,0q�$	��Top=�$	��102���� -	    ��Name$ buttonAnuluj��$��Anuluj��$
��Left=�$��
45,134,0,0q�$	��Top=�$��75���� -
   $ 
buttonRate��$��Oceń!��$
��Left=�$��173,134,0,0q�$	��Top=�$��75��