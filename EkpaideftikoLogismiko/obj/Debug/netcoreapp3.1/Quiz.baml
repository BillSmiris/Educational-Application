   M S B A M L   `   `   `  ????P  LEkpaideftikoLogismiko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:EkpaideftikoLogismikoEkpaideftikoLogismiko  5           EkpaideftikoLogismiko.Quiz   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:EkpaideftikoLogismiko     5      $??20(?5      
???????  ? 	Resources  5	       ?? Source?? 5
   
   $< 6/EkpaideftikoLogismiko;component/Resources/Styles.xaml??6   %    .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   .+?5   
   ?? -   5         ??Name$ title??5      $??0??6#   $??0??60   $??Center=?6@   $??Center=?6]   $??40(?6x   $
??Bold"?6?   ?? 5   
   -   5        $ questionTimer??5      $??0??6+   $??1??6;   $??Center=?6H   $??Center=?6e   $??32(?6?   ?? 5   
   -   5         ??Name$ questionPanel??5       ?? Orientation$ Vertical=?6,   $??2??6C   $??0??6P   $??20,0,0,0q?6`   .+?5      ?? -   5        $ question??5      $??24(?6*   $??0,0,0,10q?68   	? 5      -   5         	?Name$ answer1??5       	? 	GroupName$ answer??6+   	 ? Cursor$
	 Hand??6W   $??Center=?6f   $
??Left=?6?   $??0,0,0,10q?6?   	? 5      -   5        $ answer2??5      $ answer??6+   $
	 Hand??6W   $
??Left=?6e   $??Center=?6?   $??0,0,0,10q?6?   	? 5      -   5        $ answer3??5      $ answer??6+   $
	 Hand??6W   $??Center=?6e   $
??Left=?6?   $??0,0,0,10q?6?   	? 5      -   5        $ answer4??5      $ answer??6+   $
	 Hand??6W   $
??Left=?6e   $??Center=?6?   $??0,0,0,10q?6?   ?? 5      -	   5        
 ??Name$
 answerButton??5         
MenuButton#??[  6+   $??Απάντηση??6O   ${?False??6b   6t   5       ?? 5!   
   -
   5        $ endPanel??5!      $ Vertical=?6'   $??2??6>   $??0??6K   $??Center=?6[   $y?	Collapsed=?6y   .+?5"      ?? -   5        $ grade??5"      $??0??6'   $??2??67   $??24(?6D   ?? 5#      -   5        $
 restartButton??5#      #??[  6,   $??Επανεκκίνιση??6P   6g   5$      ?? 5%   
   -   5        $
 
backButton??5%      #??[  6%   $??3??6I   $??0??6V   $
??Left=?6f   $??Bottom=?6?   $??Πίσω??6?   6?   5&      5'      