Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace You_Clean_PC
	' Token: 0x02000015 RID: 21
	Friend Class ProgressBar
		Inherits ThemeControl

		' Token: 0x17000061 RID: 97
		' (get) Token: 0x0600012E RID: 302 RVA: 0x00009594 File Offset: 0x00007794
		' (set) Token: 0x0600012F RID: 303 RVA: 0x000095AC File Offset: 0x000077AC
		Public Property VerticalAlignment As Boolean
			Get
				Return Me.Vertical
			End Get
			Set(value As Boolean)
				Me.Vertical = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x17000062 RID: 98
		' (get) Token: 0x06000130 RID: 304 RVA: 0x000095C0 File Offset: 0x000077C0
		' (set) Token: 0x06000131 RID: 305 RVA: 0x000095D8 File Offset: 0x000077D8
		Public Property Glossy As Boolean
			Get
				Return Me.Gloss
			End Get
			Set(value As Boolean)
				Me.Gloss = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x17000063 RID: 99
		' (get) Token: 0x06000132 RID: 306 RVA: 0x000095EC File Offset: 0x000077EC
		' (set) Token: 0x06000133 RID: 307 RVA: 0x00009604 File Offset: 0x00007804
		Public Property Maximum As Integer
			Get
				Return Me._Maximum
			End Get
			Set(value As Integer)
				Dim flag As Boolean = value < Me._Value
				If flag Then
					Me._Value = value
				End If
				Me._Maximum = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x17000064 RID: 100
		' (get) Token: 0x06000134 RID: 308 RVA: 0x00009638 File Offset: 0x00007838
		' (set) Token: 0x06000135 RID: 309 RVA: 0x00009650 File Offset: 0x00007850
		Public Property Value As Integer
			Get
				Return Me._Value
			End Get
			Set(value As Integer)
				Dim num As Integer = value
				Dim flag As Boolean = num > Me._Maximum
				If flag Then
					value = Me._Maximum
				End If
				Me._Value = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x06000136 RID: 310 RVA: 0x00009688 File Offset: 0x00007888
		Public Overrides Sub PaintHook()
			Me.G.SmoothingMode = 2
			Me.G.Clear(Color.Transparent)
			Dim pen As Pen = New Pen(Color.FromArgb(34, 112, 171), 1F)
			Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(31, 119, 181), Color.FromArgb(33, 128, 206), 1)
			Me.G.FillPath(linearGradientBrush, Draw.RoundRect(MyBase.ClientRectangle, 4))
			Me.G.DrawPath(pen, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 3))
			Me.G.DrawLine(New Pen(Color.FromArgb(65, 131, 197, 241)), 2, 1, MyBase.Width - 3, 1)
			Dim flag As Boolean = Me._Value > 1
			If flag Then
				Dim vertical As Boolean = Me.Vertical
				If vertical Then
					' The following expression was wrapped in a unchecked-expression
					Dim num As Integer = MyBase.Height - CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Height)))
					Dim glossy As Boolean = Me.Glossy
					If glossy Then
						Dim pen2 As Pen = New Pen(Color.FromArgb(34, 112, 171), 1F)
						Dim linearGradientBrush2 As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), 1)
						Me.G.FillPath(linearGradientBrush2, Draw.RoundRect(New Rectangle(2, num + 3, MyBase.Width - 5, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Height))) - 6), 4))
						MyBase.DrawGradient(Color.FromArgb(50, Color.White), Color.Transparent, 4, num + 3, 10, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Height))) - 7, 270F)
						Me.G.DrawPath(pen2, Draw.RoundRect(New Rectangle(2, num + 3, MyBase.Width - 5, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Height))) - 6), 3))
						Me.G.DrawLine(New Pen(Color.FromArgb(90, 131, 197, 241)), 4, num + 4, MyBase.Width - 6, num + 4)
					Else
						Dim flag2 As Boolean = Not Me.Glossy
						If flag2 Then
							Dim pen3 As Pen = New Pen(Color.FromArgb(34, 112, 171), 1F)
							Dim linearGradientBrush3 As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), 1)
							Me.G.FillPath(linearGradientBrush3, Draw.RoundRect(New Rectangle(2, num + 3, MyBase.Width - 5, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Height))) - 6), 4))
							Me.G.DrawPath(pen3, Draw.RoundRect(New Rectangle(2, num + 3, MyBase.Width - 5, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Height))) - 6), 3))
							Me.G.DrawLine(New Pen(Color.FromArgb(90, 131, 197, 241)), 4, num + 4, MyBase.Width - 6, num + 4)
						End If
					End If
				Else
					Dim flag3 As Boolean = Not Me.Vertical
					If flag3 Then
						' The following expression was wrapped in a unchecked-expression
						Dim num As Integer = MyBase.Height - CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Width)))
						Dim glossy2 As Boolean = Me.Glossy
						If glossy2 Then
							Dim pen4 As Pen = New Pen(Color.FromArgb(34, 112, 171), 1F)
							Dim linearGradientBrush4 As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), 1)
							Me.G.FillPath(linearGradientBrush4, Draw.RoundRect(New Rectangle(2, 2, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Width))) - 6, MyBase.Height - 5), 4))
							Me.G.DrawLine(New Pen(Color.FromArgb(90, 131, 197, 241)), 4, 3, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Width))) - 7, 3)
							MyBase.DrawGradient(Color.FromArgb(60, Color.White), Color.Transparent, 3, 3, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Width))) - 7, CInt(Math.Round(CDbl(MyBase.Height) / 2.0 - 3.0)), 0F)
							Me.G.DrawPath(pen4, Draw.RoundRect(New Rectangle(2, 2, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Width))) - 6, MyBase.Height - 5), 3))
						Else
							Dim flag4 As Boolean = Not Me.Glossy
							If flag4 Then
								Dim pen5 As Pen = New Pen(Color.FromArgb(34, 112, 171), 1F)
								Dim linearGradientBrush5 As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), 1)
								Me.G.FillPath(linearGradientBrush5, Draw.RoundRect(New Rectangle(2, 2, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Width))) - 6, MyBase.Height - 5), 4))
								Me.G.DrawLine(New Pen(Color.FromArgb(90, 131, 197, 241)), 4, 3, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Width))) - 7, 3)
								Me.G.DrawPath(pen5, Draw.RoundRect(New Rectangle(2, 2, CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Width))) - 6, MyBase.Height - 5), 3))
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000137 RID: 311 RVA: 0x00009D24 File Offset: 0x00007F24
		Public Sub Increment(Amount As Integer)
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean = Me.Value + Amount > Me.Maximum
			If flag Then
				Me.Value = Me.Maximum
			Else
				Me.Value += Amount
			End If
		End Sub

		' Token: 0x06000138 RID: 312 RVA: 0x00009D67 File Offset: 0x00007F67
		Public Sub New()
			Me.Vertical = True
			Me.Value = 0
			Me.Maximum = 100
			MyBase.AllowTransparent()
		End Sub

		' Token: 0x0400007F RID: 127
		Private _Maximum As Integer

		' Token: 0x04000080 RID: 128
		Private Gloss As Boolean

		' Token: 0x04000081 RID: 129
		Private Vertical As Boolean

		' Token: 0x04000082 RID: 130
		Private _Value As Integer
	End Class
End Namespace
