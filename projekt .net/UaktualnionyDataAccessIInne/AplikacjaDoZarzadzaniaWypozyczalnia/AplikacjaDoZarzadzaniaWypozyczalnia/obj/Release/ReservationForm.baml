   M S B A M L   `   `   `  ���� D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  9    3AplikacjaDoZarzadzaniaWypozyczalnia.ReservationForm   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  ReservationForm��$	��300��$	��300��.��� .+��� -    ��Name$ label��$��Imię��$
��Left=�$��34��$��	21,20,0,0q�$	��Top=�$��61���� -   $ label1��$��Nazwisko��$
��Left=�$��30��$��	21,59,0,0q�$	��Top=�$��61���� -    ��Name$ textBoxImie��$
��Left=�$��21��$��
118,20,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��121���� -   $ textBoxNazwisko��$
��Left=�$��21��$��
118,59,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��121���� -    ��Name$ buttonRezerwuj��$��Rezerwuj��$
��Left=�$��27��$��160,233,0,0q�$	��Top=�$��79�� J� RenderTransformOrigin$ 1.747,0.519&��� -   $ buttonAnuluj��$��Anuluj��$
��Left=�$��27��$��
35,233,0,0q�$	��Top=�$��81���� -   $ label2��$	��Od:��$
��Left=�$��32��$��
21,147,0,0q�$	��Top=�$��28���� -   $ label3��$	��Do:��$
��Left=�$��35��$��
21,193,0,0q�$	��Top=�$��28��&   Xceed.Wpf.Toolkit.DateTimePicker  -	     Name$ SincePicker��$
��Left=�$��
64,147,0,0q�$	��Top=�$	��208��$��32��  -
   $ 
TillPicker��$
��Left=�$��
64,193,0,0q�$	��Top=�$	��208��$��35���� -   $ label4��$��PESEL��$
��Left=�$��26��$��	21,94,0,0q�$	��Top=�$��61���� -   $ textBoxPESEL��$
��Left=�$��26��$��
118,94,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��121��