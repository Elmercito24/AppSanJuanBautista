using System.Security.Cryptography;

namespace AppSanJuan2025;

public partial class DetalleEventoPage : ContentPage
{
	public DetalleEventoPage(string dia)
    {
		InitializeComponent();
        MostrarDetalle(dia);
    }

    private void MostrarDetalle(string dia)
    {
        switch (dia)
        {
            case "13":
                TituloDia.Text = "13 de Junio - Primer Día de Novena";
                ImagenEvento.Source = "sanjuan.jpg";
                DetalleDia.Text = "Santa Misa, Procesión, Recepción del Santo Patrón San Juan Bautista.";
                break;
            case "14":
                TituloDia.Text = "14 de Junio - Segundo Día de Novena";
                ImagenEvento.Source = "sanjuan.jpg";
                DetalleDia.Text = "Presentación artística: Kelly Saldaña y sus Claveles del Amor.";
                break;
            case "Festival":
                TituloDia.Text = "21 de Junio - Festival del Tamal Chotano";
                ImagenEvento.Source = "festival.jpg";
                DetalleDia.Text = "Concurso del tamal más grande del mundo. Escenificaciones culturales.";
                break;
            case "Identidad":
                TituloDia.Text = "22 de Junio - Día de la Identidad Chotana";
                ImagenEvento.Source = "identidad.jpg";
                DetalleDia.Text = "Misa Te Deum, desfiles, homenajes y presentaciones artísticas.";
                break;
            case "Sanjuanpampa":
                TituloDia.Text = "23 y 24 de Junio - Sanjuanpampa";
                ImagenEvento.Source = "sanjuanpampa.jpg";
                DetalleDia.Text = "Concursos, reinado campesino, artesanía, fulbito femenino, festival de bandas.";
                break;
            default:
                TituloDia.Text = "Día sin programación";
                DetalleDia.Text = "No se encontraron actividades para este día.";
                break;
        }
    }
}