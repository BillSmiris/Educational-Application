   M S B A M L   `   `   `  ????P  LEkpaideftikoLogismiko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:EkpaideftikoLogismikoEkpaideftikoLogismiko  5      (    "EkpaideftikoLogismiko.DetailsPanel   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:EkpaideftikoLogismiko     5      
???????$??20(?5   6   .??5	      ? ??5
   
   ?? 5        ?? ImageSource$9  3/Resources/Images/Backgrounds/DetailsBackground.jpg??6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   ?? -   5         ??Name$
 name??5      $??Sample Text??6"   $??0??65   $??0??6B   $??2??6R   $??Center=?6f   $??40(?6?   $??	0,10,0,20q?6?   ?? 5   
   -   5         ??Name$ closeButton??5      $??0??6&   $??1??63   $??Right=?6C   $	??Top=?6_   $??X??6w   $??50??6?   $??50??6?   $
??Bold"?6?   $??30(?6?   6?   ?? 5   
   -   5         ??Name$ portrait??5      $??0??6"   $??1??62   $)??#Resources/Images/People/skoufas.jpg??6?   ?? 5   
   $??1??6   $??1??6"    ?? Orientation$ Vertical=?62   .+?5      ?? $ 
Horizontal=?6   $??30,0,0,0q?62   .+?5      ?? $ Vertical=?6   .+?5      ?? $??Ημ. Γέννησης:??6    ?? 5      $"??Τόπος Γέννησης:??6    ?? 5      $??Ημ. Θανάτου:??6    ?? 5      $ ??Τόπος Θανάτου:??6    5      ?? 5       $ Vertical=?6   $??10,0,0,0q?64   .+?5!      ?? -   5        $ 	birthDate??5!      $??Ημ. Γέννησης:??6/   ?? 5"      -   5        $ 
birthPlace??5"      $"??Τόπος Γέννησης:??60   ?? 5#      -   5        $ 	deathDate??5#      $??Ημ. Θανάτου:??6/   ?? 5$      -   5        $ 
deathPlace??5$      $ ??Τόπος Θανάτου:??60   5%      5&      ,? 5'      -   5         ,?Name$ flowDocumentScrollViewer??5'   '   $	??600??6I   $??0,10,0,0q?6Y   5(      5)      5*      5+      