   M S B A M L   `   `   `  ????L  HAndreyMatveewDZ01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AndreyMatveewDZ01.ViewAndreyMatveewDZ01.View  5   	   W0clr-namespace:AndreyMatveewDZ01.Model.Validation"AndreyMatveewDZ01.Model.Validation  5   	   ,    &AndreyMatveewDZ01.View.EmailSaveWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:AndreyMatveewDZ01.View     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   A
Validation0clr-namespace:AndreyMatveewDZ01.Model.Validation  5   	     ? Title$  
SaveWindow??5   	      MaterialDesignBody#???   5
   	   $??Regular"?5   	   $??13(?5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   	      TextRenderingMode$
 Auto=?5   	     MaterialDesignPaper#???  5   	     MaterialDesignFont#???  5   	   $	??300??5   N   $	??290??6Z    ? DataContext 6	   ?? *EmailSaveVM+  Locator ?? Source# [ .??5      ? $??0,20,0,0q?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6    ? ColumnDefinitions 5   
   ?? 5       $
??Auto ?6   ?? 5!      $
??Auto ?6   .+?5#   
   ?? $??1??6   $??2??6   $!??Добавить емейл??6-   $??16(?6F   ?? 5%   
   $??3??6   $
??Wrap=?6!   $??Email:??65      MaterialDesignBody1TextBlock#??[ 6C   $??14(?6y   $??5,0,0,0q?6?   ?? 5&   
   $??4??6   $
??Wrap=?6!   $??Name:??65   #??[ 6B   $??14(?6x   $??5,0,0,0q?6?   ?? 5'   
   $??5??6   $
??Wrap=?6!   $??	Password:??65   #??[ 6F   $??14(?6|   $??5,0,0,0q?6?   ?? 5(   
   $??6??6   $
??Wrap=?6!   $??Smtp:??65   #??[ 6B   $??14(?6x   $??5,0,0,0q?6?   ?? 5*   
   $??3??6   $??2??6    ?? TextWrapping$
 Wrap=?6/   $??90??6C   .??6O   ??5+      ?? 5,       ?? Path$ Address?6   	 ?? UpdateSourceTrigger$	 PropertyChanged=?5-      
 ?? Mode$
 TwoWay=?5.       ?? ValidationRules 5/      8   2AndreyMatveewDZ01.Model.Validation.EmailValidation  50      52      .??53      54      ?? 55   
   $??1??6   $??4??6"   $
 Wrap=?6/   $??90??6C   .??6N   ??56      ?? 57      $
 Name?6   $	 PropertyChanged=?58      $
 TwoWay=?59       5:      8   2AndreyMatveewDZ01.Model.Validation.LoginValidation  5;      5=      .??5>      5?      ?? 5@   
   $??1??6   $??5??6"   $
 Wrap=?6/   $??90??6C   .??6N   ??5A      ?? 5B      $ Password?6   $	 PropertyChanged=?5C      $
 TwoWay=?5D       5E      ;   5AndreyMatveewDZ01.Model.Validation.PasswordValidation  5F      5H      .??5I      5J      ?? 5L   
   -   5         ??Name$ cbSmtp??5L      $??1??6#   $??6??63   $??90??6@   ??6K   ?? *Smtps+$
 TwoWay=?5N      ?? 5O   
   $??Сохранить??6   $
??Bold"?5P      $??9??6#   $??2??5Q       ? ToolTip$) #Сохранить новый email??5R      $??32??5S   x   $	??151??6?   $??14(?6?   $??Center=?6?   $??20,20,-7.132,-38.189q?6?   ??6   ?? *SaveEmailCommand+??66   ??  ?? ElementName$ cbSmtp??$ SelectedItem?6?   5T      5U      