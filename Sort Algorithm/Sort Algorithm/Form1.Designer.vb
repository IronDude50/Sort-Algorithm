<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.rbn100 = New System.Windows.Forms.RadioButton()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbn500 = New System.Windows.Forms.RadioButton()
        Me.rbn5000 = New System.Windows.Forms.RadioButton()
        Me.rbn1000 = New System.Windows.Forms.RadioButton()
        Me.rbnSelectionSort = New System.Windows.Forms.RadioButton()
        Me.rbnQuickSort = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(12, 224)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(106, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'rbn100
        '
        Me.rbn100.AutoSize = True
        Me.rbn100.Location = New System.Drawing.Point(6, 22)
        Me.rbn100.Name = "rbn100"
        Me.rbn100.Size = New System.Drawing.Size(43, 19)
        Me.rbn100.TabIndex = 1
        Me.rbn100.TabStop = True
        Me.rbn100.Text = "100"
        Me.rbn100.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(124, 12)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(390, 242)
        Me.txtOutput.TabIndex = 2
        Me.txtOutput.Text = "Output"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbn100)
        Me.GroupBox1.Controls.Add(Me.rbn500)
        Me.GroupBox1.Controls.Add(Me.rbn5000)
        Me.GroupBox1.Controls.Add(Me.rbn1000)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 125)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sample Size"
        '
        'rbn500
        '
        Me.rbn500.AutoSize = True
        Me.rbn500.Location = New System.Drawing.Point(6, 47)
        Me.rbn500.Name = "rbn500"
        Me.rbn500.Size = New System.Drawing.Size(43, 19)
        Me.rbn500.TabIndex = 4
        Me.rbn500.TabStop = True
        Me.rbn500.Text = "500"
        Me.rbn500.UseVisualStyleBackColor = True
        '
        'rbn5000
        '
        Me.rbn5000.AutoSize = True
        Me.rbn5000.Location = New System.Drawing.Point(6, 97)
        Me.rbn5000.Name = "rbn5000"
        Me.rbn5000.Size = New System.Drawing.Size(49, 19)
        Me.rbn5000.TabIndex = 6
        Me.rbn5000.TabStop = True
        Me.rbn5000.Text = "5000"
        Me.rbn5000.UseVisualStyleBackColor = True
        '
        'rbn1000
        '
        Me.rbn1000.AutoSize = True
        Me.rbn1000.Location = New System.Drawing.Point(6, 72)
        Me.rbn1000.Name = "rbn1000"
        Me.rbn1000.Size = New System.Drawing.Size(49, 19)
        Me.rbn1000.TabIndex = 5
        Me.rbn1000.TabStop = True
        Me.rbn1000.Text = "1000"
        Me.rbn1000.UseVisualStyleBackColor = True
        '
        'rbnSelectionSort
        '
        Me.rbnSelectionSort.AutoSize = True
        Me.rbnSelectionSort.Location = New System.Drawing.Point(6, 22)
        Me.rbnSelectionSort.Name = "rbnSelectionSort"
        Me.rbnSelectionSort.Size = New System.Drawing.Size(97, 19)
        Me.rbnSelectionSort.TabIndex = 7
        Me.rbnSelectionSort.TabStop = True
        Me.rbnSelectionSort.Text = "Selection Sort"
        Me.rbnSelectionSort.UseVisualStyleBackColor = True
        '
        'rbnQuickSort
        '
        Me.rbnQuickSort.AutoSize = True
        Me.rbnQuickSort.Location = New System.Drawing.Point(6, 47)
        Me.rbnQuickSort.Name = "rbnQuickSort"
        Me.rbnQuickSort.Size = New System.Drawing.Size(80, 19)
        Me.rbnQuickSort.TabIndex = 8
        Me.rbnQuickSort.TabStop = True
        Me.rbnQuickSort.Text = "Quick Sort"
        Me.rbnQuickSort.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbnSelectionSort)
        Me.GroupBox2.Controls.Add(Me.rbnQuickSort)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 75)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sort Style"
        '
        'btnSort
        '
        Me.btnSort.Enabled = False
        Me.btnSort.Location = New System.Drawing.Point(12, 253)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(106, 23)
        Me.btnSort.TabIndex = 8
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(124, 257)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(74, 15)
        Me.lblComment.TabIndex = 9
        Me.lblComment.Text = "lblComment"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 290)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents rbn100 As RadioButton
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbn500 As RadioButton
    Friend WithEvents rbn5000 As RadioButton
    Friend WithEvents rbn1000 As RadioButton
    Friend WithEvents rbnSelectionSort As RadioButton
    Friend WithEvents rbnQuickSort As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSort As Button
    Friend WithEvents lblComment As Label
End Class
