   M S B A M L   `   `   `  ����G  CMedicineInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MedicineInfoMedicineInfo  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5          MedicineInfo.SurveyResult   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MedicineInfo     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      .��5      � $��0,0,0,0q�6   ���	#FFCDE9CE  � RowDefinitions  5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"     LiveCharts.Wpf.PieChart  5   
   -   5        $��Chart��5      $��1��6$   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�5         InnerRadius$	 100Q�6+   $��0,0,0,0q�6=    J� RenderTransformOrigin$	 1,1&�6N   $��RightToLeft=�6j      Series 5   1   �� *SeriesCollection1+z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$	 0.1Q�6&   T� 5      5         ChartLegend 5      "  LiveCharts.Wpf.DefaultLegend  5         
BulletSize$ 20Q�6$   $	��109��64   $��77��6A   $
��Left=�6L   $	��Top=�6g   $ 0.146,0.467&�6   z�5      V� 5      .~�5      �� �� 5       	 �� AngleX$	 1Q�6,   �� 5!      $ 1Q�6.   T� 5"      
 T� X$

 -5.0Q�61    T� Y$	 2.0Q�6:   5#      5%         DataTooltip 5'      #  LiveCharts.Wpf.DefaultTooltip  5(         
BulletSize$ 1Q�6%   66   5*      �� 5+   
   -   5         ��Name$ first��5+      $
��Left=�6!   $��65��6<   $��364,214,0,0q�6H   $��1��6]    �� TextWrapping$
 Wrap=�6j   $��설문 문제��6~   $	��Top=�6�   $	��158��6�   $��Yu Gothic UI Semibold)�6�   �� 5,   
   -   5         ��Name$ q1��5,      $
��1번��6   $
��Left=�6*   $��42��6E   $��
714,23,0,0q�6Q   $��2��6e   $	��Top=�6v   $��64��6�   $��Verdana)�6�   ���	#FF2195F2���	#FFEAF5F86�   �� 5-   
   -   5        $ q2��5-      $
��2번��6   $
��Left=�6*   $��42��6E   $��
714,89,0,0q�6Q   $��2��6e   $	��Top=�6v   $��64��6�   $��Verdana)�6�   ���	#FFF34336���	#FFEAF5F86�   �� 5.   
   -   5        $ q3��5.      $
��3번��6   $
��Left=�6*   $��42��6E   $��714,160,0,0q�6Q   $��2��6f   $	��Top=�6w   $��64��6�   $��Verdana)�6�   ���	#FFFEC007���	#FFEAF5F86�   �� 5/   
   -   5        $ q4��5/      $
��4번��6   $
��Left=�6*   $��42��6E   $��	714,0,0,0q�6Q   $��Center=�6d   $��64��6   $��Verdana)�6�   ���	#FF607D8A���	#FFEAF5F8$��1��6�   �� 50   
   -   5        $ q5��50      $
��5번��6   $
��Left=�6*   $��42��6E   $��714,300,0,0q�6Q   $	��Top=�6f   $��64��6~   $��Verdana)�6�   ���	#FF1A1A1A���	#FFEAF5F8$��1��6�   51      52      