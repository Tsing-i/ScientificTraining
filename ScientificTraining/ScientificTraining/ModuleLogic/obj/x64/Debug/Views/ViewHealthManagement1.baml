   M S B A M L   `   `   `  ����T  PCefSharp.Wpf, Version=41.0.1.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138A0clr-namespace:CefSharp.Wpf;assembly=CefSharp.WpfCefSharp.Wpf  5       ModuleLogic-   'ModuleLogic.Views.ViewHealthManagement1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      EcefSharp0clr-namespace:CefSharp.Wpf;assembly=CefSharp.Wpf     5      S OPrism.Wpf, Version=7.2.0.1367, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . $
��1920��5      $
��1080��6    � 	Resources 5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $- '/Styles/ViewHealthManagement1Style.xaml?�6%   %    5      .��5      � ���#F5F6FA � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   � $��Right=�6   $��Center=�60   $��0,0,20,0q�6K   .+�5      �� -   5         ��Name$ useIE��5      $	��199��68   $��54��6D      IE#��[  6P   5      �� 5   
   $��70��6   $	��900��6    �� CornerRadius$ 46��6)   ���#FFFFFF._�5      �� 
���   ����#FFFFFF$��0q�5      $��24(�5      $��Center=�5      $��Center=�5      ��5      �� 5       .R�5!      �  � Orientation$ 
Horizontal=�6$    K� IsItemsHost . 6=   5"      ��5$      �� 5%      	 �� 
TargetType"	 ��6   .�5&      �� 
 �� Property
 � �� �� Value 5'      �� 5(   "    �� 
TargetType" ��62   .R�5)   &   ��  ��Name$ 	Container��61   
������  � Cursor$
 Hand��5+   -   .+�5,   *   ��  ��Name$ border��61   ���#FFFFFF$��55��6V   $	��170��6b   $ 20��6n   ._�5-   .   ��  ��Name$ contentPresenter��6?   $��Center=�5.   ;   $��Center=�5/   ;   #��z��50   ;   51   +   52   '    �� Triggers 53   &   P� 54   *    P� Property �@��
IsSelected P� Value . . �55   .   ��  �� 
TargetName$ contentPresenter��65   
 � �� �#FFFFFF6s   �� 56   .   $ border��65   
 � �� �#1DA7736_   57   +   59   #   5;      5<      .@�5>      �� -   5        $��NutritionTrends��5>   -   $��营养动态��6   6D   �� 5?      -   5        $��Nutritionknowledge��5?   -   $��营养知识��6   $��50,0,0,0q�6   �� 5@      -   5        $��NutritionMedicine��5@   -   $��营养药品��6   $��50,0,0,0q�6|   �� 5A      -   5        $��
AntiDoping��5A   -   $��反兴奋剂��6   $��50,0,0,0q�6o   5B      5C      � 5D   
   $��1��6   .+�5E      %   CefSharp.Wpf.ChromiumWebBrowser  -   5        $��Browser��5E   *   5F      5G      5H      