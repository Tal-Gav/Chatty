   M S B A M L   `   `   `  ����R  NTalMiniProject - Chatty, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TalMiniProject___ChattyTalMiniProject___Chatty  5   	   $    TalMiniProject___Chatty.SignUp   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:TalMiniProject___Chatty     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Title$ SignUp��5   	   $
��1080��6   $
��1920��6&   .��5      � -   5         �Name$ gridi��5       � RowDefinitions 5   
   �� 5      $
��490* �6   �� 5      $	��55* �6   �� 5      $	��46* �6   �� 5      $	��54* �6   �� 5      $	��49* �6   �� 5      $	��54* �6   �� 5      $	��41* �6   �� 5      $	��77* �6   �� 5      $	��60* �6   �� 5      $	��88* �6   �� 5      $	��66* �6    � ColumnDefinitions 5   
   �� 5      $
��732* �6   �� 5      $	��54* �6   �� 5      $	��78* �6   �� 5      $
��172* �6   �� 5       $	��78* �6   �� 5!      $	��73* �6   �� 5"      $
��733* �6   ��5$   
   �� 5%       �� ImageSource$ Images\SignUp\SignUp.png��6   .+�5(   
   �� -   5         ��Name$ UserBack��5(      ���	#FF0C1521$��1��6>   $y�Hidden=�6L   $��1��6`   $��5��6p   �� 5)   
   -   5        $ PassBack��5)      ���	#FF0C1521$��3��6>   $y�Hidden=�6L   $��1��6`   $��5��6p   �� 5*   
   -   5        $ ConfirmPassBack��5*      ���	#FF0C1521$��5��6>   $y�Hidden=�6L   $��1��6`   $��5��6p   G� 5,   
   -   5        	 G�Name$	 ConfirmPassBox��5,      
 J� Opacity$	
 0.6Q�6.   
������ 
�������$��0q�6h   $��1��6|   $��5��6�   $��37(�6�   $��#RockoUltraFLF)�6�    G� Password$  ��6�   $��5��6�   6  G� 5-   
   -   5        $	 PassBox��5-      $	
 0.6Q�6.   
������ 
�������$��0q�6h   $��1��6|   $��3��6�   $��37(�6�   $��#RockoUltraFLF)�6�   $  ��6�   $��5��6  �� 5.   
   -   5         ��Name$ UserBox��5.      $	
 0.6Q�6.   
������ 
�������$��0q�6h   $��1��6|   $��1��6�   $��37(�6�   $��#RockoUltraFLF)�6�   $��5��6  �� 5/   
   -	   5         ��Name$ ChatBtn��5/       � Cursor$
 Hand��6.   $��2��6|   $��7��6�   $��3��6�   6�   �� 50   
   -
   5        $ Login��50      $
 Hand��6.   $��1��6|   $��9��6�   $��5��6�   6�   53      54      