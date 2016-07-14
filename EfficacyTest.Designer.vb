<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EfficacyTest
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EfficacyTest))
        Me.btnRun = New System.Windows.Forms.Button()
        Me.tbPath1 = New System.Windows.Forms.TextBox()
        Me.lbPath = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.cbRandom = New System.Windows.Forms.Button()
        Me.nudRandom = New System.Windows.Forms.NumericUpDown()
        Me.lbRandom = New System.Windows.Forms.Label()
        Me.lbMissed = New System.Windows.Forms.Label()
        Me.lbEfficacy = New System.Windows.Forms.Label()
        Me.nudSleep = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Separator = New System.Windows.Forms.Label()
        CType(Me.nudRandom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSleep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(495, 40)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 4
        Me.btnRun.TabStop = False
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'tbPath1
        '
        Me.tbPath1.Location = New System.Drawing.Point(10, 10)
        Me.tbPath1.Name = "tbPath1"
        Me.tbPath1.Size = New System.Drawing.Size(560, 22)
        Me.tbPath1.TabIndex = 0
        '
        'lbPath
        '
        Me.lbPath.AutoSize = True
        Me.lbPath.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPath.Location = New System.Drawing.Point(10, 190)
        Me.lbPath.Name = "lbPath"
        Me.lbPath.Size = New System.Drawing.Size(33, 17)
        Me.lbPath.TabIndex = 5
        Me.lbPath.Text = "Path"
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(495, 40)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 2
        Me.btnStop.TabStop = False
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'cbRandom
        '
        Me.cbRandom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRandom.Location = New System.Drawing.Point(259, 238)
        Me.cbRandom.Name = "cbRandom"
        Me.cbRandom.Size = New System.Drawing.Size(75, 23)
        Me.cbRandom.TabIndex = 4
        Me.cbRandom.TabStop = False
        Me.cbRandom.Text = "Random"
        Me.cbRandom.UseVisualStyleBackColor = True
        '
        'nudRandom
        '
        Me.nudRandom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRandom.Location = New System.Drawing.Point(202, 238)
        Me.nudRandom.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudRandom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRandom.Name = "nudRandom"
        Me.nudRandom.Size = New System.Drawing.Size(51, 22)
        Me.nudRandom.TabIndex = 3
        Me.nudRandom.TabStop = False
        Me.nudRandom.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'lbRandom
        '
        Me.lbRandom.AutoSize = True
        Me.lbRandom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRandom.Location = New System.Drawing.Point(10, 240)
        Me.lbRandom.Name = "lbRandom"
        Me.lbRandom.Size = New System.Drawing.Size(188, 13)
        Me.lbRandom.TabIndex = 10
        Me.lbRandom.Text = "Number of random files to capture:"
        '
        'lbMissed
        '
        Me.lbMissed.AutoSize = True
        Me.lbMissed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMissed.Location = New System.Drawing.Point(10, 100)
        Me.lbMissed.Name = "lbMissed"
        Me.lbMissed.Size = New System.Drawing.Size(121, 25)
        Me.lbMissed.TabIndex = 11
        Me.lbMissed.Text = "Files Missed:"
        '
        'lbEfficacy
        '
        Me.lbEfficacy.AutoSize = True
        Me.lbEfficacy.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEfficacy.Location = New System.Drawing.Point(10, 140)
        Me.lbEfficacy.Name = "lbEfficacy"
        Me.lbEfficacy.Size = New System.Drawing.Size(84, 25)
        Me.lbEfficacy.TabIndex = 12
        Me.lbEfficacy.Text = "Efficacy:"
        '
        'nudSleep
        '
        Me.nudSleep.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSleep.Location = New System.Drawing.Point(47, 43)
        Me.nudSleep.Name = "nudSleep"
        Me.nudSleep.Size = New System.Drawing.Size(51, 22)
        Me.nudSleep.TabIndex = 1
        Me.nudSleep.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "seconds between malware executions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Sleep"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'Separator
        '
        Me.Separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Separator.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Separator.Location = New System.Drawing.Point(10, 220)
        Me.Separator.Name = "Separator"
        Me.Separator.Size = New System.Drawing.Size(562, 2)
        Me.Separator.TabIndex = 19
        Me.Separator.Text = "Path"
        '
        'EfficacyTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 272)
        Me.Controls.Add(Me.Separator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudSleep)
        Me.Controls.Add(Me.lbEfficacy)
        Me.Controls.Add(Me.lbMissed)
        Me.Controls.Add(Me.lbRandom)
        Me.Controls.Add(Me.nudRandom)
        Me.Controls.Add(Me.cbRandom)
        Me.Controls.Add(Me.lbPath)
        Me.Controls.Add(Me.tbPath1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnRun)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EfficacyTest"
        Me.Text = "EfficacyTest"
        CType(Me.nudRandom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSleep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents tbPath1 As System.Windows.Forms.TextBox
    Friend WithEvents lbPath As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents cbRandom As System.Windows.Forms.Button
    Friend WithEvents nudRandom As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbRandom As System.Windows.Forms.Label
    Friend WithEvents lbMissed As System.Windows.Forms.Label
    Friend WithEvents lbEfficacy As System.Windows.Forms.Label
    Friend WithEvents nudSleep As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Separator As System.Windows.Forms.Label

End Class
