Public Class frmQandAXML
    'DGV Mockup
    'Question #    Question                                          Answer           Score
    '1             Who has won the msot individual gold medals?      Michael Phelps   1

    Const NUM_COLUMNS As Integer = 4
    Const IDX_ROW_ID As Integer = 0
    Const IDX_QUESTION As Integer = 1
    Const IDX_ANSWER As Integer = 2
    Const IDX_SCORE As Integer = 3

    Const MAX_TIME_BEGINNER As String = "30"
    Const MAX_TIME_INTERMEDIATE As String = "20"
    Const MAX_TIME_ADVANCED As String = "10"

    Structure QandA
        Dim questionNum As Integer
        Dim question As String
        Dim answer As String
        Dim hint As String
        Dim answeredCorrectly As Boolean
    End Structure

    Dim popCulture() As QandA
    Dim maxTime As String = MAX_TIME_BEGINNER

    Private Sub frmQandAXML_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not loadFile() Then
            Me.Close()
        Else
            ToolTip1.InitialDelay = 200
            ToolTip1.AutoPopDelay = 10000
            ToolTip1.ReshowDelay = 50
            ToolTip1.IsBalloon = True

            dgvResults.ColumnCount = NUM_COLUMNS

            dgvResults.RowHeadersVisible = False

            dgvResults.AllowUserToAddRows = False

            dgvResults.Columns(IDX_ROW_ID).HeaderText = "#"
            dgvResults.Columns(IDX_QUESTION).HeaderText = "Question"
            dgvResults.Columns(IDX_ANSWER).HeaderText = "Answer"
            dgvResults.Columns(IDX_SCORE).HeaderText = "Score"

            showQuestion(1)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmQandAAboutBox.ShowDialog()
    End Sub

    Private Sub btnSubmitAnswer_Click(sender As Object, e As EventArgs) Handles btnSubmitAnswer.Click
        evaluateAnswer()
    End Sub

    Public Function loadFile() As Boolean
        Dim xmlFile As XElement
        Dim questionNum As Integer
        Dim fileLoaded As Boolean = False

        OpenFileDialog1.Filter = "XML Files|*.xml"
        OpenFileDialog1.Title = "Select Q&A File"
        OpenFileDialog1.InitialDirectory = Environment.CurrentDirectory
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()

        Try
            xmlFile = XElement.Load(OpenFileDialog1.FileName)

            For Each curPair In xmlFile.Descendants("pair")
                ReDim Preserve popCulture(questionNum)

                popCulture(questionNum).questionNum = questionNum + 1
                popCulture(questionNum).question = curPair.<question>.Value
                popCulture(questionNum).answer = curPair.<answer>.Value
                popCulture(questionNum).hint = curPair.<hint>.Value
                popCulture(questionNum).answeredCorrectly = False

                questionNum += 1
            Next

            fileLoaded = True
        Catch agEx As ArgumentException
            MessageBox.Show(text:="A file was not selected. Please try again.",
                            caption:="Unable to Play",
                            buttons:=MessageBoxButtons.OK,
                            icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="The exception shown below is preventing the game from being played." &
                            vbNewLine &
                            ex.GetType.FullName & " - " & ex.Message,
                            caption:="Unable to Play",
                            buttons:=MessageBoxButtons.OK,
                            icon:=MessageBoxIcon.Error)
        End Try

        Return fileLoaded
    End Function

    Public Sub showQuestion(questionNum As Integer)
        If questionNum <= popCulture.Count Then
            Dim answerQuery = From curQ In popCulture
                              Where curQ.questionNum = questionNum
                              Select curQ.question, curQ.hint

            txtQuestion.Text = answerquery.ToArray(0).question
            ToolTip1.SetToolTip(txtQuestion, answerQuery.ToArray(0).hint)

            txtAnswer.Text = ""
            txtAnswer.Focus()

            resetTimer()
        Else
            txtQuestion.Text = "That's all for now"
            txtAnswer.ReadOnly = True
            btnSubmitAnswer.Enabled = False
        End If
    End Sub

    Public Sub resetTimer()
        txtTime.ForeColor = Color.Black
        txtTime.Text = maxTime

        tmrCountDown.Interval = 100
        tmrCountDown.Enabled = True
    End Sub

    Private Sub evaluateAnswer()
        Dim isCorrect As Boolean = False
        Dim newRow As New DataGridViewRow
        Dim nextQuestionNum As Integer

        tmrCountDown.Enabled = False

        newRow.CreateCells(dgvResults)

        Dim answerQuery = From curQ In popCulture
                          Where curQ.question.ToLower = txtQuestion.Text.ToLower
                          Select curQ.questionNum, curQ.question, curQ.answer

        For Each curAnswer In answerQuery
            If txtAnswer.Text.Trim.Length > 0 And curAnswer.answer.ToLower.Contains(txtAnswer.Text.ToLower) Then
                isCorrect = True
            End If

            newRow.Cells(IDX_ROW_ID).Value = curAnswer.questionNum
            newRow.Cells(IDX_QUESTION).Value = curAnswer.question
            newRow.Cells(IDX_ANSWER).Value = curAnswer.answer
            newRow.Cells(IDX_SCORE).Value = IIf(isCorrect = True, 1, 0)

            dgvResults.Rows.Add(newRow)

            nextQuestionNum = curAnswer.questionNum + 1
        Next

        dgvResults.AutoResizeColumns()
        dgvResults.AutoResizeRows()

        showQuestion(nextQuestionNum)
    End Sub

    Private Sub BeginnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeginnerToolStripMenuItem.Click
        maxTime = MAX_TIME_BEGINNER

        resetTimer()
    End Sub

    Private Sub IntermediateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntermediateToolStripMenuItem.Click
        maxTime = MAX_TIME_INTERMEDIATE

        resetTimer()
    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        maxTime = MAX_TIME_ADVANCED

        resetTimer()
    End Sub

    Private Sub tmrCountDown_Tick(sender As Object, e As EventArgs) Handles tmrCountDown.Tick
        txtTime.Text = (CDbl(txtTime.Text) - 0.1).ToString("N1")

        If CDbl(txtTime.Text) < 10.0 Then
            txtTime.ForeColor = Color.Red
        End If

        If CDbl(txtTime.Text) <= 0.0 Then
            evaluateAnswer()
        End If
    End Sub
End Class