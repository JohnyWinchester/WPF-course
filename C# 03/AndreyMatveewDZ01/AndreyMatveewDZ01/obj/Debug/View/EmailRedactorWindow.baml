   M S B A M L   `   `   `  ????L  HAndreyMatveewDZ01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AndreyMatveewDZ01.ViewAndreyMatveewDZ01.View  5   	   0    *AndreyMatveewDZ01.View.EmailRedactorWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:AndreyMatveewDZ01.View     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          ?Name$  redactorWindow??5   	    ? Title$ Email Redactor??5   	   $	??290??6    $	??300??6-      MaterialDesignBody#???   5
   	   $??Regular"?5   	   $??13(?5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   	      TextRenderingMode$
 Auto=?5   	     MaterialDesignPaper#???  5   	     MaterialDesignFont#???  5   	    ? DataContext 5   	   ?? *EmailRedactorVM+  Locator ?? Source# [ .??5      ? $??0,20,0,0q?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6    ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5       $
??Auto ?6   ?? 5!      $
??Auto ?6   .+?5#   
   ?? $??1??6   $??1??6   $+??%Редактировать Емейл??6-   $??16(?6K   ?? 5%   
   $??3??6   $
??Wrap=?6!   $??Email:??65      MaterialDesignBody1TextBlock#??[ 6C   $??14(?6y   $??5,0,0,0q?6?   ?? 5&   
   $??4??6   $
??Wrap=?6!   $??Name:??65   #??[ 6B   $??14(?6x   $??5,0,0,0q?6?   ?? 5'   
   $??5??6   $
??Wrap=?6!   $??	Password:??65   #??[ 6F   $??14(?6|   $??5,0,0,0q?6?   ?? 5)   
   $??3??6   $??1??6    ?? TextWrapping$
 Wrap=?6/   $??90??6C   ??6N   ?? 	 ?? Path$	 Address?
 ?? Mode$
 TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=??? 5*   
   $??1??6   $??4??6"   $
 Wrap=?6/   $??90??6C   ??6N   ?? $
	 Name?$
 TwoWay=?$ PropertyChanged=??? 5+   
   $??1??6   $??5??6"   $
 Wrap=?6/   $??90??6C   ??6N   ?? $	 Password?$
 OneWayToSource=?$ PropertyChanged=??? 5-   
   $??Сохранить??6   $
??Bold"?5.      $??9??6#   $??2??5/       ? ToolTip$) #Сохранить новый email??50      $??32??51   8   $	??151??6D   $??14(?6P   $??Center=?6^   $??20,20,-7.132,-38.189q?6{   ??6   ?? *UpdateEmailCommand+6{   52      53      