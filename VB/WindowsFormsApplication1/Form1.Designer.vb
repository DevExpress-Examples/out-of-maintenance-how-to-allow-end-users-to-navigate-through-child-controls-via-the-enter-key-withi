Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.wizardControl1 = New DevExpress.XtraWizard.WizardControl()
			Me.welcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
			Me.buttonEdit4 = New DevExpress.XtraEditors.ButtonEdit()
			Me.buttonEdit3 = New DevExpress.XtraEditors.ButtonEdit()
			Me.buttonEdit2 = New DevExpress.XtraEditors.ButtonEdit()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.wizardPage1 = New DevExpress.XtraWizard.WizardPage()
			Me.completionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
			CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.wizardControl1.SuspendLayout()
			Me.welcomeWizardPage1.SuspendLayout()
			CType(Me.buttonEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' wizardControl1
			' 
			Me.wizardControl1.Controls.Add(Me.welcomeWizardPage1)
			Me.wizardControl1.Controls.Add(Me.wizardPage1)
			Me.wizardControl1.Controls.Add(Me.completionWizardPage1)
			Me.wizardControl1.Name = "wizardControl1"
			Me.wizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() { Me.welcomeWizardPage1, Me.wizardPage1, Me.completionWizardPage1})
			' 
			' welcomeWizardPage1
			' 
			Me.welcomeWizardPage1.Controls.Add(Me.buttonEdit4)
			Me.welcomeWizardPage1.Controls.Add(Me.buttonEdit3)
			Me.welcomeWizardPage1.Controls.Add(Me.buttonEdit2)
			Me.welcomeWizardPage1.Controls.Add(Me.buttonEdit1)
			Me.welcomeWizardPage1.Name = "welcomeWizardPage1"
			Me.welcomeWizardPage1.Size = New System.Drawing.Size(624, 443)
			' 
			' buttonEdit4
			' 
			Me.buttonEdit4.EnterMoveNextControl = True
			Me.buttonEdit4.Location = New System.Drawing.Point(197, 64)
			Me.buttonEdit4.Name = "buttonEdit4"
			Me.buttonEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit4.Size = New System.Drawing.Size(100, 20)
			Me.buttonEdit4.TabIndex = 3
			' 
			' buttonEdit3
			' 
			Me.buttonEdit3.EnterMoveNextControl = True
			Me.buttonEdit3.Location = New System.Drawing.Point(197, 151)
			Me.buttonEdit3.Name = "buttonEdit3"
			Me.buttonEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit3.Size = New System.Drawing.Size(100, 20)
			Me.buttonEdit3.TabIndex = 2
			' 
			' buttonEdit2
			' 
			Me.buttonEdit2.EnterMoveNextControl = True
			Me.buttonEdit2.Location = New System.Drawing.Point(57, 151)
			Me.buttonEdit2.Name = "buttonEdit2"
			Me.buttonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit2.Size = New System.Drawing.Size(100, 20)
			Me.buttonEdit2.TabIndex = 1
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.EnterMoveNextControl = True
			Me.buttonEdit1.Location = New System.Drawing.Point(57, 64)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(100, 20)
			Me.buttonEdit1.TabIndex = 0
			' 
			' wizardPage1
			' 
			Me.wizardPage1.Name = "wizardPage1"
			Me.wizardPage1.Size = New System.Drawing.Size(809, 431)
			' 
			' completionWizardPage1
			' 
			Me.completionWizardPage1.Name = "completionWizardPage1"
			Me.completionWizardPage1.Size = New System.Drawing.Size(624, 443)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(841, 576)
			Me.Controls.Add(Me.wizardControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.wizardControl1.ResumeLayout(False)
			Me.welcomeWizardPage1.ResumeLayout(False)
			CType(Me.buttonEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private wizardControl1 As DevExpress.XtraWizard.WizardControl
		Private welcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
		Private wizardPage1 As DevExpress.XtraWizard.WizardPage
		Private completionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
		Private buttonEdit4 As DevExpress.XtraEditors.ButtonEdit
		Private buttonEdit3 As DevExpress.XtraEditors.ButtonEdit
		Private buttonEdit2 As DevExpress.XtraEditors.ButtonEdit
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
	End Class
End Namespace

