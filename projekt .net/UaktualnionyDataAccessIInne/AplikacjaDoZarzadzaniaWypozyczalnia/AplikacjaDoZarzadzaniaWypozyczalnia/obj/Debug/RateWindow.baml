   M S B A M L   `   `   `  ����D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  5   	   4    .AplikacjaDoZarzadzaniaWypozyczalnia.RateWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     5   	   X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  
RateWindow��5	   	   $	��218��6   $	��300��6)    � 
ResizeMode$ NoResize=�5
      .��5      � .+�5   
   �� -   5         ��Name$ label��5      $
��Imie��6   $
��Left=�6.   $��25��6I   $��	19,10,0,0q�6U   $	��Top=�6h   $	��101��6�   �� 5   
   -   5        $ 
label_Copy��5      $��Nazwisko��6$   $
��Left=�67   $��25��6R   $��	19,35,0,0q�6^   $	��Top=�6q   $	��101��6�   �� 5   
   -   5        $ label_Copy1��5      $��PESEL��6%   $
��Left=�65   $��25��6P   $��	19,60,0,0q�6\   $	��Top=�6o   $	��101��6�   �� 5   
   -   5        $ label_Copy2��5      $��Ocena��6%   $
��Left=�65   $��25��6P   $��	19,85,0,0q�6\   $	��Top=�6o   $	��101��6�   �� 5   
   -   5         ��Name$ textBoxImie��5      $
��Left=�6'   $��25��6B   $��
146,10,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��102��6�   �� 5   
   -   5        $ textBoxNazwisko��5      $
��Left=�6+   $��25��6F   $��
146,35,0,0q�6R   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��102��6�   �� 5   
   -   5        $ textBoxPESEL��5      $
��Left=�6(   $��25��6C   $��
146,62,0,0q�6O   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��102��6�   %  Xceed.Wpf.Toolkit.IntegerUpDown  5   
   -   5          Name$ rating��5      $
��Left=�6-   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Maximum$ 5X�6H      Minimum$ 0X�6T   $��
146,85,0,0q�6`   $	��Top=�6t   $	��102��6�   �� 5   
   -	   5         ��Name$ buttonAnuluj��5      $��Anuluj��6B   $
��Left=�6S   $��
45,134,0,0q�6n   $	��Top=�6�   $��75��6�   �� 5   
   -
   5        $ 
buttonRate��5      $��Oceń!��6>   $
��Left=�6N   $��173,134,0,0q�6i   $	��Top=�6~   $��75��6�   5      5      