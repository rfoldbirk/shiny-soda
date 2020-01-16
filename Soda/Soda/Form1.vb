Public Class Form1

    Dim state As Integer = 0
    Dim choice As Integer = 0
    Dim total As Integer = 0
    Dim money_given As Integer = 0
    Dim shopping_cart As New List(Of Integer) From
    {0, 0, 0, 0}

    Dim sodas As New List(Of String) From
    {"cola", "fanta", "sprite", "pepsi", "køb"}


    Dim prices As New List(Of Integer) From
    {15, 20, 17, 9}


    Dim money_list As New List(Of Integer) From
    {1, 2, 5, 10, 20}

    Sub give_back(given, total)
        If given - total < 0 Then
            Exit Sub
        End If

        Dim count = money_list.Count - 1
        Dim return_list As New List(Of Integer) From
        {0, 0, 0, 0, 0}



        While True
            Dim dif = given - total
            If dif >= money_list(count) Then
                return_list(count) = return_list(count) + 1 ' Da man tæller hvor mange tyvere der er
                given = given - money_list(count)
            Else
                count = count - 1
                If count = -1 Then
                    Exit While
                End If
            End If
        End While

        Dim str As String = "Du får tilbage:"

        For index = 0 To return_list.Count - 1
            If return_list(index) > 0 Then
                str = str & " " & return_list(index) & " " & money_list(index) & " kr,"
            End If
        Next

        output.Text = str
    End Sub

    Sub update_choice()
        If state = 0 Then
        Else
            Exit Sub
        End If
        If choice = -1 Then
            choice = sodas.Count - 1
        ElseIf choice = sodas.Count Then ' implement automatic limit
            choice = 0
        End If

        Dim str As String = ""

        For index = 0 To sodas.Count - 1
            If index = choice Then
                str = str & "  [ " & sodas(index) & " ]"
            Else
                str = str & "  " & sodas(index)
            End If
        Next

        output.Text = str

        If choice < sodas.Count - 1 Then
            show.Text = sodas(choice) & " koster: " & prices(choice) & " kr."
        End If

    End Sub

    Sub write_to_cart()
        Dim str As String = ""

        For index As Integer = 0 To shopping_cart.Count - 1
            If shopping_cart(index) = 0 Then
            Else
                str = str & shopping_cart(index) & " " & sodas(index) & "  "
            End If

        Next

        price.Text = "Pris: " & total & " kr."
        cart.Text = "Indkøbsvogn: " & str
    End Sub

    Sub addMoney(ByVal amount As Integer)
        If state = 1 Then
        Else
            Exit Sub
        End If

        money_given = money_given + amount
        output.Text = "Mønter indsat: " & money_given & " kr"
    End Sub

    Private Sub Right_Click(sender As Object, e As EventArgs) Handles right.Click
        choice = choice + 1
        update_choice()
    End Sub

    Private Sub Left_Click(sender As Object, e As EventArgs) Handles left.Click
        choice = choice - 1
        update_choice()
    End Sub

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles enter.Click
        If state = 0 Then
            If choice = sodas.Count - 1 Then
                If total > 0 Then
                    ' new state +1
                    state = state + 1
                    show.Visible = False

                    instruct.Text = "Indsæt mønter"
                    addMoney(0)
                End If
            Else
                ' add item
                shopping_cart(choice) = shopping_cart(choice) + 1
                total = total + prices(choice)
                write_to_cart()
            End If
        Else
            ' state = 1
            If money_given >= total Then
                ' beregn veksel penge
                state = state + 1
                give_back(money_given, total)
            Else
                instruct.Text = "Venligst indsæt flere mønter"
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn5.Click, btn10.Click, btn20.Click
        addMoney(sender.Text)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        If state > 0 Then
            state = state - 1
            If state = 0 Then
                instruct.Text = "Vælg din sodavand"
                output.Text = "cola  fanta  sprite  pepsi  [ køb ]"
                show.Visible = True
            End If
        End If
    End Sub

    Private Sub Output_Click(sender As Object, e As EventArgs) Handles output.Click

    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        If state = 1 Then
            money_given = 0
            output.Text = "Mønter indsat: 0 kr"
        End If
    End Sub
End Class
