   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ labelPrompt��5
      $��Mileage Calculator��6%   $
��Left=�6B   $��	10,10,0,0q�6]   $	��Top=�6p   �� 5   
   -   5        $ labelMileage��5      $��Enter Mileage��6&   $
��Left=�6>   $��	30,50,0,0q�6Y   $	��Top=�6l    J� RenderTransformOrigin$ -0.809,0.389&�6�   �� 5   
   -   5         ��Name$ enterMileage��5      $
��Left=�6(   $��23��6C   $��	30,76,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ labelGallons��5      $��Enter Gallons��6&   $
��Left=�6>   $��
30,110,0,0q�6Y   $	��Top=�6m   �� 5   
   -   5        $ enterGallons��5      $
��Left=�6(   $��23��6C   $��
30,136,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   	� 5   
   -   5         	�Name$ 
radio10gal��5      $��
10 gallons��6*   $
��Left=�6?   $��
30,179,0,0q�6Z   $	��Top=�6n   6�   	� 5   
   -   5        $ 
radio15gal��5      $��
15 gallons��6*   $
��Left=�6?   $��
30,199,0,0q�6Z   $	��Top=�6n   	� 5   
   -   5        $ 
radio20gal��5      $��
20 gallons��6*   $
��Left=�6?   $��
30,219,0,0q�6Z   $	��Top=�6n   6�   	� 5   
   -	   5        $ radioButton��5      $��Other��6+   $
��Left=�6;   $��
30,239,0,0q�6V   $	��Top=�6j   �� 5   
   -
   5        $ textBoxOther��5      $
��Left=�6(   $��15��6C   $��
84,239,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $��66��6�   �� 5   
   -   5         ��Name$ buttonSubmit��5      $��Submit��6'   $
��Left=�68   $��424,284,0,0q�6S   $	��Top=�6h   $��75��6�   $ 1.119,9.984&�6�   6�   �� 5   
   -   5        $ labelResult��5      $��Label��6%   $
��Left=�65   $��
30,278,0,0q�6P   $	��Top=�6d   $ 0.536,-0.757&�6|   $	��350��6�   5      5      