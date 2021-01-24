<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.grpAllQuestions = New System.Windows.Forms.GroupBox()
        Me.dgvQA = New System.Windows.Forms.DataGridView()
        Me.grpSelectedQuestion = New System.Windows.Forms.GroupBox()
        Me.txtHint = New System.Windows.Forms.TextBox()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.grpQuestionActions = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpFileActions = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpAllQuestions.SuspendLayout()
        CType(Me.dgvQA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSelectedQuestion.SuspendLayout()
        Me.grpQuestionActions.SuspendLayout()
        Me.grpFileActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAllQuestions
        '
        Me.grpAllQuestions.Controls.Add(Me.dgvQA)
        Me.grpAllQuestions.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAllQuestions.Location = New System.Drawing.Point(12, 12)
        Me.grpAllQuestions.Name = "grpAllQuestions"
        Me.grpAllQuestions.Size = New System.Drawing.Size(1272, 288)
        Me.grpAllQuestions.TabIndex = 0
        Me.grpAllQuestions.TabStop = False
        Me.grpAllQuestions.Text = "All Questions"
        '
        'dgvQA
        '
        Me.dgvQA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQA.Location = New System.Drawing.Point(6, 34)
        Me.dgvQA.Name = "dgvQA"
        Me.dgvQA.RowHeadersWidth = 51
        Me.dgvQA.RowTemplate.Height = 24
        Me.dgvQA.Size = New System.Drawing.Size(1256, 237)
        Me.dgvQA.TabIndex = 0
        '
        'grpSelectedQuestion
        '
        Me.grpSelectedQuestion.Controls.Add(Me.txtHint)
        Me.grpSelectedQuestion.Controls.Add(Me.lblHint)
        Me.grpSelectedQuestion.Controls.Add(Me.txtAnswer)
        Me.grpSelectedQuestion.Controls.Add(Me.lblAnswer)
        Me.grpSelectedQuestion.Controls.Add(Me.txtQuestion)
        Me.grpSelectedQuestion.Controls.Add(Me.lblQuestion)
        Me.grpSelectedQuestion.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectedQuestion.Location = New System.Drawing.Point(18, 306)
        Me.grpSelectedQuestion.Name = "grpSelectedQuestion"
        Me.grpSelectedQuestion.Size = New System.Drawing.Size(767, 250)
        Me.grpSelectedQuestion.TabIndex = 1
        Me.grpSelectedQuestion.TabStop = False
        Me.grpSelectedQuestion.Text = "Selected Question"
        '
        'txtHint
        '
        Me.txtHint.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHint.Location = New System.Drawing.Point(16, 201)
        Me.txtHint.Name = "txtHint"
        Me.txtHint.Size = New System.Drawing.Size(743, 31)
        Me.txtHint.TabIndex = 5
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.Location = New System.Drawing.Point(6, 175)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(42, 23)
        Me.lblHint.TabIndex = 4
        Me.lblHint.Text = "Hint"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(16, 132)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(743, 31)
        Me.txtAnswer.TabIndex = 3
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(6, 106)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(65, 23)
        Me.lblAnswer.TabIndex = 2
        Me.lblAnswer.Text = "Answer"
        '
        'txtQuestion
        '
        Me.txtQuestion.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.Location = New System.Drawing.Point(16, 57)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(743, 31)
        Me.txtQuestion.TabIndex = 1
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(6, 31)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(79, 23)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Question"
        '
        'grpQuestionActions
        '
        Me.grpQuestionActions.Controls.Add(Me.btnDelete)
        Me.grpQuestionActions.Controls.Add(Me.btnUpdate)
        Me.grpQuestionActions.Controls.Add(Me.btnAdd)
        Me.grpQuestionActions.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpQuestionActions.Location = New System.Drawing.Point(791, 306)
        Me.grpQuestionActions.Name = "grpQuestionActions"
        Me.grpQuestionActions.Size = New System.Drawing.Size(493, 106)
        Me.grpQuestionActions.TabIndex = 6
        Me.grpQuestionActions.TabStop = False
        Me.grpQuestionActions.Text = "Question Actions"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(328, 34)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(155, 66)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete Question"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(167, 34)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(155, 66)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update Question"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(6, 34)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(155, 66)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Add Question"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpFileActions
        '
        Me.grpFileActions.Controls.Add(Me.btnSave)
        Me.grpFileActions.Controls.Add(Me.btnOpen)
        Me.grpFileActions.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFileActions.Location = New System.Drawing.Point(791, 433)
        Me.grpFileActions.Name = "grpFileActions"
        Me.grpFileActions.Size = New System.Drawing.Size(487, 118)
        Me.grpFileActions.TabIndex = 7
        Me.grpFileActions.TabStop = False
        Me.grpFileActions.Text = "File Actions"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(243, 34)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(238, 78)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save File..."
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(6, 34)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(231, 78)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "&Open File..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 563)
        Me.Controls.Add(Me.grpFileActions)
        Me.Controls.Add(Me.grpQuestionActions)
        Me.Controls.Add(Me.grpSelectedQuestion)
        Me.Controls.Add(Me.grpAllQuestions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdmin"
        Me.Text = "Assignment 17 - Q&A Admin Screen"
        Me.grpAllQuestions.ResumeLayout(False)
        CType(Me.dgvQA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSelectedQuestion.ResumeLayout(False)
        Me.grpSelectedQuestion.PerformLayout()
        Me.grpQuestionActions.ResumeLayout(False)
        Me.grpFileActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAllQuestions As GroupBox
    Friend WithEvents dgvQA As DataGridView
    Friend WithEvents grpSelectedQuestion As GroupBox
    Friend WithEvents txtHint As TextBox
    Friend WithEvents lblHint As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents grpQuestionActions As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents grpFileActions As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
End Class
