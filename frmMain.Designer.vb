<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstBoxInformation = New System.Windows.Forms.ListBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.txtboxCityStateZip = New System.Windows.Forms.TextBox()
        Me.txtboxAddress = New System.Windows.Forms.TextBox()
        Me.txtSofasOrdered = New System.Windows.Forms.TextBox()
        Me.txtboxChairsOrdered = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCityStateZip = New System.Windows.Forms.Label()
        Me.lblNumberChairs = New System.Windows.Forms.Label()
        Me.lblNumberSofas = New System.Windows.Forms.Label()
        Me.btnProcessOrder = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxInformation
        '
        Me.lstBoxInformation.FormattingEnabled = True
        Me.lstBoxInformation.Location = New System.Drawing.Point(465, 27)
        Me.lstBoxInformation.Name = "lstBoxInformation"
        Me.lstBoxInformation.Size = New System.Drawing.Size(336, 342)
        Me.lstBoxInformation.TabIndex = 0
        '
        'txtboxName
        '
        Me.txtboxName.Location = New System.Drawing.Point(99, 49)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(182, 20)
        Me.txtboxName.TabIndex = 1
        '
        'txtboxCityStateZip
        '
        Me.txtboxCityStateZip.Location = New System.Drawing.Point(99, 190)
        Me.txtboxCityStateZip.Name = "txtboxCityStateZip"
        Me.txtboxCityStateZip.Size = New System.Drawing.Size(182, 20)
        Me.txtboxCityStateZip.TabIndex = 2
        '
        'txtboxAddress
        '
        Me.txtboxAddress.Location = New System.Drawing.Point(99, 125)
        Me.txtboxAddress.Name = "txtboxAddress"
        Me.txtboxAddress.Size = New System.Drawing.Size(182, 20)
        Me.txtboxAddress.TabIndex = 3
        '
        'txtSofasOrdered
        '
        Me.txtSofasOrdered.Location = New System.Drawing.Point(99, 329)
        Me.txtSofasOrdered.Name = "txtSofasOrdered"
        Me.txtSofasOrdered.Size = New System.Drawing.Size(54, 20)
        Me.txtSofasOrdered.TabIndex = 4
        '
        'txtboxChairsOrdered
        '
        Me.txtboxChairsOrdered.Location = New System.Drawing.Point(99, 269)
        Me.txtboxChairsOrdered.Name = "txtboxChairsOrdered"
        Me.txtboxChairsOrdered.Size = New System.Drawing.Size(54, 20)
        Me.txtboxChairsOrdered.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(13, 49)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(96, 51)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Customer name (Last, First)"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(13, 125)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 7
        Me.lblAddress.Text = "Address"
        '
        'lblCityStateZip
        '
        Me.lblCityStateZip.AutoSize = True
        Me.lblCityStateZip.Location = New System.Drawing.Point(13, 190)
        Me.lblCityStateZip.Name = "lblCityStateZip"
        Me.lblCityStateZip.Size = New System.Drawing.Size(76, 13)
        Me.lblCityStateZip.TabIndex = 8
        Me.lblCityStateZip.Text = "City, State, Zip"
        '
        'lblNumberChairs
        '
        Me.lblNumberChairs.Location = New System.Drawing.Point(13, 269)
        Me.lblNumberChairs.Name = "lblNumberChairs"
        Me.lblNumberChairs.Size = New System.Drawing.Size(63, 43)
        Me.lblNumberChairs.TabIndex = 9
        Me.lblNumberChairs.Text = "Number of Chairs Ordered"
        '
        'lblNumberSofas
        '
        Me.lblNumberSofas.Location = New System.Drawing.Point(13, 329)
        Me.lblNumberSofas.Name = "lblNumberSofas"
        Me.lblNumberSofas.Size = New System.Drawing.Size(63, 40)
        Me.lblNumberSofas.TabIndex = 10
        Me.lblNumberSofas.Text = "Number of Sofas Ordered"
        '
        'btnProcessOrder
        '
        Me.btnProcessOrder.Location = New System.Drawing.Point(34, 426)
        Me.btnProcessOrder.Name = "btnProcessOrder"
        Me.btnProcessOrder.Size = New System.Drawing.Size(166, 23)
        Me.btnProcessOrder.TabIndex = 11
        Me.btnProcessOrder.Text = "Process Order"
        Me.btnProcessOrder.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(301, 426)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(172, 23)
        Me.btnClearForm.TabIndex = 12
        Me.btnClearForm.Text = "Clear Order Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(579, 426)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(169, 23)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 461)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnProcessOrder)
        Me.Controls.Add(Me.lblNumberSofas)
        Me.Controls.Add(Me.lblNumberChairs)
        Me.Controls.Add(Me.lblCityStateZip)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtboxChairsOrdered)
        Me.Controls.Add(Me.txtSofasOrdered)
        Me.Controls.Add(Me.txtboxAddress)
        Me.Controls.Add(Me.txtboxCityStateZip)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.lstBoxInformation)
        Me.Name = "frmMain"
        Me.Text = "Furniture Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBoxInformation As System.Windows.Forms.ListBox
    Friend WithEvents txtboxName As System.Windows.Forms.TextBox
    Friend WithEvents txtboxCityStateZip As System.Windows.Forms.TextBox
    Friend WithEvents txtboxAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSofasOrdered As System.Windows.Forms.TextBox
    Friend WithEvents txtboxChairsOrdered As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCityStateZip As System.Windows.Forms.Label
    Friend WithEvents lblNumberChairs As System.Windows.Forms.Label
    Friend WithEvents lblNumberSofas As System.Windows.Forms.Label
    Friend WithEvents btnProcessOrder As System.Windows.Forms.Button
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
