   M S B A M L   `   `   `  ����N  JSecureMessengerDNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SecureMessengerDNetSecureMessengerDNet  5   	   $    SecureMessengerDNet.NewContact   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:SecureMessengerDNet     5   	     � Title$  	NewPlayer��5   	   $	��600��6   $	��800��6(   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   (� $��Right=�6   $��Center=�6.   $��2��6I   .��5      �� $��New Contact��6   $��5q�6+   $	��104��66    J� RenderTransformOrigin$ 
1.17,0.735&�6B   5      (� 5   
   $
��Left=�6   $��Center=�6-   $��0��6H   $��1��6X   .��5      �� $��UserName��6   $��5q�6(   5      �� 5   
   $��1��6   $��1��6"   $��18q�6/   6=   (� 5    
   $
��Left=�6   $��Center=�6-   $��0��6H   $��2��6X   .��5!      �� $��Password��6   $��5q�6(   5"      �� 5#   
   $��1��6   $��2��6"   $��18q�6/   6=   (� 5%   
   $��Right=�6   $��Center=�6.   $��0��6I   $��3��6Y   �� 5&   
   $��1��6   $��3��6!   $��390,30,30,30q�6.   ��6D   �� *SendMessageCommand+.��6k   Add6p   5)      5*      