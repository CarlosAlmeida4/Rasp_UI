   M S B A M L   `   `   `  ����B  >Rasp_UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Rasp_UIRasp_UI  5   	   H DMapsui.UI.Wpf, Version=1.3.1.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:Mapsui.UI.Wpf;assembly=Mapsui.UI.WpfMapsui.UI.Wpf 5   	       Rasp_UI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Rasp_UI     5   	   Cxaml2clr-namespace:Mapsui.UI.Wpf;assembly=Mapsui.UI.Wpf     5   	     � Title$  
MainWindow��5	   	   $	��617��6   $	��853��6)    � WindowStyle$ ThreeDBorderWindow=�65    J� Opacity$	 0.5Q�6V   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FF555555��6   $ 1Q�6-   5      .��5      � $
��Left=�6    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      �� 5      $��0* �6   .+�5   
   ]� $��3��6   $
��Left=�6(   $	��236��6C   ��.  $��22,26,-138,0q�6f   $	��Top=�6|   $	��116��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .+�5      �� -   5        $��Window1��5      $
��Left=�6'   $	��Top=�6B   $	��115��6Z   $��74��6f   $	��Top=�6�   �� 5      -   5        $��GPS Coordinates��5      $
��Left=�6/   $	��Top=�6J   $	��115��6b   $��79��6n   $ 
0.53,1.063&�6�   $	��Top=�6�   5        Mapsui.UI.Wpf.MapControl  5   
   -   5        $��MyMapControl��5      $��3��6.   $��186,26,-819,94q�6B   6\   �� 5   
   $��	Longitude��6   $��2��6$   $
��Left=�64   $��22,278,-90,0q�6O   $	��Top=�6e   $��25��6}   $��68��6�   
�������6�   �� 5   
   $��Latitude��6   $��2��6#   $
��Left=�63   $��22,341,-90,0q�6N   $	��Top=�6d   $��25��6|   $��68��6�   
�������6�   �� 5   
   -   5        $��3��5      $��Look up Location��6%   $
��Left=�6@   $��24,410,-156,0q�6[   $	��Top=�6r   $	��132��6�   $��29��6�   6�   �� 5   
   -   5        	 ��Name$	 	Longitude��5      $��3��6%   $
��Left=�69   $��49��6T   $��102,280,-172,0q�6`   
 �� TextWrapping$

 Wrap=�6x   $��	Longitude��6�   $	��Top=�6�   $��70��6�   �� 5    
   -   5        $	 Latitude��5       $��3��6$   $
��Left=�68   $��40��6S   $��102,341,-172,0q�6_   $

 Wrap=�6w   $��Latitude��6�   $	��Top=�6�   $��70��6�   6�   5!      5"      