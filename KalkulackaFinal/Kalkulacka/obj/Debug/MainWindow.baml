   M S B A M L   `   `   `  ����  
Kalkulacka    Kalkulacka.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$.  (MOPOSOFT Výpočet trapézového šroubu��5   	   $��310.912��65   $��637.925��6F   $	��388��6V   $	��134��6e    � WindowStartupLocation$ CenterScreen=�6u    � Icon$ kalkulacka.ico��6�   .��5      � $��0q�6    J� RenderTransformOrigin$ 0.505,0.489&�6    � ColumnDefinitions 5   
   �� 5      $	��132 �6   �� 5      $	��159 �6   �� 5	      $	��339 �6    � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5        $��vypocitejButton��5   ?   $��Vypočítej M��6   $	��Top=�6'   $��10,118,241,0q�6t   $��88��6�   $��20��6�   $ 
1.214,0.75&�6�   $��2��6�   �� 5   
   -   5        $��operaceComboBox��5   l   $	��Top=�6   $
��Left=�6+   $��	10,29,0,0q�6G    �� SelectedIndex$ 0��6Z   $��22��6�   $��2��6�   $��88��6�   .@�5      �� $��	Tr 16 x 4��6   �� 5      $��	Tr 20 x 4��6   �� 5      $��	Tr 24 x 5��6   �� 5      $��	Tr 28 x 5��6   �� 5      $��	Tr 30 x 6��6   �� 5      $��	Tr 32 x 6��6   �� 5      $��	Tr 36 x 6��6   �� 5      $��	Tr 40 x 7��6   �� 5      $��	Tr 44 x 7��6   �� 5      $��	Tr 50 x 8��6   �� 5      $��	Tr 55 x 9��6   �� 5      $��	Tr 60 x 9��6   5      �� 5   
   -   5        $��vysledekTextBlock��5   H   $	��Top=�6   $
��Left=�6-   $��
76,172,0,0q�6a   $��79��6v   $��26��6�   $��2��6�   
�������
���   �06�   �� 5   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $ 	0.89,2.25&�6n   $��16��6�   $��66��6�   �� 6�   $�Síla��6�   �� 6�   $� F��6�   �� 6�   $
� [N]��6�   6�   �� 5    
   $
��Left=�6   $��	10,55,0,0q�6/   $
��Wrap=�6B   $��Mez kluzu v tahu [MPa]��6V   $	��Top=�6t   $ 	0.89,2.25&�6�   $��97��6�   $��32��6�   �� 5!   
   $
��Left=�6   $��
10,120,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $ 	0.89,2.25&�6o   $��97��6�   $��48��6�   �� 6�   $�Předběžný��6�   �� 6�   $� ��6�   �� 6�   $	�Ø ��6�   �� 6�   $�šroubu [mm]��6�   6�   �� 5"   
   -   5        $��Vypočítej Ø��5"      $
��Left=�6'   $��
10,213,0,0q�6B   $	��Top=�6V   $��88��6n   $��20��5#   '   �� 5$   
   -   5         ��Name$ 	txtNumber��5$      $
��Left=�6%   $��23��6@   $��	10,28,0,0q�6L   $�� ��6_   $	��Top=�6g   $��88��6   �� 5%   
   -   5        $ 
txtNumber2��5%      $
��Left=�6&   $��23��6A   $��	10,92,0,0q�6M   $�� ��6`   $	��Top=�6h   $��88��6�   �� 5&   
   $��2��6   $
��Left=�6    $��52��6;   $��163,218,0,0q�6G   $	��Top=�6\   $	��166��6t   $��moposoft.png��6�   �� 5'   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $ 	0.89,2.25&�6n   $��2��6�   $��16��6�   $��78��6�   $��Výběr závitu��6�   �� 5(   
   $
��Left=�6   $��	10,56,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $ 	0.89,2.25&�6n   $��16��6�   $��52��6�   $��2��6�   �� 6�   $�Síla��6�   �� 6�   $� F��6�   �� 6�   $
� [N]��6�   6�   �� 5)   
   -   5        $ 
txtNumber4��5)      $
��Left=�6&   $��23��6A   $��	10,77,0,0q�6M   $�� ��6`   $	��Top=�6h   $��88��6�   $��2��6�   �� 5*   
   $
��Left=�6   $��
10,155,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $ 	0.89,2.25&�6o   $��51��6�   $��52��6�   $��2��6�   �� 6�   $�Potřebný moment [N.m]��6�   �� 6�   $� ��6�   6�   �� 5+   
   -   5        $��
O programu��5+      $	��Top=�6&   $��19,213,26,0q�6Q   $��20��6f   $ 
1.214,0.75&�6r   $��1��6�   �� 5,   
   $
��Left=�6   $��
150,13,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $ 	0.89,2.25&�6o   $��2��6�   $��16��6�   $	��107��6�   �� 6�   $�Napětí tlak��6�   �� 6�   $� [MPa]��6�   6�   �� 5-   
   $
��Left=�6   $��
150,71,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $ 	0.89,2.25&�6o   $��2��6�   $��16��6�   $	��107��6�   �� 6�   $�Napětí krut��6�   �� 6�   $� [MPa]��6�   6�   �� 5.   
   $
��Left=�6   $��
256,41,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $ 	0.89,2.25&�6o   $��2��6�   $��16��6�   $��73��6�   �� 6�   $�Max 65 ��6�   �� 6�   $	�MPa��6�   6�   �� 5/   
   $
��Left=�6   $��256,102,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $ 	0.89,2.25&�6p   $��2��6�   $��16��6�   $��68��6�   �� 6�   $�Max 40��6�   �� 6�   $
� MPa��6�   6�   �� 50   
   $��1��6   $
��Left=�6    $	��160��6;   $��	19,28,0,0q�6H   $	��Top=�6[   $	��139��6s   $��
sroub4.png��6   �� 51   
   -	   5         ��Name$ vysledekTextBlock_tlak��51   H   $	��Top=�6   $
��Left=�6-   $��
163,40,0,0q�6h   $��79��6}   $��26��6�   $��2��6�   
�������
���   ��� 6�   $�0��6�   6�   �� 52   
   -
   5        $ vysledekTextBlock_krut��52   H   $	��Top=�6   $
��Left=�6-   $��163,102,0,0q�6h   $��79��6~   $��26��6�   $��2��6�   
�������
���   ��� 6�   $�0��6�   6�   �� 53   
   -   5        $ vysledekTextBlock_prumer��53   H   $	��Top=�6   $
��Left=�6-   $��
28,168,0,0q�6j   $��79��6   $��26��6�   
�������
���   ��� 6�   $�0��6�   6�   54      55      