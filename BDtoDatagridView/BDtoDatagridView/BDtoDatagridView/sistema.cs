using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDtoDatagridView
{
    public partial class sistema : Form
    {
        public sistema()
        {
            InitializeComponent();
        }

        private void sistema_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdproyecto01DataSet1.Base_Med' Puede moverla o quitarla según sea necesario.
            this.base_MedTableAdapter.Fill(this.bdproyecto01DataSet1.Base_Med);
            if (Conexion.Open() != null)
            {
                vista.DataSource = dtusuario.Fill();
            }
        }
    }
}
