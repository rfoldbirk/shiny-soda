Public Class Form1

    ' alle min variabler
    Dim soda_speed As Integer = 3 ' det er så hurtigt sodavandsflasken falder.
    Dim state As Integer = 0 ' variablen holder styr på hvor langt man er i processen.
    Dim choice As Integer = 0 ' Denne holder styr på hvilken sodavand man er i gang med at vælge.
    Dim total As Integer = 0 ' er lig med det totale beløb af det man vil købe.
    Dim money_given As Integer = 0 ' variablen holder styr på hvor mange penge man har sat ind i systemet.
    Dim shopping_cart As New List(Of Integer) From ' denne liste bliver opdateret løbende, når man tilføjer en sodavand.
    {0, 0, 0, 0} ' Den holder bare styr på hvor mange af hver sodavand der er.

    Dim dispenser_counter_i As Integer = 0 ' Variablen bliver brugt når man skal have sodavandene ud af systemet.
    ' I stedet for at lave et for loop, har vi lavet en rekursiv funktion, som bruger denne variable som index.

    Dim sodas As New List(Of String) From ' bare en liste af sodavandene og muligheden for at gå videre til næste state
    {"cola", "fanta", "sprite", "pepsi", "køb"}

    Dim prices As New List(Of Integer) From ' priserne på sodavandene
    {15, 20, 17, 9}

    Dim money_list As New List(Of Integer) From ' en liste over pengene.
    {1, 2, 5, 10, 20}
    ' ________________

    Sub give_back(given, total)
        ' funktionen bliver kaldt fra Enter_Click, når state = 1
        ' denne funktion regner ud hvor mange penge man skal have tilbage. via et for loop
        If given - total < 0 Then
            Exit Sub
        End If

        Dim count = money_list.Count - 1 ' Dette er en liste over de forskellige mønter.
        Dim return_list As New List(Of Integer) From ' Her bliver der lavet en liste til antallet af de forskellige mønter.
        {0, 0, 0, 0, 0} ' Pladserne i listen svarer til mønterne i money_list på samme position.



        While True
            Dim dif = given - total
            If dif >= money_list(count) Then
                return_list(count) = return_list(count) + 1 ' Da man tæller hvor mange tyvere der er
                given = given - money_list(count)
            Else
                count = count - 1 
                If count = -1 Then ' så snart vores count er lig med -1 stopper vi while loopet.
                    Exit While
                End If
            End If
        End While

        Dim str As String = "Du får " ' starten af teksten.

        For index = 0 To return_list.Count - 1
            If return_list(index) > 0 Then
                str = str & " " & return_list(index) & ": " & money_list(index) & " kr," ' her tilføjer vi bid for bid en del af teksten.
            End If
        Next

        output.Text = str & " tilbage"

        dispenser_timer.Start() ' vi starter timeren, da det er tid til at hente ens sodavand.
    End Sub

    Sub update_choice()
        ' denne funktion skal laver en: [  ] om produktet.
        ' choice variablen beskriver hvilken genstand man har valgt.
        ' for loopet går alle mulighederne igennem og sætter teksten sammen.
        If state = 0 Then
        Else
            Exit Sub
        End If

        ' --------------------------------
        If choice = -1 Then
            choice = sodas.Count - 1
        ElseIf choice = sodas.Count Then
            choice = 0
        End If
        ' Dette gør at hvis man træder ud fra kanten så ryger man om på den anden side.
        ' --------------------------------

        Dim str As String = ""

        ' For loopet lavet teksten, som viser hvilket valg man er i gang med at tage.
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
        Else
            show.Text = "Tryk for at betale..."
        End If

    End Sub

    Sub write_to_cart()
        ' opdaterer skriften på skærmen.
        Dim str As String = ""

        For index As Integer = 0 To shopping_cart.Count - 1
            If shopping_cart(index) = 0 Then
            Else
                str = str & shopping_cart(index) & " " & sodas(index) & "  " ' Her sætter jeg teksten sammen
            End If

        Next

        price.Text = "Pris: " & total & " kr." ' opdatere de forskellige labels.
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
        ' samme som i Left_Click()
        choice = choice + 1
        update_choice()
    End Sub

    Private Sub Left_Click(sender As Object, e As EventArgs) Handles left.Click
        ' ændre valget af sodavand ved at opdatere choice, og derefter opdaterer man skriften.
        choice = choice - 1
        update_choice()
    End Sub

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles enter.Click
        ' Når man trykker på knappen enter sker der forskellige ting og sager.

        If state = 0 Then
            If choice = sodas.Count - 1 Then
                If total > 0 Then
                    ' Når man har valgt sin sodavand, skifter man state og beder kunden om at indsætte penge.
                    state = state + 1
                    show.Visible = False

                    instruct.Text = "Indsæt mønter"
                    addMoney(0)
                End If
            Else
                ' Når man er over en sodavand, kan tilføje den
                shopping_cart(choice) = shopping_cart(choice) + 1
                total = total + prices(choice)
                write_to_cart() ' Opdaterer skriften i bunden.
            End If
        Else
            ' state = 1
            If money_given >= total And state = 1 Then
                ' beregn veksel penge
                state = state + 1
                give_back(money_given, total)
            Else
                instruct.Text = "Venligst indsæt flere mønter" ' I tilfælde af at der ikke er nok penge.
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn5.Click, btn10.Click, btn20.Click
        ' denne funktion bliver kaldt fra alle penge knapperne og tilføjer penge afhængigt af knappens værdi
        addMoney(sender.Text)
    End Sub


    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        ' I denne funktion fjerner jeg bare alt pengene man har proppet ind i systemet.

        If state = 1 Then
            money_given = 0
            output.Text = "Mønter indsat: 0 kr"
        End If
    End Sub

    Private Sub soda_dis_Tick(sender As Object, e As EventArgs) Handles dispenser_timer.Tick
        ' Hver gang timeren ticker, falder en sodavand ned.

        If dispenser_counter_i > shopping_cart.Count - 1 Then ' Hvis vi har gået hele indkøbsvognen igennem stopper vi timeren.
            dispenser_timer.Stop()
        Else
            If shopping_cart(dispenser_counter_i) = 0 Then ' Hvis der ikke er mere på en bestemt plads i indkøbsvognen
                dispenser_counter_i = dispenser_counter_i + 1 ' Plusser vi dispenser_counter_i med 1 
                Exit Sub                                        ' og stopper funktionen
            End If

            If dispenser_counter_i = 0 Then
                cola_pic.Image = My.Resources.ResourceManager.GetObject("coke_rot")
            ElseIf dispenser_counter_i = 1 Then
                cola_pic.Image = My.Resources.ResourceManager.GetObject("fanta_rot")
            ElseIf dispenser_counter_i = 2 Then
                cola_pic.Image = My.Resources.ResourceManager.GetObject("sprite_rot")
            ElseIf dispenser_counter_i = 3 Then
                cola_pic.Image = My.Resources.ResourceManager.GetObject("pepsi_rot")
            Else
                dispenser_timer.Stop()
            End If
            ' Ovenover skifter jeg billedet ud fra værdien af dispenser_counter_i, hvis dispenser_counter_i er mere end 3 i dette tilfælde stopper jeg timeren.

            cola_pic.Location = New Point(cola_pic.Location.X, cola_pic.Location.Y + soda_speed) ' Her animerer jeg sodavands flasken. Farten er lig med 3
            If cola_pic.Location.Y >= 12 Then ' 12 er bare der hvor sodavandsflasken er faldet helt nede, når det er sket stopper timeren.
                dispenser_timer.Stop()
            End If
        End If


    End Sub

    Private Sub cola_pic_Click(sender As Object, e As EventArgs) Handles cola_pic.Click
        ' denne funktion bliver kaldt når man trykker på sodavands billedet. 
        ' billedets position bliver nulstillet og shopping_cart (indkøbsvognen bliver tømt mere og mere for hver gang man kalder funktionen)
        ' Derefter starter jeg timeren igen så en sodavand kan falde ned.

        cola_pic.Location = New Point(cola_pic.Location.X, -55) ' nulstil til den normale position

        If shopping_cart(dispenser_counter_i) > 0 Then
            shopping_cart(dispenser_counter_i) = shopping_cart(dispenser_counter_i) - 1
        End If
        dispenser_timer.Start()
    End Sub
End Class