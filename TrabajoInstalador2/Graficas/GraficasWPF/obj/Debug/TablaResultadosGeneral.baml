   M S B A M L   `   `   `  ����F  BGraficasWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GraficasWPFGraficasWPF  5   	   (    "GraficasWPF.TablaResultadosGeneral   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GraficasWPF     5   	   
���i��  � Title$  TablaResultadosGeneral��5	   	   $	��450��6(   $	��800��65   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   .+�5      �� .��6   	Deporte6   �� 5      -   5         ��Name$ 
cmbDeporte��5   #   $	��100��6   69   �� 5      -   5         ��Name$ AceptarDeporte��5      .��6J   Aceptar Deporte6[   5      � 5   
   $��1��6   .+�5      �� .��6   Primer Lugar6"   �� 5      -   5         ��Name$ txbGanadorPri��5      $	��100��6-   6;   �� 5      -   5        $ btnMostrarGanador��5      .��6P   Mostrar Ganador6a   �� 5      .��6   Segundo Lugar6#   �� 5      -   5        $ txbGanadorSe��5      $	��100��6,   6:   �� 5      .��6   Tercer Lugar6"   �� 5      -   5        $ txbGanadorTer��5      $	��100��6-   6;   �� 5      -   5        $ btnEliminar��5      .��6D   
Eliminar6N   5      &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ dtgTabla��5        $
��auto��6   $��3��62      
IsReadOnly . 6?   5!      5"      