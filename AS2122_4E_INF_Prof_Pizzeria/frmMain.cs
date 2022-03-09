namespace AS2122_4E_INF_Prof_Pizzeria
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            int nPizze;

            switch (cmbTipoPizza.Text)
            {
                case "MARGHERITA":
                    lstVisualizza.Items.Add("MARGHERITA (" + txtQuantita.Text +")");
                    nPizze = Convert.ToInt32(lblMargherita.Text);

                    lblMargherita.Text = Convert.ToString(nPizze + Convert.ToInt32(txtQuantita.Text));
                    break;

                case "VERDURE":
                    lstVisualizza.Items.Add("VERDURE (" + txtQuantita.Text + ")");
                    break;

                case "4 STAGIONI":
                    lstVisualizza.Items.Add("4STAGIONI (" + txtQuantita.Text + ")");
                    break;
            }
        }
    }
}