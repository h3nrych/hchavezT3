namespace hchavezT3.Vistas;

public partial class parcial2 : ContentPage
{
    private double _notaFinal;
    private string _usuario;

    public parcial2(double notaFinal, string usuario)
    {
        InitializeComponent();

        // Almacenar la nota final en el campo de clase
        _notaFinal = notaFinal;
        _usuario = usuario;

        DisplayAlert("notaparcial1", _notaFinal.ToString(), "ok");
        notafinal1.Text = "Nota Primer Parcial: " + _notaFinal;
        lblUsuario.Text = "Usuario: " + usuario;


    }


    private void Button_Clicked(object sender, EventArgs e)
    {
        // Obtener las notas del parcial y del examen
        if (double.TryParse(entrydeberes2.Text, out double parcialNota2) &&
            double.TryParse(entryexamen2.Text, out double examenNota2))
        {
            // Calcular la nota final
            double notaFinal2 = (parcialNota2 * 0.6) + (examenNota2 * 0.4);

            // Calcular la suma de las medias de las notas
            double sumaMedias = (_notaFinal / 2) + (notaFinal2 / 2);
            DateTime fechaSeleccionada = dateparcial2.Date;

            // Mostrar la suma de las medias en un mensaje
            DisplayAlert("Notas Finales: \nUsuario: " + _usuario, $"Parcial 1: {_notaFinal}\nParcial 2: {notaFinal2}\nPromedio Final: {sumaMedias}\nFecha : {fechaSeleccionada.ToString("dd/MM/yyyy")}", "Aceptar");
        }
        else
        {
            // Mostrar un mensaje si las entradas no son válidas
            DisplayAlert("Error", "Por favor ingrese números válidos para las notas.", "Aceptar");
        }
    }
}