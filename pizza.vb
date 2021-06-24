Public Class Form1

    Dim basetext, toppingtext As String
    Dim extratext As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim quantity, total As Integer
        Dim base, topping, extra As Integer


        'setter 
        If NumericUpDown1.Value = 0 Then
            NumericUpDown1.Value = 1

        End If

        'pizza base 
        If RadioButton1.Checked Then
            base = 100
            basetext = "25cm/10inch=100Rs"
        ElseIf RadioButton2.Checked Then
            base = 150
            basetext = "20cm/10inch=150Rs"
        ElseIf RadioButton3.Checked Then

            base = 200
            basetext = "35cm/10inch=200Rs"
        Else
            base = 0
        End If


        'toppings
        If RadioButton4.Checked Then
            topping = 100
            toppingtext = "Pepperoni-100 Rs"
            PictureBox1.Load("C:\Users\mom\Desktop\pizza\pp.jpg")
        ElseIf RadioButton5.Checked Then
            topping = 150
            toppingtext = "Vegetarian Bite-150 Rs"

            PictureBox1.Load("C:\Users\mom\Desktop\pizza\veg.jpg")

        ElseIf RadioButton6.Checked Then
            topping = 150
            toppingtext = "AmericanHeat-200 Rs"

            PictureBox1.Load("C:\Users\mom\Desktop\pizza\amer.jpg")

        ElseIf RadioButton7.Checked Then
            topping = 200
            toppingtext = "Cheese Brust-250 Rs"

            PictureBox1.Load("C:\Users\mom\Desktop\pizza\cheese.jpg")

        Else
            topping = 0
        End If

        'CheckBox 
        If CheckBox1.Checked Then
            extra += 100
            extratext += "Mushroom-100 Rs"
        End If
        If CheckBox2.Checked Then
            extra += 50
            extratext += "Green Pepper-50Rs"

        End If
        If CheckBox3.Checked Then
            extra += 100
            extratext += "Cheese -100Rs"
        End If
        quantity = NumericUpDown1.Value
        total = (base + topping + extra) * quantity

        TextBox1.Text = total & "Rs"

        MsgBox("Your Odrer " + vbLf + basetext + vbLf + toppingtext + vbLf + extratext + vbLf & total & "has been  order sucessfully  .......")



    End Sub



End Class
