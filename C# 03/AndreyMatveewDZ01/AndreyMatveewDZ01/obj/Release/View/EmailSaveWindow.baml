   M S B A M L   `   `   `  ???? L  HAndreyMatveewDZ01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AndreyMatveewDZ01.ViewAndreyMatveewDZ01.View  ,    &AndreyMatveewDZ01.View.EmailSaveWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:AndreyMatveewDZ01.View     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    ? Title$  
SaveWindow??   MaterialDesignBody#???   $??Regular"?$??13(?&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?   TextRenderingMode$
 Auto=?  MaterialDesignPaper#???    MaterialDesignFont#???  $	??219??$??252.524?? ? DataContext ?? *EmailSaveVM+  Locator ?? Source# [ .??? $??0,20,0,0q? ? RowDefinitions ?? $
??Auto ??? $
??Auto ??? $
??Auto ??? $
??Auto ??? $
??Auto ??? $
??Auto ??? $
??Auto ??? $
??Auto ??? $
??Auto ? ? ColumnDefinitions ?? $
??Auto ??? $
??Auto ?.+??? $??1??$??2??$??Добавить??$??16(??? $??3??$
??Wrap=?$??Email:??   MaterialDesignBody1TextBlock#??[ $??14(?$??5,0,0,0q??? $??4??$
??Wrap=?$??Name:??#??[ $??14(?$??5,0,0,0q??? $??5??$
??Wrap=?$??	Password:??#??[ $??14(?$??5,0,0,0q??? $??6??$
??Wrap=?$??Smtp:??#??[ $??14(?$??5,0,0,0q??? $??3??$??2?? ?? TextWrapping$
 Wrap=?$??90?????? *	Address+ ?? Mode$ TwoWay=??? $??1??$??4??$
 Wrap=?$??90?????? *Name+$ TwoWay=??? $??1??$??5??$
 Wrap=?$??90?????? *
Password+$ TwoWay=??? -   	 ??Name$	 cbSmtp??$??1??$??6??$??90?????? *Smtps+$ TwoWay=??? $??Сохранить??$
??Bold"?$??9??$??2??
 ? ToolTip$)
 #Сохранить новый email??$??32??$	??151??$??14(?$??Center=?$??20,20,-7.132,-38.189q????? *SaveEmailCommand+????  ?? ElementName$ cbSmtp?? ?? Path$ SelectedItem?