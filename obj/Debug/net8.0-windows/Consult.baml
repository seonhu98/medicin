   M S B A M L   `   `   `  ����G  CMedicineInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MedicineInfoMedicineInfo  5          MedicineInfo.Consult   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MedicineInfo     5        N� Title$  Consult��5	       � 	Resources 5         LeftBubbleStyle �� 
TargetType �� Property �� Value  RightBubbleStyle��%   &	        &	 �     �� 5   
   " ��6(   .�5      ��  � �� �	#FFB7B5B36+   �� 5       � ��$ 5q�6'   �� 5       �@��Padding$ 10q�6(   �� 5       �@��CornerRadius$ 10��6-   �� 5       � ��$
 Auto��6&   5      �� 5   
   " ��6)   .�5      ��  � �� �	#FFFFEBC16+   �� 5       � ��$ 5q�6'   �� 5       �@��Padding$ 10q�6(   �� 5       �@��CornerRadius$ 10��6-   �� 5       � ��$
 Auto��6&   5      5      .��5      � -   5         �Name$ 
background��5      ���	#FFCDE9CE$��0,0,-67,-80q�66    � ColumnDefinitions 5   
   �� 5       �� 5!      $��0* �6   �� 5"      $	��100 �6    � RowDefinitions 5$   
   �� 5%      $��* �6   �� 5&      $��50 �6   .+�5(   
   �� $��Center=�6   $��0,10,0,0q�61   $
��Wrap=�6C   $��MedIntel��6W   $	��Top=�6g   $	��200��6   $��36(�6�   $��Ink Free)�6�   ���	#FF0C6111$
��Bold"�6�    �� TextAlignment$ Center=�6�   $��45��6�   �� 5)   
   $
��Left=�6   $��1��6/   $��0,63,0,0q�6:   ���	#FF0C6111$	��Top=�6_   $	��786��6w   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   z�5*      V� 5+      .~�5,      �� 
 �� ScaleY$
 -1Q�6%   �� 5-      �� 5.      T� 5/      50      52      �� 53   
   -   5         ��Name$ btn_Send��53      $��643,354,24,41q�6#   $��전송��6:   $��18(�6]   ��6G   Z� 6k   �� 54   
   -   5         ��Name$ message��54      $��43,354,0,41q�6#   ���	#FFFCF9F9$��0��6O   $��14(�6_   $��메세지입력��6�   $
��Left=�6�   $	��583��6�   6�   �� 55   
   -   5         ��Name$ client��55      $
��Left=�6"   $	��250��6=   $��	43,84,0,0q�6J   $	��Top=�6]   $	��700��6u   �� 56   
   -   5        $ menu_bt��56      $
��Menu��6"   $
��Left=�61   $��39��6L   $	��Top=�6X   $��90��6p   $��
646,13,0,0q�6{   ���	#FFF4EFEF6�   58      59      