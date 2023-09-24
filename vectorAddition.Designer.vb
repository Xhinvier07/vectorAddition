<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vectorAddition
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
        vector = New Label()
        Label1 = New Label()
        vectorForm = New ComboBox()
        Label2 = New Label()
        sigFig = New ComboBox()
        Label3 = New Label()
        numVector = New ComboBox()
        proceed = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' vector
        ' 
        vector.AutoSize = True
        vector.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        vector.ImageAlign = ContentAlignment.TopCenter
        vector.Location = New Point(74, 28)
        vector.Name = "vector"
        vector.Size = New Size(281, 41)
        vector.TabIndex = 0
        vector.Text = "Vector Addition"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 20)
        Label1.TabIndex = 1
        Label1.Text = "Vector Form:"
        ' 
        ' vectorForm
        ' 
        vectorForm.DropDownStyle = ComboBoxStyle.DropDownList
        vectorForm.FormattingEnabled = True
        vectorForm.Items.AddRange(New Object() {"Polar Form", "Coordinate Form"})
        vectorForm.Location = New Point(204, 115)
        vectorForm.Name = "vectorForm"
        vectorForm.Size = New Size(151, 28)
        vectorForm.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 20)
        Label2.TabIndex = 3
        Label2.Text = "Significant Figures:"
        ' 
        ' sigFig
        ' 
        sigFig.DropDownStyle = ComboBoxStyle.DropDownList
        sigFig.FormattingEnabled = True
        sigFig.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        sigFig.Location = New Point(204, 160)
        sigFig.Name = "sigFig"
        sigFig.Size = New Size(151, 28)
        sigFig.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 20)
        Label3.TabIndex = 5
        Label3.Text = "Number of Vectors:"
        ' 
        ' numVector
        ' 
        numVector.DropDownStyle = ComboBoxStyle.DropDownList
        numVector.FormattingEnabled = True
        numVector.Items.AddRange(New Object() {"1", "2", "3", "4"})
        numVector.Location = New Point(204, 207)
        numVector.Name = "numVector"
        numVector.Size = New Size(151, 28)
        numVector.TabIndex = 6
        ' 
        ' proceed
        ' 
        proceed.Location = New Point(74, 265)
        proceed.Name = "proceed"
        proceed.Size = New Size(129, 47)
        proceed.TabIndex = 7
        proceed.Text = "OK"
        proceed.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(226, 265)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 47)
        Button2.TabIndex = 8
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' vectorAddition
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(427, 341)
        Controls.Add(Button2)
        Controls.Add(proceed)
        Controls.Add(numVector)
        Controls.Add(Label3)
        Controls.Add(sigFig)
        Controls.Add(Label2)
        Controls.Add(vectorForm)
        Controls.Add(Label1)
        Controls.Add(vector)
        Name = "vectorAddition"
        StartPosition = FormStartPosition.CenterScreen
        Text = "vectorAddition"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents vector As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents vectorForm As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents sigFig As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents numVector As ComboBox
    Friend WithEvents proceed As Button
    Friend WithEvents Button2 As Button
End Class
