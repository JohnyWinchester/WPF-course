   M S B A M L   `   `   `  ????L  HAndreyMatveewDZ01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AndreyMatveewDZ01.ViewAndreyMatveewDZ01.View  5   	   +    %AndreyMatveewDZ01.View.SmtpSaveWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:AndreyMatveewDZ01.View     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     ? Title$  	Save Smtp??5   	   $	??220??6   $	??250??6(      MaterialDesignBody#???   5
   	   $??Regular"?5   	   $??13(?5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   	      TextRenderingMode$
 Auto=?5   	     MaterialDesignPaper#???  5   	     MaterialDesignFont#???  5   	    ? DataContext 5   	   ?? *
SmtpSaveVM+  Locator ?? Source# [ .??5      ? $??0,20,0,0q?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6    ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??1??6   $??1??6   $??Сохранить SMTP??6-   $??16(?6F   ?? 5!   
   $??2??6   $
??Wrap=?6!   $??Name:??65      MaterialDesignBody1TextBlock#??[ 6B   $??14(?6x   $??5,0,0,0q?6?   ?? 5"   
   $??3??6   $
??Wrap=?6!   $??Address??65   #??[ 6D   $??14(?6z   $??5,0,0,0q?6?   ?? 5$   
   $??1??6   $??2??6"    ?? TextWrapping$
 Wrap=?6/   $??90??6C   ??6N   ??  ?? Path$
 Name?	 ?? Mode$	 TwoWay=?
 ?? UpdateSourceTrigger$
 PropertyChanged=??? 5%   
   $??1??6   $??3??6"   $
 Wrap=?6/   $??90??6C   ??6N   ?? $ Address?$	 TwoWay=?$
 PropertyChanged=??? 5'   
   $??Сохранить??6   $
??Bold"?5(      $??5??6#   $??2??5)       ? ToolTip$) #Сохранить новый email??5*      $??32??5+   5   $	??151??6A   $??14(?6M   $??Center=?6[   $??20,20,-7.132,-38.189q?6x   ??6   ?? *SaveSmtpCommand+6x   5,      5-      