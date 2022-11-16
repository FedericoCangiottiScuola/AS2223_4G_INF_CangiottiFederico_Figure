namespace AS2223_4G_INF_CangiottiFederico_Figure;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void cmbFigure_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblPerimetro.Text = "...";
        lblArea.Text = "...";
        lblFigura.Text = "...";

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
        lblPerimetro.Text = q.Perimetro().ToString();
        lblArea.Text = q.Area().ToString();
        lblFigura.Text = q.NomeFigura;
    }

    void CalcolaRettangolo()
    {
        Rettangolo r = new Rettangolo(Convert.ToDouble(txtBase.Text), Convert.ToDouble(txtAltezza.Text));
        lblPerimetro.Text = r.Perimetro().ToString();
        lblArea.Text = r.Area().ToString();
        lblFigura.Text = r.NomeFigura;
    }

    void CalcolaCerchio()
    {
        Cerchio c = new Cerchio(Convert.ToDouble(txtRaggio.Text));
        lblPerimetro.Text = c.Perimetro().ToString();
        lblArea.Text = c.Area().ToString();
        lblFigura.Text = c.NomeFigura;
    }
}
