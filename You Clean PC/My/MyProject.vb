Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace You_Clean_PC.My
	' Token: 0x02000004 RID: 4
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000210C File Offset: 0x0000030C
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x00002128 File Offset: 0x00000328
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002144 File Offset: 0x00000344
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002160 File Offset: 0x00000360
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000217C File Offset: 0x0000037C
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000001 RID: 1
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000002 RID: 2
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000003 RID: 3
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000004 RID: 4
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000005 RID: 5
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x02000017 RID: 23
		<EditorBrowsable(1)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			' Token: 0x06000142 RID: 322 RVA: 0x0000A4C0 File Offset: 0x000086C0
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim flag As Boolean = Instance Is Nothing OrElse Instance.IsDisposed
				If flag Then
					Dim flag2 As Boolean = MyProject.MyForms.m_FormBeingCreated IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))
						If flag3 Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return Instance
			End Function

			' Token: 0x06000143 RID: 323 RVA: 0x0000A5E8 File Offset: 0x000087E8
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x06000144 RID: 324 RVA: 0x0000A5FF File Offset: 0x000087FF
			<DebuggerHidden()>
			<EditorBrowsable(1)>
			Public Sub New()
			End Sub

			' Token: 0x06000145 RID: 325 RVA: 0x0000A60C File Offset: 0x0000880C
			<EditorBrowsable(1)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000146 RID: 326 RVA: 0x0000A62C File Offset: 0x0000882C
			<EditorBrowsable(1)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000147 RID: 327 RVA: 0x0000A644 File Offset: 0x00008844
			<EditorBrowsable(1)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x06000148 RID: 328 RVA: 0x0000A660 File Offset: 0x00008860
			<EditorBrowsable(1)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x17000065 RID: 101
			' (get) Token: 0x06000149 RID: 329 RVA: 0x0000A678 File Offset: 0x00008878
			' (set) Token: 0x0600014A RID: 330 RVA: 0x0000A693 File Offset: 0x00008893
			Public Property Form1 As Form1
				<DebuggerHidden()>
				Get
					Me.m_Form1 = MyProject.MyForms.Create__Instance__(Of Form1)(Me.m_Form1)
					Return Me.m_Form1
				End Get
				<DebuggerHidden()>
				Set(value As Form1)
					If value IsNot Me.m_Form1 Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form1)(Me.m_Form1)
					End If
				End Set
			End Property

			' Token: 0x04000085 RID: 133
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable

			' Token: 0x04000086 RID: 134
			<EditorBrowsable(1)>
			Public m_Form1 As Form1
		End Class

		' Token: 0x02000018 RID: 24
		<EditorBrowsable(1)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			' Token: 0x0600014B RID: 331 RVA: 0x0000A6C0 File Offset: 0x000088C0
			<EditorBrowsable(1)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x0600014C RID: 332 RVA: 0x0000A6E0 File Offset: 0x000088E0
			<EditorBrowsable(1)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600014D RID: 333 RVA: 0x0000A6F8 File Offset: 0x000088F8
			<EditorBrowsable(1)>
			<DebuggerHidden()>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x0600014E RID: 334 RVA: 0x0000A714 File Offset: 0x00008914
			<EditorBrowsable(1)>
			<DebuggerHidden()>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x0600014F RID: 335 RVA: 0x0000A72C File Offset: 0x0000892C
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim flag As Boolean = instance Is Nothing
				Dim result As T
				If flag Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

			' Token: 0x06000150 RID: 336 RVA: 0x0000A755 File Offset: 0x00008955
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x06000151 RID: 337 RVA: 0x0000A5FF File Offset: 0x000087FF
			<DebuggerHidden()>
			<EditorBrowsable(1)>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000019 RID: 25
		<EditorBrowsable(1)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x17000066 RID: 102
			' (get) Token: 0x06000152 RID: 338 RVA: 0x0000A760 File Offset: 0x00008960
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					Dim flag As Boolean = MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing
					If flag Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x06000153 RID: 339 RVA: 0x0000A5FF File Offset: 0x000087FF
			<DebuggerHidden()>
			<EditorBrowsable(1)>
			Public Sub New()
			End Sub

			' Token: 0x04000087 RID: 135
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
