   M S B A M L   `   `   `  ����M  IWeatherForecastWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WeatherForecastWPFWeatherForecastWPF  5   	   #    WeatherForecastWPF.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   R NOxyPlot.Wpf, Version=2.1.2.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0Y UOxyPlot.Wpf.Shared, Version=2.1.2.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0"oxyhttp://oxyplot.org/wpf   5   	   .local clr-namespace:WeatherForecastWPF   5   	     � Title$  Weather Forecast��5
   	   $	��450��6"   $	��800��6/    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name�� 5   
   F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6   :x,http://schemas.microsoft.com/winfx/2006/xaml     5      %�  '��       �� 5      " ��6   .�5   
   ��  � ��$ 1q�6,   �� 5   
    � ��
 �����6(   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� #��z��6   #��z��5      $ 20��5      ._�5      �� $ PART_ContentHost��6'   5      5      5      �� 5   
    � ��$ 5q�6$   �� 5   
    � ��$	 320��6"   �� 5   
    � ��$ 44��6#   �� 5    
    � ��$ Center=�60   �� 5!   
    � ��$	 Top=�6.   5"      5#      .��5%      �� $
��Auto=�6   $
��Auto=�66   .��5&      � .+�5'      �� -   5        $��Latitude��5'      $��Latitude��6   $��0, 50, 0, 0q�6.   �� 5(      -   5        $��	Longitude��5(      $��	Longitude��6   $��0, 150, 0, 0q�60   �� 5)      -   5        $��	DaysCount��5)   G   $7��1Insert days to forecast (Can not be more than 16)��6   $��0, 250, 0, 0q�6X   �� 5*      -   5        $%��Generate Weather forecast graph��5*      $	��Top=�6L   $	��320��6d   $��44��6p   $��Center=�6|   $��	0,350,0,0q�6�     OxyPlot.Wpf.PlotView  5+      -   5          Name$ plotView��5+      $��Stretch=�6%   $��Stretch=�6C   $��10, 450, 0, 0q�6_   �� 5,      -   5        $��	MainPanel��5,      	 �� Orientation$	 Vertical=�6"   5-      5/      50      