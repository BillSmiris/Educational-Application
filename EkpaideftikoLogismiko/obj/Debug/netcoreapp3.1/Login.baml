   M S B A M L   `   `   `  ????P  LEkpaideftikoLogismiko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:EkpaideftikoLogismikoEkpaideftikoLogismiko  5   	   !    EkpaideftikoLogismiko.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:EkpaideftikoLogismiko     5   	   $??18(?5        ? 
ResizeMode$  NoResize=?6(    ? Title$1 +Πρόσωπα του 1821 - Σύνδεση??5   	   $	??400??6,   $	??300??69    ? WindowStartupLocation$ CenterScreen=?6E   ??5	      ?? 5
   
    ?? ImageSource$8 2Resources/Images/Backgrounds/DetailsBackground.jpg??6   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   .+?5   
   ?? $#??/Resources/Images/UI/Logo.png??6   $??0??67   $??0??6G   $??20q?6T   ?? 5   
    ?? Orientation$ Vertical=?6   $??0??6,   $??1??6<   $??10,20,10,10q?6I   .+?5      ?? $??Όνομα χρήστη??6   $??0,0,0,3q?6,   ?? 5      -   5         ??Name$ username??5      5      ?? 5   
   $ Vertical=?6   $??0??6,   $??2??6<   $??10q?6I   .+?5      ?? $??Κωδικός??6   $??0,0,0,3q?6'   G? 5      -   5         G?Name$ password??5      5      ?? 5    
   -   5        	 ??Name$	 loginButton??5       $??Σύνδεση??6&   $??0??68   $??3??6H   $??Center=?6U   $??0,30,0,0q?6?   
 ? Cursor$

 Hand??6?   5!      5"      