Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.CompilerServices

Namespace You_Clean_PC
	' Token: 0x0200000A RID: 10
	Friend NotInheritable Module Draw
		' Token: 0x060000CC RID: 204 RVA: 0x000073E0 File Offset: 0x000055E0
		Public Function RoundRect(Rectangle As Rectangle, Curve As Integer) As GraphicsPath
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim num As Integer = Curve * 2
			graphicsPath.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, num, num), -180F, 90F)
			graphicsPath.AddArc(New Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Y, num, num), -90F, 90F)
			graphicsPath.AddArc(New Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num), 0F, 90F)
			graphicsPath.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num), 90F, 90F)
			graphicsPath.AddLine(New Point(Rectangle.X, Rectangle.Height - num + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
			Return graphicsPath
		End Function
	End Module
End Namespace
