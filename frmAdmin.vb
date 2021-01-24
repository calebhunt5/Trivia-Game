Imports System.Xml

Public Class frmAdmin
    'creation of constants
    Const NUM_COLUMNS As Integer = 4
    Const IDX_ROW_ID As Integer = 0
    Const IDX_QUESTION As Integer = 1
    Const IDX_ANSWER As Integer = 2
    Const IDX_HINT As Integer = 3

    'structure to store UDT
    Structure QandA
        Dim questionNum As Integer
        Dim question As String
        Dim answer As String
        Dim hint As String
    End Structure

    'Global Array Variable to store each QandA from file
    Dim allQuestions() As QandA

    'method that lets user load a file into the program
    Function loadFile() As Boolean
        Dim xmlFile As XElement
        Dim questionNum As Integer
        Dim fileLoaded As Boolean = False

        'configure openFileDialog1 to have XML files as the default option
        OpenFileDialog1.Filter = "XML Files|*.xml"
        OpenFileDialog1.Title = "Select Q&A File"
        OpenFileDialog1.InitialDirectory = Environment.CurrentDirectory
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()

        'try to open the file alert the user if no file is chosen
        Try
            xmlFile = XElement.Load(OpenFileDialog1.FileName)

            'puts values from file into GAV
            For Each curPair In xmlFile.Descendants("pair")
                ReDim Preserve allQuestions(questionNum)

                allQuestions(questionNum).questionNum = questionNum + 1
                allQuestions(questionNum).question = curPair.<question>.Value
                allQuestions(questionNum).answer = curPair.<answer>.Value
                allQuestions(questionNum).hint = curPair.<hint>.Value

                'question number is not in the file so we generate it here
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

        'if file exists return true
        Return fileLoaded
    End Function

    'displays GAV in dataGridView
    Public Sub showDataInGrid()
        'empty all data
        dgvQA.Rows.Clear()

        'four columns created
        dgvQA.ColumnCount = NUM_COLUMNS

        'makes a row for each index of the GAV and puts child elements into individual colums
        For Each curQ In allQuestions
            Dim newRow As New DataGridViewRow

            newRow.CreateCells(dgvQA)

            newRow.Cells(IDX_ROW_ID).Value = curQ.questionNum
            newRow.Cells(IDX_QUESTION).Value = curQ.question
            newRow.Cells(IDX_ANSWER).Value = curQ.answer
            newRow.Cells(IDX_HINT).Value = curQ.hint

            dgvQA.Rows.Add(newRow)
        Next

        'autosize to view all data
        dgvQA.AutoResizeColumns()
        dgvQA.AutoResizeRows()

        dgvQA.RowHeadersVisible = False
        dgvQA.AllowUserToAddRows = False

        'create the header
        dgvQA.Columns(IDX_ROW_ID).HeaderText = "#"
        dgvQA.Columns(IDX_QUESTION).HeaderText = "Question"
        dgvQA.Columns(IDX_ANSWER).HeaderText = "Answer"
        dgvQA.Columns(IDX_HINT).HeaderText = "Hint"
    End Sub

    'adds a new row to dgv and index to GAV
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newRow As New DataGridViewRow

        newRow.CreateCells(dgvQA)

        'displays new question with default values in dgv
        newRow.Cells(IDX_ROW_ID).Value = dgvQA.Rows.Count + 1
        newRow.Cells(IDX_QUESTION).Value = "New Question"
        newRow.Cells(IDX_ANSWER).Value = "New Answer"
        newRow.Cells(IDX_HINT).Value = "New Hint"

        dgvQA.Rows.Add(newRow)

        'adds new index to GAV
        ReDim Preserve allQuestions(dgvQA.Rows.Count - 1)

        'fills new GAV index child elements with default values
        allQuestions(allQuestions.GetUpperBound(0)).questionNum = dgvQA.Rows.Count
        allQuestions(allQuestions.GetUpperBound(0)).question = "New Question"
        allQuestions(allQuestions.GetUpperBound(0)).answer = "New Answer"
        allQuestions(allQuestions.GetUpperBound(0)).hint = "New Hint"

        txtQuestion.Text = allQuestions(allQuestions.GetUpperBound(0)).question
        txtAnswer.Text = allQuestions(allQuestions.GetUpperBound(0)).answer
        txtHint.Text = allQuestions(allQuestions.GetUpperBound(0)).hint
    End Sub

    'updates selected row in dgv and GAV
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedIdx As Integer = dgvQA.CurrentRow.Index

        'changes child elements to txt box values
        allQuestions(selectedIdx).question = txtQuestion.Text
        allQuestions(selectedIdx).answer = txtAnswer.Text
        allQuestions(selectedIdx).hint = txtHint.Text

        'clear dgv and diplay new GAV values
        showDataInGrid()

        MessageBox.Show(text:="Updated question " & selectedIdx,
                        caption:="Update Status",
                        buttons:=MessageBoxButtons.OK)
    End Sub

    'removes selected row in dgv and index in GAV
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedIdx As Integer = dgvQA.CurrentRow.Index

        dgvQA.Rows(selectedIdx).Selected = True

        'removes question from dgv not GAV
        dgvQA.Rows.Remove(dgvQA.SelectedRows(0))

        'shortens GAV
        ReDim allQuestions(dgvQA.Rows.Count - 1)

        'sets child elements in GAV equal to colums from dgv
        For i As Integer = 0 To dgvQA.Rows.Count - 1
            allQuestions(i).questionNum = i + 1
            allQuestions(i).question = dgvQA.Rows(i).Cells(IDX_QUESTION).Value.ToString
            allQuestions(i).answer = dgvQA.Rows(i).Cells(IDX_ANSWER).Value.ToString
            allQuestions(i).hint = dgvQA.Rows(i).Cells(IDX_HINT).Value.ToString
        Next

        'clear dgv and display new GAV
        showDataInGrid()
    End Sub

    'opens file that user picks
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        'make sure file exists or is chosen
        If Not loadFile() Then
            Me.Close()
        Else
            ToolTip1.InitialDelay = 200
            ToolTip1.AutoPopDelay = 10000
            ToolTip1.ReshowDelay = 50
            ToolTip1.IsBalloon = True

            showDataInGrid()
        End If
    End Sub

    'writes GAV to XML file named QA2.xml
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim xmlWriter As New XmlTextWriter("QA2.xml", System.Text.Encoding.UTF8)

        'create document
        xmlWriter.WriteStartDocument(True)

        xmlWriter.Formatting = Formatting.Indented
        xmlWriter.Indentation = 2

        'start QandA tag
        xmlWriter.WriteStartElement("QandA")

        'make pairs and child elements within pairs
        For Each curQ In allQuestions
            xmlWriter.WriteStartElement("pair")

            xmlWriter.WriteStartElement("question")
            xmlWriter.WriteString(curQ.question)
            xmlWriter.WriteEndElement()

            xmlWriter.WriteStartElement("answer")
            xmlWriter.WriteString(curQ.answer)
            xmlWriter.WriteEndElement()

            xmlWriter.WriteStartElement("hint")
            xmlWriter.WriteString(curQ.hint)
            xmlWriter.WriteEndElement()

            'end of pair
            xmlWriter.WriteEndElement()
        Next

        'end of QandA
        xmlWriter.WriteEndElement()

        'end of file
        xmlWriter.WriteEndDocument()

        xmlWriter.Flush()
        xmlWriter.Close()

        MessageBox.Show(text:="Questions have been written to an XML file.",
                        caption:="Save Status",
                        buttons:=MessageBoxButtons.OK)
    End Sub
End Class