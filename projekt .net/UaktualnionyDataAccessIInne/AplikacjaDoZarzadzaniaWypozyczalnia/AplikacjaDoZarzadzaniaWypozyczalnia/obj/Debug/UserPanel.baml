   M S B A M L   `   `   `  ����D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  5   	   3    -AplikacjaDoZarzadzaniaWypozyczalnia.UserPanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     5   	     � Title$  	UserPanel��5   	   $	��300��6   $��390.426��6(   .��5	      � .+�5
   
   �� -   5         ��Name$ listView��5
      $
��Left=�6%   $	��186��6@   $��	10,37,0,0q�6M   $	��Top=�6`   $	��362��6x    �� View 5      �� 5      .P�5      ��  �� Width$ 75��6%   $��Pojazd��60    �� DisplayMemberBinding 6@   �� *Vehicle.Name+�� 5      $ 70��6%   $��Od��60    6<   �� *Since+6e   �� 5      $ 70��6%   $��Do��60    6<   �� *Till+6d   �� 5      $ 75��6%   $��Koszt��60    6?   �� *Cost+6g   �� 5      $ 70��6%   $��Oceń��61    �� CellTemplate 5      �� 5      .R�5   "   �� $��
Buttonocen��6)   $
��Ocen��6;   $��68��6J   6W   5      5      5      5      �� 5   
   -   5         ��Name$ zmienHasloButton��5      $��Zmień hasło��6+   $
��Left=�6A   $��
10,239,0,0q�6\   $	��Top=�6p   $	��134��6�   �� 5   
   -   5        $ AnulujButton��5      $��Anuluj��6'   $
��Left=�68   $��239,239,0,0q�6S   $	��Top=�6h   $	��133��6�   �� 5   
   -   5         ��Name$ label1��5      $��Moje zamówienia:��6    $
��Left=�6;   $��10,6,0,0q�6V   $	��Top=�6h   $	��109��6�   $��26��6�   5      5       