   M S B A M L   `   `   `  ����N  JSecureMessengerDNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SecureMessengerDNetSecureMessengerDNet  5   	   !    SecureMessengerDNet.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:SecureMessengerDNet     5   	     � Title$  Window1��5   	   $��600         ��6   $	��800��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   �� 5      $��8* �6   6,    � RowDefinitions 5   
   �� 5      $��9* �6   6*   �� 5      $��1* �6   6*   .+�5   
   �� -   5        $��ContactList��5   �   $��0��6   $��2��6"   $��0��66   ��6C   �� *	Persons+ �� SelectedItem 6c   �� *SelectedContact+��5      �� 5      .R�5      �� $
��Wrap=�6:   ��6    �� *
Nickname+6:   5      5      �� 5    
   $��0��6   $��1��6!   $
��5,15q�6.   ��6<   �� *OpenNewContactCommand+.��6f   +6i   �� 5!   
   $��1��6   $��1��6!   $
��5,15q�6.   ��6<   �� *DeleteContactCommand+.��6e   -6h   �� 5#   
   -   5        $��ListMessages��5#   X   $��2��6   $��0��6"   ��6/   �� *SelectedMessages+��5$      �� 5%      .R�5&      �  5'      �� 5(      �� 5)       5,      �� 5-      .+�50      �� $��0��6:   $��DemiBold"�6G   ��6$   �� *Date+6G   �� 51      $��1��6=   $
��Wrap=�6J   ��6$   �� *	Content+6J   52      53      55      � 57   
   $��2��6   $��1��6    59      �� 5:      $��8* �6#   �� 5;      $��2* �6#    5>      �� 5?      .+�5B      �� -   5        $��
MessageBox��5B   A   $��0��6   $��0��6&   $
��5,15q�63   ��6S   �� *MessageText+6r   �� 5C      $��1��6   $��0��6%   $
��5,15q�62   ��6@   �� *SendMessageCommand+.��6g   Send6m   5E      �� 5F   
   $
��Left=�6   $	��100��62   $��-142,397,0,0q�6?   $	��Top=�6U   $��5��6m   5H      5I      