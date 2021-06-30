using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Llama;
using Plaice;


namespace SPPIDPlaceSymbol
{
    public partial class Form1 : Form
    {
        private string symbolPath;
        
        private LMADataSource datasource;
        private _Placement placement;

        public Form1()
        {
            InitializeComponent();

            symbolPath = tbSymbolPath.Text;
            datasource = new LMADataSource();
        }

        private void btnSPPIDPlaceSymbolTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(symbolPath))
                throw new ArgumentNullException(nameof(symbolPath));

            try
            {
                placement = new Placement();
                LMSymbol symbol = placement.PIDPlaceSymbol(symbolPath, 0.183, 0.235);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
