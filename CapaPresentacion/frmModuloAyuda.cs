﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;


namespace CapaPresentacion
{
    public partial class frmModuloAyuda : Form
    {
        public frmModuloAyuda()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.Session_Actual.Acceso.Equals("Administrador"))
            {
                System.Diagnostics.Process.Start("C:\\Users\\Usuario\\Desktop\\Sistema_Historias_Clinicas\\Manuales de Usuario Crystal Clear\\Manual_de_Usuario_Administrador_Crystal_Clear_usando_plantilla.pdf");
            

            }
            else if (frmPrincipal.Session_Actual.Acceso.Equals("Medico"))
            {

                System.Diagnostics.Process.Start("C:\\Users\\Usuario\\Desktop\\Sistema_Historias_Clinicas\\Manuales de Usuario Crystal Clear\\Manual_de_Usuario_Medico_Crystal_Clear_usando_plantilla.pdf");


            }
            else if (frmPrincipal.Session_Actual.Acceso.Equals("Asistente"))
            {

                System.Diagnostics.Process.Start("C:\\Users\\Usuario\\Desktop\\Sistema_Historias_Clinicas\\Manuales de Usuario Crystal Clear\\Manual_de_Usuario_Asistente_Crystal_Clear_usando_plantilla.pdf");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/u/0/folders/1G8cinwenhFmeDiVYBdMFqnaH8gbcohUK");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Historias Clinicas Electronicas 'Crystal Clear' desarrollado por Mirla Montaño para el consultorio del Cardiologo/Internista Dr. Félix Montaño - 2022");
        }
    }
}
