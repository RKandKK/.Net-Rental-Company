   M S B A M L   `   `   `  ���� D  @Wypożycz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia#AplikacjaDoZarzadzaniaWypozyczalnia  :    4AplikacjaDoZarzadzaniaWypozyczalnia.AddVehicleWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:AplikacjaDoZarzadzaniaWypozyczalnia     X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  -     � Title$  AddVehicleWindow��$��335.106��$	��300�� � 
ResizeMode$ NoResize=�.��� .+��� -    ��Name$ label��$��Nazwa��$
��Left=�$��25��$��	24,15,0,0q�$	��Top=�$��58���� -   $ 
label_Copy��$	��Typ��$
��Left=�$��25��$��	24,40,0,0q�$	��Top=�$��58���� -   $ label_Copy1��$��Prawo Jazdy��$
��Left=�$��25��$��	24,65,0,0q�$	��Top=�$��76�� J� RenderTransformOrigin$ 	1.02,1.57&��� -   $ label_Copy2��$��Spalanie (l/100km)��$
��Left=�$��25��$��	24,90,0,0q�$	��Top=�$	��107��$ 	1.02,1.57&��� -   $ label_Copy3��$
��Vmax��$
��Left=�$��25��$��
24,115,0,0q�$	��Top=�$��58��$ 	1.02,1.57&��� -   $ label_Copy4��$��Pojemność bagażnika��$
��Left=�$��25��$��
24,140,0,0q�$	��Top=�$	��126��$ 	1.02,1.57&��� -   $ label_Copy5��$��Cena za godzinę��$
��Left=�$��25��$��
24,165,0,0q�$	��Top=�$	��107��$ 	1.02,1.57&��� -	   $ label_Copy6��$��	Zdjęcie:��$
��Left=�$��25��$��
24,195,0,0q�$	��Top=�$��76��$ 	1.02,1.57&�%  Xceed.Wpf.Toolkit.IntegerUpDown  -
     Name$ consumption��$
��Left=�$	��Top=�$ 2.496,3.218&�$��
155,95,0,0q�$��61��  -   $
 vmax��$
��Left=�$	��Top=�$��155,120,0,0q�$��61��  -   $ trunk��$
��Left=�$	��Top=�$��155,145,0,0q�$��61��  -   $ price��$
��Left=�$	��Top=�$��155,170,0,0q�$��61���� -    ��Name$ textBoxName��$
��Left=�$��23�� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��120��$��
155,15,0,0q��� -    ��Name$ 	choosepic��$��
Wybierz...��$
��Left=�$��155,198,0,0q�$	��Top=�$��75���� -   $ buttonAnuluj��$��Anuluj��$
��Left=�$��
36,240,0,0q�$	��Top=�$��95��$��39���� -   $ 	buttonAdd��$��Dodaj��$
��Left=�$��155,240,0,0q�$	��Top=�$��95��$��39���� -    ��Name$ comboBoxType��$
��Left=�$��22��$��
155,43,0,0q�$	��Top=�$��61���� -   $ comboBoxLicense��$
��Left=�$��22��$��
155,70,0,0q�$	��Top=�$��61��