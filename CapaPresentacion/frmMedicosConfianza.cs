﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class frmMedicosConfianza : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;

        public DataTable dbdataset;


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        SqlDataReader dr;



        public frmMedicosConfianza()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.txtNombre_Medico, "Ingrese el Nombre del Médico");
            this.ttMensaje.SetToolTip(this.txtEspecialidad, "Ingrese la especialidad del Médico");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la direccion del Médico");
            this.ttMensaje.SetToolTip(this.txtTelefono, "Ingrese el telefono del Médico");
            this.ttMensaje.SetToolTip(this.txtCorreo, "Ingrese el correo del Médico");

        }

        private void frmMedicosConfianza_Load(object sender, EventArgs e)
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

            this.txtNombre_Medico.Text = string.Empty;
            this.txtEspecialidad.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;



        }

        //Habilitar los controles del formulario
        private void Habilitar()
        {
            this.txtNombre_Medico.Enabled = true;
            this.txtCorreo.Enabled = true;
            this.txtEspecialidad.Enabled = true;
            this.txtDireccion.Enabled = true;
            this.txtTelefono.Enabled = true;

        }

        //Deshabilitar los controles del formulario
        private void Deshabilitar()
        {
            this.txtNombre_Medico.Enabled = false;
            this.txtCorreo.Enabled = false;
            this.txtEspecialidad.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtTelefono.Enabled = false;


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
                this.Deshabilitar();
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }

        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            this.dataListado.Columns["id"].Visible = false;
            this.dataListado.Columns["estado"].Visible = false;
            this.dataListado.Columns["id_referencia"].Visible = false;

        }

        //Método Mostrar
        private void Mostrar()
        {


            this.dataListado.DataSource = NMedicosConfianza.Mostrar();
            if (dataListado.Rows.Count == 0) { MessageBox.Show("Actualmente no tiene ningun registro de medicos de confianza"); }
            this.OcultarColumnas();
            lblTotal.Text = "Total de Colegas: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método BuscarNombre
        private void BuscarNombre()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("nombre LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/

            this.dataListado.DataSource = NMedicosConfianza.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();




            lblTotal.Text = "Total de Colegas: " + Convert.ToString(dataListado.Rows.Count);
        }


        private void BuscarNum_Cedula()
        {

            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("num_cedula LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/




            this.dataListado.DataSource = NPacientes.BuscarNum_Cedula(this.txtBuscar.Text);
            this.OcultarColumnas();

            lblTotal.Text = "Total de Colegas: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar();
            this.txtNombre_Medico.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {



            try
            {
                string rpta = "";
                if (string.IsNullOrEmpty(txtNombre_Medico.Text) || string.IsNullOrEmpty(txtEspecialidad.Text)
                    || string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MensajeError("No se pueden dejar campos vacios");
                    /*errorIcono.SetError(txtNombre, "Ingrese un Valor");
                    errorIcono.SetError(txtApellidos, "Ingrese un Valor");
                    errorIcono.SetError(txtNum_Cedula, "Ingrese un Valor");
                    errorIcono.SetError(txtUsuario, "Ingrese un Valor");
                    errorIcono.SetError(txtPassword, "Ingrese un Valor");*/


                }






                else
                {




                    if (this.IsNuevo)
                    {


                        rpta = NMedicosConfianza.Insertar(this.txtNombre_Medico.Text.Trim().ToUpper(), this.txtEspecialidad.Text.Trim().ToUpper(),
                        this.txtDireccion.Text.Trim().ToUpper(), this.txtTelefono.Text.Trim().ToUpper(), this.txtCorreo.Text.Trim().ToUpper(), "Activo");





                    }
                    else if (this.IsEditar)
                    {


                        rpta = NMedicosConfianza.Editar(this.txtEspecialidad.Text.Trim().ToUpper(),
                        this.txtDireccion.Text.Trim().ToUpper(),this.txtTelefono.Text.Trim().ToUpper(), this.txtCorreo.Text.Trim().ToUpper(), this.cblEstado.Text,1, this.txtNombre_Medico.Text.Trim().ToUpper() );




                    }


                    if (rpta.Equals("OK"))
                    {




                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el medico de confianza");
                            this.OperacionInsertarMedicoConfianza();
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el medico de confianza");
                            this.OperacionEditarMedicoConfianza();
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


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //public bool validarExistePaciente(string ci)
        //{
        //    bool resultado = false;


        //    SqlConnection SqlCon = new SqlConnection();



        //    //Código
        //    SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
        //    SqlCon.Open();
        //    //Establecer el Comando
        //    SqlCommand SqlCmd = new SqlCommand("select * from Paciente where num_cedula ='" + ci + "' ");
        //    SqlCmd.Connection = SqlCon;

        //    //SqlCmd.CommandType = CommandType.StoredProcedure;


        //    try
        //    {

        //        dr = SqlCmd.ExecuteReader();

        //        if (dr.Read())
        //        {
        //            resultado = true;

        //        }

        //        dr.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ha ocurrido un error.", ex.Message);
        //    }

        //    return resultado;

        //}

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtNombre_Medico.Text.Equals(""))
            {
                this.IsEditar = true;
                this.IsNuevo = false;
                this.Botones();
                //this.Habilitar();
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el medico a Modificar");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Especialidad"))
            {
                this.Buscar_Medico_Especialidad();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {

                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Especialidad"))
            {
                this.Buscar_Medico_Especialidad();
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

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {


            this.txtNombre_Medico.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtEspecialidad.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["especialidad"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtCorreo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["correo"].Value);

            this.cblEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);


            this.Deshabilitar();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtNombre_Medico.Text = string.Empty;
            this.Deshabilitar();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los/el registros de medicos ", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Nombre;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Nombre = Convert.ToString(row.Cells[1].Value);
                            rpta = NMedicosConfianza.Anular(Nombre);
                            

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente el medico");
                                this.OperacionAnularMedicoConfianza();
                                
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



        private void OperacionInsertarMedicoConfianza()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Registrado a un medico de confianza.");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }


        private void OperacionEditarMedicoConfianza()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Editado a un medico de confianza.");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";



                
        }



        private void OperacionAnularMedicoConfianza()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2,@d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Anulado a un medico de confianza. ");
            SqlCmd2.Parameters.AddWithValue("@d3", Convert.ToString( Session_Actual.Log));





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            MessageBox.Show("HOLAAAAA :D");


        }

        //Medoto para buscar especialidad  
        private void Buscar_Medico_Especialidad()
        {

            this.dataListado.DataSource = NMedicosConfianza.BuscarEspecialidad(this.txtBuscar.Text);
            this.OcultarColumnas();




            lblTotal.Text = "Total de Colegas: " + Convert.ToString(dataListado.Rows.Count);


        }

        //Metodo para editar medicos

        private void Editar_medicos()
        {



        }

        private void txtNumero_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((!(char.IsDigit(ch))) && Convert.ToInt32(ch) != 8)
            {
                e.Handled = true;

            }
            else if (char.IsControl(ch))
            {
                e.Handled = false;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((!(char.IsDigit(ch))) && Convert.ToInt32(ch) != 8)
            {
                e.Handled = true;

            }
            else if (char.IsControl(ch))
            {
                e.Handled = false;
            }
        }


        public static bool validarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.Replace(email, expresion, string.Empty).Length == 0)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {

        }


        private void txtNombre_Medico_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre_Medico.Text))
            {

                errorIcono.SetError(txtNombre_Medico, "Introduzca el nombre del medico.");
            }
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            frmReportePacientes frm = new frmReportePacientes();
            frm.Show();
        }


        private void label2_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label2, "Campo Obligatorio");
        }

        private void labe4_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label4, "Campo Obligatorio");
        }

        private void labe12_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label12, "Campo Obligatorio");
        }


        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {

                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Especialidad"))
            {
                this.Buscar_Medico_Especialidad();
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (!this.txtNombre_Medico.Text.Equals(""))
            {
                this.IsEditar = true;
                this.IsNuevo = false;
                this.Botones();
                //this.Habilitar();
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el Doctor a Modificar");
            }

        }

        private void txtNombre_Medico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void chkAnular_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkAnular.Checked = true)
            {

                btnAnular.Enabled = true;

            }
            else if (chkAnular.Checked = false) 
            {
                btnAnular.Enabled = false;
            } 
            else { btnAnular.Enabled = false; }
        }

        private void txtNombre_Medico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporteMedicosConfianza frm = new frmReporteMedicosConfianza();
            frm.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtNombre_Medico.Text = string.Empty;
            this.Deshabilitar();
        }
    }


}

