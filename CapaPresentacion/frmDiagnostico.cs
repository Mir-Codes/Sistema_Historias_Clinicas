﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class frmDiagnostico : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;

        public DataTable dbdataset;


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        //frmMenu menu = new frmMenu();

        public frmDiagnostico()
        {
            InitializeComponent();

           

            this.ttMensaje.SetToolTip(this.txtEnfermedad, "Ingrese la enfermedad");

            this.ttMensaje.SetToolTip(this.txtidDiagnostico, "Ingrese el tipo de diagnostico");
        }


       

        private void frmDiagnostico_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Deshabilitar();
            this.Botones();
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtidDiagnostico.Text = string.Empty;
            
            this.txtEnfermedad.Text = string.Empty;
            this.txtTipo.Text = string.Empty;


        }

        //Habilitar los controles del formulario
        private void Habilitar()
        {
            this.txtidDiagnostico.Enabled = true;
            
            this.txtEnfermedad.Enabled = true;
            this.txtTipo.Enabled = true;


        }
        //Deshabilitar los controles del formulario
        private void Deshabilitar()
        {
            this.txtidDiagnostico.Enabled = false;
            
            this.txtEnfermedad.Enabled = false;
            this.txtTipo.Enabled = false;


        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar();
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Deshabilitar();;
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }

        }


        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            //this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns["estado"].Visible = false;

        }


        //Método Mostrar
        private void Mostrar()
        {

            this.dataListado.DataSource = NDiagnostico.Mostrar();
            if (dataListado.Rows.Count == 0) { MessageBox.Show("Actualmente no tiene ningun registro en Diagnostico"); }
            this.OcultarColumnas();
            lblTotal.Text = "Total de Diagnosticos: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarCodigo
        private void BuscarCodigo()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("codigo LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/

            this.dataListado.DataSource = NDiagnostico.BuscarCodigo(this.txtBuscar.Text);
            this.OcultarColumnas();



            lblTotal.Text = "Total de Diagnosticos: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método BuscarEnfermedad
        private void BuscarEnfermedad()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("enfermedad LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/


            this.dataListado.DataSource = NDiagnostico.BuscarEnfermedad(this.txtBuscar.Text);
            this.OcultarColumnas();


            lblTotal.Text = "Total de Diagnosticos: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método BuscarTipo
        private void BuscarTipo()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("tipo LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/


            this.dataListado.DataSource = NDiagnostico.BuscarTipo(this.txtBuscar.Text);
            this.OcultarColumnas();


            lblTotal.Text = "Total de Diagnosticos: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                string rpta2 = "";
                if ( this.txtEnfermedad.Text == string.Empty || this.txtTipo.Text == string.Empty)
                {
                    MensajeError("No se pueden dejar campos vacios");

                }
                else
                {



                    if (this.IsNuevo)
                    {


                        rpta = NDiagnostico.Insertar(
                        this.txtEnfermedad.Text.Trim().ToUpper(),
                        this.txtTipo.Text.Trim().ToUpper(), "Activo");








                    }
                    else
                    {



                        rpta = NDiagnostico.Editar(Convert.ToInt32(this.txtidDiagnostico.Text),
                         this.txtEnfermedad.Text.Trim().ToUpper(),
                         this.txtTipo.Text.Trim().ToUpper());

                        



                    }

                    if (rpta.Equals("OK"))
                    {




                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el diagnostico");
                            this.OperacionInsertarDiagnostico();
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el diagnostico");
                            this.OperacionEditarDiagnostico();
                        }

                    }
                    else
                    {


                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.txtidDiagnostico.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtidDiagnostico.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar();
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el diagnostico a Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Deshabilitar();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbBusquedaDiag.Text.Equals("Codigo"))
            {



                this.BuscarCodigo();
            }
            else if (this.cmbBusquedaDiag.Text.Equals("Enfermedad"))
            {
                this.BuscarEnfermedad();
            }

            else
            {


                this.BuscarTipo();

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cmbBusquedaDiag.Text.Equals("Codigo"))
            {



                this.BuscarCodigo();
            }
            else if (this.cmbBusquedaDiag.Text.Equals("Enfermedad"))
            {
                this.BuscarEnfermedad();
            }

            else
            {


                this.BuscarTipo();

            }
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
                this.btnAnular.Enabled = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
                this.btnAnular.Enabled = false;
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtidDiagnostico.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["iddiagnostico"].Value);
            
            this.txtEnfermedad.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["enfermedad"].Value);
            this.txtTipo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo"].Value);
            this.TxtEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);
        }
            
        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los/el diagnostico", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {

                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NDiagnostico.Anular(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anulo Correctamente El Diagnostico");
                                this.OperacionEliminarDiagnostico();
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }






                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }





        private void OperacionInsertarDiagnostico()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2, @d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Registrado un Diagnostico.");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);




            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEditarDiagnostico()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2, @d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Editado un diagnostico.");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);




            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEliminarDiagnostico()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2, @d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Anulado un diagnostico.");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);



            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void lblCampoObligatorio_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.lblCampoObligatorio, "Campo Obligatorio");
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label3, "Campo Obligatorio");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporteDiagnosticos frm = new frmReporteDiagnosticos();
            frm.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Deshabilitar();
        }
    }
}
