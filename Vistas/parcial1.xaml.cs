namespace hchavezT3.Vistas;

public partial class parcial1 : ContentPage
{

    string usuario_;
    public parcial1(string usuario)
    {
        usuario_ = usuario;
        InitializeComponent();
        DisplayAlert("bienvenido", usuario, "ok");
        lblUsuario.Text = "Usuario: " + usuario;




    }

    private void botonParcial1_Clicked(object sender, EventArgs e)
    {
        // Obtener las notas del parcial y del examen
        if (double.TryParse(parcial1Entry.Text, out double parcial1Nota) &&
            double.TryParse(examenEntry.Text, out double examenNota))
        {
            // Calcular la nota final
            double notaFinal = (parcial1Nota * 0.6) + (examenNota * 0.4);

            // Mostrar la nota final en un mensaje
            DisplayAlert("Nota Parcial 1", $"Parcial 1 = {notaFinal}", "Aceptar");

            Navigation.PushAsync(new parcial2(notaFinal, usuario_));
        }
        else
        {
            // Mostrar un mensaje si las entradas no son válidas
            DisplayAlert("Error", "Por favor ingrese números válidos para las notas.", "Aceptar");
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {



    }
}