namespace hchavezT3.Vistas;

public partial class vLogin : ContentPage
{
    string[] usuarios = { "Carlos", "Ana", "Jose" };
    string[] contraseñas = { "carlos123", "ana123", "jose123" };

    public vLogin()
    {
        InitializeComponent();
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contraseñaIngresada = txtContrasena.Text;

        bool usuarioValido = false;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuarioIngresado && contraseñas[i] == contraseñaIngresada)
            {
                usuarioValido = true;
                break;
            }
        }

        if (usuarioValido)
        {
            Navigation.PushAsync(new parcial1(usuarioIngresado));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseña incorrectas", "cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}