   M S B A M L   `   `   `  ����F  BGraficasWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GraficasWPFGraficasWPF  5   	       GraficasWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GraficasWPF     5   	   R NOxyPlot.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	   
���P��  � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��.25* �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��0��6$   $��2��61   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� 	Deporte6%   �� 5      -   5         ��Name$ 
cmbDeporte��5      $	��100��6/   6=   �� 5      -   5         ��Name$ btnAceptarDeporte��5      .��6T   	Aceptar6]   5      �� 5      $ 
Horizontal=�6   .+�5      �� Equipo6$   �� 5      -   5        $ 	cmbEquipo��5      $	��100��6.   6<   �� 5      -   5        $ btnAceptarEquipo��5      .��6R   	Aceptar6[   5      �� 5       $ 
Horizontal=�6   .+�5!      �� -   5         ��Name$ MarFinal��5!      6.   5"      �� 5#      -   5        $ btnCalcular��5#      .��6*   
Calcular64   5$      &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ Tabla��5%      $��0��6"   $��1��62   6A     OxyPlot.Wpf.PlotView  5&   
   -   5          Name$ Grafica��5&      $��1��6(   $��1��68   5'      5(      