   M S B A M L   `   `   `  ����R  NTalMiniProject - Chatty, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TalMiniProject___ChattyTalMiniProject___Chatty  5   	   (    "TalMiniProject___Chatty.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:TalMiniProject___Chatty     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Title$ 
MainWindow��5   	   $
��1080��6   $
��1920��6*   .��5      � -   5         �Name$ gridi��5       � RowDefinitions 5   
   �� 5      $
��496* �6   �� 5      $	��54* �6   �� 5      $	��43* �6   �� 5      $	��54* �6   �� 5      $	��49* �6   �� 5      $	��70* �6   �� 5      $
��162* �6   �� 5      $	��90* �6   �� 5      $	��62* �6    � ColumnDefinitions 5   
   �� 5      $
��732* �6   �� 5      $
��132* �6   �� 5      $
��172* �6   �� 5      $
��151* �6   �� 5      $
��733* �6   ��5    
   �� 5!       �� ImageSource$ Images\SignIn\SignIn.png��6   .+�5$   
   �� -   5         ��Name$ UserBack��5$      ���	#FF0C1521$��1��67   $y�Hidden=�6D   $��1��6X   $��3��6h   �� 5%   
   -   5        $ PassBack��5%      ���	#FF0C1521$��3��67   $y�Hidden=�6E   $��1��6Y   $��3��6i   G� 5'   
   -   5        	 G�Name$	 PassBox��5'      
 J� Opacity$	
 0.6Q�6/   
������ 
�������$��0q�6i   $��1��6}   $��3��6�   $��37(�6�   $��#RockoUltraFLF)�6�    G� Password$  ��6�   $��4��6  �� 5(   
   -   5         ��Name$ UserBox��5(      $	
 0.6Q�6/   
������ 
�������$��0q�6i   $��1��6}   $��1��6�   $��37(�6�   $��#RockoUltraFLF)�6�   $��4��6  �� 5)   
   -   5         ��Name$ ChatBtn��5)       � Cursor$
 Hand��6/   $��2��6}   $��5��6�   6�   �� 5*   
   -   5        $ SignUp��5*      $
 Hand��6/   $��1��6}   $��7��6�   $��3��6�   6�   r� 5+   
   -	   5         r�Name$ Media��5+       r� Source$ Images\SignIn\wp4.mp4?�6(   $��5��6G   $��9��6[    r� LoadedBehavior$ Manual=�6l   6�   5-      5.      