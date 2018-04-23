Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
			Dim activeControl As Control = Me.ActiveControl
			Do While TypeOf activeControl Is ContainerControl
				activeControl = (TryCast(activeControl, ContainerControl)).ActiveControl
			Loop

			If keyData = Keys.Return AndAlso (TypeOf activeControl Is TextBoxMaskBox OrElse TypeOf activeControl Is BaseEdit) Then
				Dim result As Boolean = SelectNextControl(activeControl, True, False, True, False)
				If result Then
					Return result
				End If
				Return MyBase.ProcessDialogKey(keyData)
			End If
			Return MyBase.ProcessDialogKey(keyData)
		End Function

	End Class
End Namespace
