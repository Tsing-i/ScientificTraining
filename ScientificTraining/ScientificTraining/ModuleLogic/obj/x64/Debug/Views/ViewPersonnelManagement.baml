   M S B A M L   `   `   `  ����  ModuleLogic/    )ModuleLogic.Views.ViewPersonnelManagement   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      S OPrism.Wpf, Version=7.2.0.1367, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . $
��1920��5      $
��1080��6    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $/ )/Styles/ViewPersonnelManagementStyle.xaml?�6%   %    5      .��5      � ���#FFFFFF.+�5   
   � $��1��6   ���#F5F6FA � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��260 �6#   .+�5      �� -   5         ��Name$ ListView��5         ListViewStyle1#��[  5      $��
20,20,20,0q�5      ��5      ��  �� Path$ PersonCollectionView� �� View 5      �� 5        GridViewColumnHeaderStyle! �� ColumnHeaderContainerStyle# [ 6   .P�5      �� $��姓名��6)   	 �� Width$		 300��6[   
 �� DisplayMemberBinding
 65   �� *name+6[   �� 5      $��权限��6)   $		 300��6\   
 65   �� *power+6\   �� 5      $��账号��6)   $		 300��6Z   
 65   �� *usr+6Z   �� 5      $��密码��6)   $		 300��6Z   
 65   �� *pwd+6Z   �� 5      $��备注��6)   $		 420��6^   
 65   �� *	remarks+6^   5       5"      �� 5#      $��1��6   ._�5$      �� $��10,20,25,10q�6    �� CornerRadius$ 10��6.   ���#FFFFFF._�5%      �� .+�5&      �� $��0,30,0,0q�6D   $	��172��6V   $��63��6b     RefreshStyle#��[ 6n   ��6!   �� *RefreshCommand+6n   �� 5'      $��0,30,0,0q�6@   $	��172��6R   $��63��6^     AddStyle#��[ 6j   ��6!   �� *
AddCommand+6j   �� 5(      $��0,30,0,0q�6C   $	��172��6U   $��63��6a     DeleteStyle#��[ 6m   ��6!   �� *DeleteCommand+6m   5)      5*      5+      5,      5-      5.      