   M S B A M L   `   `   `  ����D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  5   	   9    3AplikacjaDoZarzadzaniaWypozyczalnia.ReservationForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     5   	   X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  ReservationForm��5	   	   $	��300��6!   $	��300��6.   .��5
      � .+�5   
   �� -   5         ��Name$ label��5      $��Imię��6   $
��Left=�6.   $��34��6I   $��	21,20,0,0q�6U   $	��Top=�6h   $��61��6�   �� 5   
   -   5        $ label1��5      $��Nazwisko��6    $
��Left=�63   $��30��6N   $��	21,59,0,0q�6Z   $	��Top=�6m   $��61��6�   �� 5   
   -   5         ��Name$ textBoxImie��5      $
��Left=�6'   $��21��6B   $��
118,20,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��121��6�   �� 5   
   -   5        $ textBoxNazwisko��5      $
��Left=�6+   $��21��6F   $��
118,59,0,0q�6R   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��121��6�   �� 5   
   -   5         ��Name$ buttonRezerwuj��5      $��Rezerwuj��6)   $
��Left=�6<   $��27��6W   $��160,233,0,0q�6c   $	��Top=�6x   $��79��6�    J� RenderTransformOrigin$ 1.747,0.519&�6�   6�   �� 5   
   -   5        $ buttonAnuluj��5      $��Anuluj��6'   $
��Left=�68   $��27��6S   $��
35,233,0,0q�6_   $	��Top=�6s   $��81��6�   6�   �� 5   
   -   5        $ label2��5      $	��Od:��6    $
��Left=�6.   $��32��6I   $��
21,147,0,0q�6U   $	��Top=�6i   $��28��6�   �� 5   
   -   5        $ label3��5      $	��Do:��6    $
��Left=�6.   $��35��6I   $��
21,193,0,0q�6U   $	��Top=�6i   $��28��6�   &   Xceed.Wpf.Toolkit.DateTimePicker  5   
   -	   5          Name$ SincePicker��5      $
��Left=�63   $��
64,147,0,0q�6N   $	��Top=�6b   $	��208��6z   $��32��6�     5   
   -
   5        $ 
TillPicker��5      $
��Left=�62   $��
64,193,0,0q�6M   $	��Top=�6a   $	��208��6y   $��35��6�   �� 5   
   -   5        $ label4��5      $��PESEL��6    $
��Left=�60   $��26��6K   $��	21,94,0,0q�6W   $	��Top=�6j   $��61��6�   �� 5   
   -   5        $ textBoxPESEL��5      $
��Left=�6(   $��26��6C   $��
118,94,0,0q�6O   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��121��6�   5      5      