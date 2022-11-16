using System.Collections.ObjectModel;
namespace AS2223_4G_INF_CangiottiFederico_Figure;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        lstRisultati.ItemsSource = dsFigure;
	}

    public class Item
    {
        public string PerimetroArea { get; set; }
        public string Figura { get; set; }
    }
    ObservableCollection<Item> dsFigure = new ObservableCollection<Item>();

    private void cmbFigure_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (cmbFigure.SelectedItem)
		{
			case "quadrato":
                lblBase.IsVisible= false;
                txtBase.IsVisible= false;
                lblAltezza.IsVisible= false;
                txtAltezza.IsVisible = false;
                lblRaggio.IsVisible= false;
                txtRaggio.IsVisible = false;

                lblLato.IsVisible = true;
                txtLato.IsVisible = true;
                break;
            case "rettangolo":
                lblLato.IsVisible = false;
                txtLato.IsVisible = false;
                lblRaggio.IsVisible = false;
                txtRaggio.IsVisible = false;

                lblBase.IsVisible = true;
                txtBase.IsVisible = true;
                lblAltezza.IsVisible = true;
                txtAltezza.IsVisible = true;
                break;
            case "cerchio":
                lblLato.IsVisible = false;
                txtLato.IsVisible = false;
                lblBase.IsVisible = false;
                txtBase.IsVisible = false;
                lblAltezza.IsVisible = false;
                txtAltezza.IsVisible = false;

                lblRaggio.IsVisible = true;
                txtRaggio.IsVisible = true;
                break;
        }
    }

    private void btnVisualizza_Clicked(object sender, EventArgs e)
    {
        switch (cmbFigure.SelectedItem)
        {
            case "quadrato":
                CalcolaQuadrato();
                break;
            case "rettangolo":
                CalcolaRettangolo();
                break;
            case "cerchio":
                CalcolaCerchio();
                break;
        }
    }

    void CalcolaQuadrato()
    {
        Quadrato q = new Quadrato(Convert.ToDouble(txtLato.Text));
        dsFigure.Add(
                new Item()
                {
                    PerimetroArea = $"{q.Perimetro()} - {q.Area()}",
                    Figura = $"{q.NomeFigura}"
                }
            );
    }

    void CalcolaRettangolo()
    {
        Rettangolo r = new Rettangolo(Convert.ToDouble(txtBase.Text), Convert.ToDouble(txtAltezza.Text));
        dsFigure.Add(
                new Item()
                {
                    PerimetroArea = $"{r.Perimetro()} - {r.Area()}",
                    Figura = $"{r.NomeFigura}"
                }
            );
    }

    void CalcolaCerchio()
    {
        Cerchio c = new Cerchio(Convert.ToDouble(txtRaggio.Text));
        dsFigure.Add(
                new Item()
                {
                    PerimetroArea = $"{c.Perimetro()} - {c.Area()}",
                    Figura = $"{c.NomeFigura}"
                }
            );
    }
}
