<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtValue = New TextBox()
        btnAdd = New Button()
        btnRemove = New Button()
        btnContains = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 0
        Label1.Text = "Number."
        ' 
        ' txtValue
        ' 
        txtValue.Location = New Point(130, 104)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(163, 23)
        txtValue.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(423, 49)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(423, 87)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(75, 23)
        btnRemove.TabIndex = 3
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnContains
        ' 
        btnContains.Location = New Point(423, 131)
        btnContains.Name = "btnContains"
        btnContains.Size = New Size(75, 23)
        btnContains.TabIndex = 4
        btnContains.Text = "Contains"
        btnContains.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(617, 297)
        Controls.Add(btnContains)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(txtValue)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnContains As Button

End Class
