   M S B A M L   `   `   `  ����F  BGraficasWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GraficasWPFGraficasWPF  5   	       GraficasWPF.Tablas   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GraficasWPF     5   	   
���i��  � Title$  Tablas��5	   	   $	��450��6   $	��800��6%   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   .+�5      �� .��6   	Deporte6   �� 5      -   5         ��Name$ 
cmbDeporte��5   #   $	��100��6   69   �� 5      -   5         ��Name$ AceptarDeporte��5      .��6J   Aceptar Deporte6[   5      � 5   
   $��1��6   .+�5      �� .��6   Equipo6   �� 5      -   5        $ 	cmbEquipo��5   #   $	��100��6   68   �� 5      -   5        $ AceptarEquipo��5      .��6H   Aceptar Equipo6X   5      � 5   
   $��2��6   .+�5      �� -   5        $ 
btnMostrar��5      .��6B   	Mostrar6K   �� 5      -   5        $��MarFinal��5      6)   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgTabla��5       $
��auto��6   $��3��62      
IsReadOnly . 6?   5       5!      