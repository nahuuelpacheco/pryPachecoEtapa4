using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryPachecoEtapa4
{
    public partial class frmEtapa4 : Form
    {
        public frmEtapa4()
        {
            InitializeComponent();
        }
       
        clsVehiculos objAuto = new clsVehiculos();
        clsVehiculos objAvion = new clsVehiculos();
        clsVehiculos objBarco = new clsVehiculos();
        List<clsVehiculos> listaVehiculos = new List<clsVehiculos>(); //Para poder listar
        bool Auto = false;
        bool Avion = false;
        bool Barco = false;

        private void frmEtapa4_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculos();
            objAvion = new clsVehiculos();
            objBarco = new clsVehiculos();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            objAuto.CrearAuto();
            objAuto.pctAuto.Location = new Point(200, 100);
            Controls.Add(objAuto.pctAuto);
            Auto = true;
            if (Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
            }
            if (Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = false;
            }
            lstVehiculos.Items.Clear();//Limpiamos lst que vemos
            listaVehiculos.Clear();//limpiamos lista que no vemos
            listaVehiculos.Add(objAuto);//Agregamos auto
            foreach (clsVehiculos vehiculo in listaVehiculos)//Mostramos en lista
            {
                lstVehiculos.Items.Add(vehiculo.tipoVehiculo);
            }
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            objAvion.CrearAvion();
            objAvion.pctAvion.Location = new Point(200, 100);
            Controls.Add(objAvion.pctAvion);
            Avion = true;
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
            }
            if (Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = false;
            }

            listaVehiculos.Clear();
            lstVehiculos.Items.Clear();
            listaVehiculos.Add(objAvion);
            foreach (clsVehiculos vehiculo in listaVehiculos)
            {
                lstVehiculos.Items.Add(vehiculo.tipoVehiculo);//añadimos los vehiculos que clickeamos anteriormente
            }
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            objBarco.CrearBarco();
            objBarco.pctBarco.Location = new Point(200, 100);
            this.Controls.Add(objBarco.pctBarco);
            Barco = true;
            if (Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
            }
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
            }
            listaVehiculos.Clear();
            lstVehiculos.Items.Clear();
            listaVehiculos.Add(objBarco);
            foreach (clsVehiculos vehiculo in listaVehiculos)
            {
                lstVehiculos.Items.Add(vehiculo.tipoVehiculo);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listaVehiculos.Clear();
            lstVehiculos.Items.Clear();//limpiamos
            objBarco.CrearBarco();
            listaVehiculos.Add(objBarco);
            objAvion.CrearAvion();
            listaVehiculos.Add(objAvion);
            objAuto.CrearAuto();
            listaVehiculos.Add(objAuto);
            foreach (clsVehiculos vehiculo in listaVehiculos)
            {
                lstVehiculos.Items.Add(vehiculo.tipoVehiculo);
            }
        }
    }
}
