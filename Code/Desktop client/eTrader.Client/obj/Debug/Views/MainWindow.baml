   M S B A M L   `   `   `  ����I  EeTrader.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:eTrader.Client.ViewModelseTrader.Client.ViewModels  5   	   /clr-namespace:eTrader.ClienteTrader.Client  5   	   %    eTrader.Client.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >
viewModels'clr-namespace:eTrader.Client.ViewModels     5   	   .localclr-namespace:eTrader.Client     5   	     � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)   .��5      � .+�5   
   �� $
��Left=�6   .+�5      �� .��6   
Username6   �� 5      $	��150��6   ��6"   �� *
Username+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=��� 5      .��6   
Password6   G� 5      #   eTrader.Client.PasswordHelper   Attach . $	��150��6�      Password 6=   �� *
Password+ �� Mode$ TwoWay=� . $ PropertyChanged=�6�   �� 5      ��6   �� *LoginCommand+.��66   Login6=   5      5      5      