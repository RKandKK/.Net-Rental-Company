   M S B A M L   `   `   `  ����D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  5   	   :    4AplikacjaDoZarzadzaniaWypozyczalnia.AddVehicleWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     5   	   X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$  AddVehicleWindow��5	   	   $��335.106��6"   $	��300��63    � 
ResizeMode$ NoResize=�5
   	   .��5      � .+�5   
   �� -   5         ��Name$ label��5      $��Nazwa��6   $
��Left=�6/   $��25��6J   $��	24,15,0,0q�6V   $	��Top=�6i   $��58��6�   �� 5   
   -   5        $ 
label_Copy��5      $	��Typ��6$   $
��Left=�62   $��25��6M   $��	24,40,0,0q�6Y   $	��Top=�6l   $��58��6�   �� 5   
   -   5        $ label_Copy1��5      $��Prawo Jazdy��6%   $
��Left=�6;   $��25��6V   $��	24,65,0,0q�6b   $	��Top=�6u   $��76��6�    J� RenderTransformOrigin$ 	1.02,1.57&�6�   �� 5   
   -   5        $ label_Copy2��5      $��Spalanie (l/100km)��6%   $
��Left=�6B   $��25��6]   $��	24,90,0,0q�6i   $	��Top=�6|   $	��107��6�   $ 	1.02,1.57&�6�   �� 5   
   -   5        $ label_Copy3��5      $
��Vmax��6%   $
��Left=�64   $��25��6O   $��
24,115,0,0q�6[   $	��Top=�6o   $��58��6�   $ 	1.02,1.57&�6�   �� 5   
   -   5        $ label_Copy4��5      $��Pojemność bagażnika��6%   $
��Left=�6C   $��25��6^   $��
24,140,0,0q�6j   $	��Top=�6~   $	��126��6�   $ 	1.02,1.57&�6�   �� 5   
   -   5        $ label_Copy5��5      $��Cena za godzinę��6%   $
��Left=�6?   $��25��6Z   $��
24,165,0,0q�6f   $	��Top=�6z   $	��107��6�   $ 	1.02,1.57&�6�   �� 5   
   -	   5        $ label_Copy6��5      $��	Zdjęcie:��6%   $
��Left=�68   $��25��6S   $��
24,195,0,0q�6_   $	��Top=�6s   $��76��6�   $ 	1.02,1.57&�6�   %  Xceed.Wpf.Toolkit.IntegerUpDown  5   
   -
   5          Name$ consumption��5      $
��Left=�62   $	��Top=�6M   $ 2.496,3.218&�6e   $��
155,95,0,0q�6�   $��61��6�     5   
   -   5        $
 vmax��5      $
��Left=�6+   $	��Top=�6F   $��155,120,0,0q�6^   $��61��6s     5   
   -   5        $ trunk��5      $
��Left=�6,   $	��Top=�6G   $��155,145,0,0q�6_   $��61��6t     5   
   -   5        $ price��5      $
��Left=�6,   $	��Top=�6G   $��155,170,0,0q�6_   $��61��6t   �� 5   
   -   5         ��Name$ textBoxName��5      $
��Left=�6'   $��23��6B    �� TextWrapping$
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   $��
155,15,0,0q�6�   �� 5   
   -   5         ��Name$ 	choosepic��5      $��
Wybierz...��6<   $
��Left=�6Q   $��155,198,0,0q�6l   $	��Top=�6�   $��75��6�   �� 5   
   -   5        $ buttonAnuluj��5      $��Anuluj��6'   $
��Left=�68   $��
36,240,0,0q�6S   $	��Top=�6g   $��95��6   $��39��6�   6�   �� 5   
   -   5        $ 	buttonAdd��5      $��Dodaj��6<   $
��Left=�6L   $��155,240,0,0q�6g   $	��Top=�6|   $��95��6�   $��39��6�   �� 5   
   -   5         ��Name$ comboBoxType��5      $
��Left=�6)   $��22��6D   $��
155,43,0,0q�6P   $	��Top=�6d   $��61��6|   �� 5   
   -   5        $ comboBoxLicense��5      $
��Left=�6,   $��22��6G   $��
155,70,0,0q�6S   $	��Top=�6g   $��61��6   5       5!      