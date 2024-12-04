Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        oconnor.Visibility = Visibility.Hidden
        liberty.Visibility = Visibility.Hidden
        boulder_creek.Visibility = Visibility.Visible
        location1.Text = "anthem"
        pop.Text = "2577"
        mascot1.Text = "jaguar"
        fact.Text = "super cool"
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        boulder_creek.Visibility = Visibility.Hidden
        liberty.Visibility = Visibility.Hidden
        oconnor.Visibility = Visibility.Visible
        location1.Text = "phoenix"
        pop.Text = "2604"
        mascot1.Text = "eagle"
        fact.Text = "worst school on the list"
    End Sub

    Private Sub liberty1_Click(sender As Object, e As RoutedEventArgs) Handles liberty1.Click
        boulder_creek.Visibility = Visibility.Hidden
        oconnor.Visibility = Visibility.Hidden
        liberty.Visibility = Visibility.Visible
        location1.Text = "peoria"
        pop.Text = "2603"
        mascot1.Text = "lion"
        fact.Text = "#1 football"
    End Sub
End Class
