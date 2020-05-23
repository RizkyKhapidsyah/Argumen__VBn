Public Class FormDemoArgumen

    Private Sub tombolDemo1_Click(sender As Object, e As EventArgs) Handles tombolDemo1.Click
        'Event handler ini memanggil prosedur TampilNilai,
        'melewatkan 5 sebagai argumennya
        listNilai.Items.Clear()
        TampilNilai(5)
    End Sub

    Private Sub tombolDemo2_Click(sender As Object, e As EventArgs) Handles tombolDemo2.Click
        'Memanggil prosedur TampilNilai beberapa kali,
        'yang setiap kali melewatkan argumen yang berbeda
        listNilai.Items.Clear()
        TampilNilai(5)
        TampilNilai(10)
        TampilNilai(2)
        TampilNilai(16)

        'Nilai dari sebuah ekspresi dilewatkan kepada
        'prosedur TampilNilai
        TampilNilai(3 + 5)
    End Sub

    Private Sub tombolDemo3_Click(sender As Object, e As EventArgs) Handles tombolDemo3.Click
        'Menggunakan sebuah loop untuk memanggil prosedur TampilNilai
        'melewatkan sebuah variabel sebagai argumen
        listNilai.Items.Clear()

        Dim intHitung As Integer
        For intHitung = 1 To 10
            TampilNilai(intHitung)
        Next
    End Sub

    Sub TampilNilai(ByVal intNilai As Integer)
        'Prosedur ini menambahkan sebuah nilai ke dalam kotak list
        listNilai.Items.Add(intNilai.ToString())
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        Me.Close()
    End Sub
End Class
