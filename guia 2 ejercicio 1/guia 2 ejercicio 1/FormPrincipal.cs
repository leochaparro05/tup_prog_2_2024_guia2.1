using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia_2_ejercicio_1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        departamentoVehicular objdepartamentovehi = new departamentoVehicular();
        persona cliente;
        int cont = 0;
        private void BTNregistrar_Click(object sender, EventArgs e)
        {
           
            RegistrarPersona objventana = new RegistrarPersona();
            if (objventana.ShowDialog()== DialogResult.OK)
            {
               cliente = new persona(Convert.ToInt32(objventana.TBdni.Text), objventana.TBnombre.Text);   
            }

            registroVehiculos a = objdepartamentovehi.registrarVehiculos(cliente);
            LBregistrar.Items.Add(cliente.Nombre + "DNI" + cliente.DNI);
            LBregistrar.Items.Add(a.Verdetalle());
            cont++;

            LBregistrar.Items.Clear();
        }

        private void BTNverRegistro_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < cont; i++)
            {
                registroVehiculos p = objdepartamentovehi.Verregistro(i);
                LBverRegisro.Items.Add(p.Verdetalle());

            }
           
        }
    }
}
