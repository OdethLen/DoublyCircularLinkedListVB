Imports DoublyCircularLinkedListVB.DoublyCircularLinkedList

Public Class Form1

    Inherits Form

    Private dcll As New DoublyCircularLL()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If dcll.Contains(Integer.Parse(txtValue.Text)) Then
            MessageBox.Show("The value already exists")
            Return
        End If

        Dim node As New Node(Integer.Parse(txtValue.Text))
        dcll.Add(node)
        MessageBox.Show(dcll.ToString())
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dcll.Contains(Integer.Parse(txtValue.Text)) Then
            dcll.Remove(Integer.Parse(txtValue.Text))
            MessageBox.Show(dcll.ToString())
        Else
            MessageBox.Show("Value " & txtValue.Text & " does not exist in the doubly circular linked list")
        End If
    End Sub

    Private Sub btnContains_Click(sender As Object, e As EventArgs) Handles btnContains.Click
        If dcll.Contains(Integer.Parse(txtValue.Text)) Then
            MessageBox.Show("Value " & txtValue.Text & " exists in the doubly circular linked list")
        Else
            MessageBox.Show("Value " & txtValue.Text & " does not exist in the doubly circular linked list")
        End If
    End Sub
End Class
