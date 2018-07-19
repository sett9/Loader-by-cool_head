Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace You_Clean_PC
	' Token: 0x02000016 RID: 22
	Friend Class DropDownComboBox
		Inherits ComboBox

		' Token: 0x06000139 RID: 313 RVA: 0x00009D90 File Offset: 0x00007F90
		Public Sub New()
			MyBase.DropDown += AddressOf Me.GhostComboBox_DropDown
			MyBase.DropDownClosed += AddressOf Me.GhostComboBox_DropDownClosed
			MyBase.TextChanged += AddressOf Me.GhostCombo_TextChanged
			Me.Font = New Font("Tahoma", 9F, 0)
			MyBase.SetStyle(73746, True)
			MyBase.DrawMode = 1
			MyBase.ItemHeight = 25
			MyBase.DropDownStyle = 2
		End Sub

		' Token: 0x0600013A RID: 314 RVA: 0x00009E1C File Offset: 0x0000801C
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.X = e.Location.X
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600013B RID: 315 RVA: 0x00009E4D File Offset: 0x0000804D
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.Over = True
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600013C RID: 316 RVA: 0x00009E66 File Offset: 0x00008066
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.Over = False
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600013D RID: 317 RVA: 0x00009E80 File Offset: 0x00008080
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Me.Font = New Font("Tahoma", 9F, 0)
			Dim solidBrush As SolidBrush = New SolidBrush(Me.ForeColor)
			Dim flag As Boolean = MyBase.DropDownStyle <> 2
			If flag Then
				MyBase.DropDownStyle = 2
			End If
			Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			Dim font As Font = New Font("Marlett", 11F)
			graphics.Clear(Color.FromArgb(50, 50, 50))
			Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(New Rectangle(0, 0, MyBase.Width, MyBase.Height), Color.FromArgb(234, 234, 234), Color.FromArgb(242, 242, 242), 270F)
			graphics.FillRectangle(linearGradientBrush, New Rectangle(0, 0, MyBase.Width, MyBase.Height))
			Dim pen As Pen = New Pen(Color.FromArgb(204, 204, 204), 1F)
			Dim pen2 As Pen = New Pen(Color.FromArgb(237, 237, 237), 6F)
			graphics.DrawPath(pen2, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 2))
			graphics.DrawPath(pen, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 2))
			Dim flag2 As Boolean = Me.X >= MyBase.Width - 20 And Me.Over
			If flag2 Then
				linearGradientBrush = New LinearGradientBrush(New Rectangle(0, 0, MyBase.Width, MyBase.Height), Color.FromArgb(239, 239, 239), Color.FromArgb(236, 236, 236), 90F)
				graphics.FillRectangle(linearGradientBrush, New Rectangle(MyBase.Width - 22, 2, 20, MyBase.Height - 4))
			Else
				Dim flag3 As Boolean = Me.X < MyBase.Width - 20 And Me.Over
				If flag3 Then
					linearGradientBrush = New LinearGradientBrush(New Rectangle(0, 0, MyBase.Width, MyBase.Height), Color.FromArgb(239, 239, 239), Color.FromArgb(236, 236, 236), 90F)
					graphics.FillRectangle(linearGradientBrush, New Rectangle(2, 2, MyBase.Width - 27, MyBase.Height - 4))
				End If
			End If
			Dim num As Integer = CInt(Math.Round(CDbl(graphics.MeasureString(" ... ", Me.Font).Height)))
			Dim flag4 As Boolean = Me.SelectedIndex <> -1
			If flag4 Then
				graphics.DrawString(Conversions.ToString(MyBase.Items(Me.SelectedIndex)), Me.Font, solidBrush, 4F, CSng((MyBase.Height / 2 - num / 2)))
				graphics.DrawString("6", font, solidBrush, CSng((MyBase.Width - 22)), CSng((MyBase.Height / 2 - num / 2)))
			Else
				Dim flag5 As Boolean = MyBase.Items IsNot Nothing And MyBase.Items.Count > 0
				If flag5 Then
					graphics.DrawString(Conversions.ToString(MyBase.Items(0)), Me.Font, solidBrush, 4F, CSng((MyBase.Height / 2 - num / 2)))
					graphics.DrawString("6", font, solidBrush, CSng((MyBase.Width - 22)), CSng((MyBase.Height / 2 - num / 2)))
				Else
					graphics.DrawString(" ... ", Me.Font, solidBrush, 4F, CSng((MyBase.Height / 2 - num / 2)))
					graphics.DrawString("6", font, solidBrush, CSng((MyBase.Width - 22)), CSng((MyBase.Height / 2 - num / 2)))
				End If
			End If
			graphics.DrawLine(New Pen(Color.FromArgb(120, 255, 255, 255)), 1, 1, MyBase.Width - 3, 1)
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub

		' Token: 0x0600013E RID: 318 RVA: 0x0000A2E0 File Offset: 0x000084E0
		Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
			Dim flag As Boolean = e.Index < 0
			If Not flag Then
				Dim rectangle As Rectangle = Nothing
				rectangle.X = e.Bounds.X
				rectangle.Y = e.Bounds.Y
				rectangle.Width = e.Bounds.Width - 1
				rectangle.Height = e.Bounds.Height - 1
				e.DrawBackground()
				Dim flag2 As Boolean = e.State = 785 Or e.State = 17
				If flag2 Then
					e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(235, 235, 235)), e.Bounds)
					e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(50, Me.ForeColor)), e.Bounds)
					e.Graphics.DrawString(MyBase.Items(e.Index).ToString(), e.Font, Brushes.Black, CSng(e.Bounds.X), CSng((e.Bounds.Y + 5)))
				Else
					e.Graphics.FillRectangle(New SolidBrush(Color.White), e.Bounds)
					e.Graphics.DrawString(MyBase.Items(e.Index).ToString(), e.Font, Brushes.Black, CSng(e.Bounds.X), CSng((e.Bounds.Y + 4)))
				End If
				MyBase.OnDrawItem(e)
			End If
		End Sub

		' Token: 0x0600013F RID: 319 RVA: 0x00003196 File Offset: 0x00001396
		Private Sub GhostComboBox_DropDown(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000140 RID: 320 RVA: 0x0000A49C File Offset: 0x0000869C
		Private Sub GhostComboBox_DropDownClosed(sender As Object, e As EventArgs)
			MyBase.DropDownStyle = 0
			Application.DoEvents()
			MyBase.DropDownStyle = 2
		End Sub

		' Token: 0x06000141 RID: 321 RVA: 0x0000A4B5 File Offset: 0x000086B5
		Private Sub GhostCombo_TextChanged(sender As Object, e As EventArgs)
			MyBase.Invalidate()
		End Sub

		' Token: 0x04000083 RID: 131
		Private X As Integer

		' Token: 0x04000084 RID: 132
		Private Over As Boolean
	End Class
End Namespace
