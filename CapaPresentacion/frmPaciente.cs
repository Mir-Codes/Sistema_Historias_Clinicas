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


namespace CapaPresentacion
{
    public partial class frmPaciente : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;

        public DataTable dbdataset;


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        SqlDataReader dr;



        public frmPaciente()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre_Paciente, "Ingrese el Nombre del Paciente");
            this.ttMensaje.SetToolTip(this.cblTipo_Cedula, "Seleccione el tipo de Cedula");
            this.ttMensaje.SetToolTip(this.txtNumero_Cedula, "Ingrese el numero de Cedula");
            this.ttMensaje.SetToolTip(this.txtCorreo, "Ingrese el correo");
            this.ttMensaje.SetToolTip(this.txtTalla, "Ingrese la talla del paciente");
            this.ttMensaje.SetToolTip(this.cblSexo, "Seleccione el sexo del paciente");
            this.ttMensaje.SetToolTip(this.cblEstado_Civil, "Seleccione el estado civil del paciente");

            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la direccion del paciente");
            this.ttMensaje.SetToolTip(this.txtOcupacion, "Ingrese la ocupacion del paciente");
            this.ttMensaje.SetToolTip(this.txtTelefono, "Ingrese el telefono del paciente");

            this.btnAnular.Enabled = false;
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {


            this.Mostrar();
            this.Deshabilitar();
            this.Botones();
            SoloPacientesActivosyVivos();

            this.cblEstado.SelectedIndex = 0;


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

            this.txtNombre_Paciente.Text = string.Empty;
            this.cblTipo_Cedula.SelectedIndex = -1;
            this.txtNumero_Cedula.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtPeso.Text = string.Empty;
            this.txtTalla.Text = string.Empty;
            this.cblEstado_Civil.SelectedIndex = -1;
            this.txtDireccion.Text = string.Empty;
            this.txtOcupacion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.dtpFecha_Nacimiento.Value = DateTime.Now;
            this.cblSexo.SelectedIndex = -1;



        }

        //Habilitar los controles del formulario
        private void Habilitar()
        {
            this.txtIdpaciente.Enabled = true;
            this.txtNombre_Paciente.Enabled = true;
            this.txtNumero_Cedula.Enabled = true;
            this.txtCorreo.Enabled= true;
            this.txtPeso.Enabled = true;
            this.txtTalla.Enabled = true;
            this.cblTipo_Cedula.Enabled = true;
            this.cblEstado.Enabled = true;
            this.cblEstado_Civil.Enabled = true;
            this.cblSexo.Enabled = true;
            this.txtDireccion.Enabled= true;
            this.txtOcupacion.Enabled = true;
            this.txtTelefono.Enabled= true;
            this.dtpFecha_Nacimiento.Enabled = true;

        }

        //Deshabilitar los controles del formulario
        private void Deshabilitar()
        {
            this.txtIdpaciente.Enabled = false;
            this.txtNombre_Paciente.Enabled = false;
            this.txtNumero_Cedula.Enabled = false;
            this.txtCorreo.Enabled = false;
            this.txtPeso.Enabled = false;
            this.txtTalla.Enabled = false;
            this.cblTipo_Cedula.Enabled = false;
            this.cblEstado.Enabled = false;
            this.cblEstado_Civil.Enabled = false;
            this.cblSexo.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtOcupacion.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.dtpFecha_Nacimiento.Enabled = false;

        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar();
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Deshabilitar();
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns["is_dead"].Visible = false;

        }

        //Método Mostrar
        private void Mostrar()
        {


            this.dataListado.DataSource = NPacientes.Mostrar();
            if (dataListado.Rows.Count == 0) { MessageBox.Show("Actualmente no tiene ningun registro en Pacientes"); }
            this.OcultarColumnas();
            SoloPacientesActivosyVivos();
            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
           
        }


        //Método BuscarNombre
        private void BuscarNombre()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("nombre LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/
            

            this.dataListado.DataSource = NPacientes.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            SoloPacientesActivosyVivos();



            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
        }


        private void BuscarNum_Cedula()
        {

            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("num_cedula LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/




            this.dataListado.DataSource = NPacientes.BuscarNum_Cedula(this.txtBuscar.Text);
            this.OcultarColumnas();
            SoloPacientesActivosyVivos();
            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar();
            this.cblTipo_Cedula.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {



            try
            {
                string rpta = "";
                if (string.IsNullOrEmpty(txtNombre_Paciente.Text) || cblTipo_Cedula.SelectedIndex == -1 || cblSexo.SelectedIndex == -1 || cblEstado_Civil.SelectedIndex == -1 || string.IsNullOrEmpty(txtNumero_Cedula.Text)
                    || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtPeso.Text) || string.IsNullOrEmpty(txtTalla.Text) || string.IsNullOrEmpty(txtTelefono.Text))
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


                        if (this.validarExistePaciente(this.txtNumero_Cedula.Text) == true)
                        {

                            MensajeError("Ya existe un paciente con este numero de cedula.");

                        }
                        else
                        {

                            rpta = NPacientes.Insertar(this.txtNombre_Paciente.Text.Trim().ToUpper(),
                            this.cblTipo_Cedula.Text, this.txtNumero_Cedula.Text.Trim().ToUpper(),
                            this.dtpFecha_Nacimiento.Text, this.cblSexo.Text, this.cblEstado_Civil.Text,
                            this.txtDireccion.Text.Trim().ToUpper(), this.txtOcupacion.Text.Trim().ToUpper(),
                            txtTelefono.Text.Trim().ToUpper(), txtCorreo.Text.Trim().ToUpper(), this.txtPeso.Text.Trim().ToUpper(), this.txtTalla.Text.Trim().ToUpper(), this.cblEstado.Text);


                            if (rpta.Equals("OK"))
                            {




                                if (this.IsNuevo)
                                {
                                    this.MensajeOk("Se Insertó de forma correcta el paciente");
                                    this.OperacionInsertarPaciente();
                                }
                                else
                                {
                                    this.MensajeOk("Se Actualizó de forma correcta el paciente");
                                    this.OperacionEditarPaciente();
                                }

                            }
                            else
                            {


                                this.MensajeError(rpta);

                                MessageBox.Show("woopsss insertar falló :(");

                            }

                        }






                    }
                    else if (this.IsEditar)
                    {


                        if (this.validarExistePaciente(this.txtNumero_Cedula.Text) == true)
                        {

                            rpta = NPacientes.Editar(Convert.ToInt32(this.txtIdpaciente.Text), this.txtNombre_Paciente.Text.Trim().ToUpper(),
                            this.cblTipo_Cedula.Text, this.txtNumero_Cedula.Text.Trim().ToUpper(),
                            this.dtpFecha_Nacimiento.Text, this.cblSexo.Text, this.cblEstado_Civil.Text,
                            this.txtDireccion.Text.Trim().ToUpper(), this.txtOcupacion.Text.Trim().ToUpper(),
                            txtTelefono.Text.Trim().ToUpper(), txtCorreo.Text.Trim().ToUpper(), this.txtPeso.Text.Trim().ToUpper(), this.txtTalla.Text.Trim().ToUpper(), this.cblEstado.Text);


                        }
                        else
                        {
                            MensajeError("No puede editar un registro que no existe. Porfavor, revise nuevamente los datos");
                        }

                        if (rpta.Equals("OK"))
                        {




                            if (this.IsNuevo)
                            {
                                this.MensajeOk("Se Insertó de forma correcta el paciente");
                                this.OperacionInsertarPaciente();
                            }
                            else
                            {
                                this.MensajeOk("Se Actualizó de forma correcta el paciente");
                                this.OperacionEditarPaciente();
                            }

                        }
                        else
                        {


                            this.MensajeError(rpta);

                            MessageBox.Show("woopsss el editar falló :(");

                        }

                    }


                 

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.txtIdpaciente.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }


        public bool validarExistePaciente(string ci)
        {
            bool resultado = false;


            SqlConnection SqlCon = new SqlConnection();



            //Código
            SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon.Open();
            //Establecer el Comando
            SqlCommand SqlCmd = new SqlCommand("select * from Paciente where num_cedula ='" + ci + "' and estado = 'Activo' ");
            SqlCmd.Connection = SqlCon;

            //SqlCmd.CommandType = CommandType.StoredProcedure;


            try
            {

                dr = SqlCmd.ExecuteReader();

                if (dr.Read())
                {
                    resultado = true;

                }

                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.", ex.Message);
            }

            return resultado;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdpaciente.Text.Equals(""))
            {
                this.IsEditar = true;
                this.IsNuevo = false;
                this.Botones();
                //this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el paciente a Modificar");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Cedula"))
            {
                this.BuscarNum_Cedula();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Cedula"))
            {
                this.BuscarNum_Cedula();
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
            // tengo que hacer un if aca para validar que el campo esta vacio !!

            if (dataListado.Rows != null && dataListado.Rows.Count != 0)
            {
               

                this.txtIdpaciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpaciente"].Value);
                this.txtNombre_Paciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
                this.cblTipo_Cedula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_cedula"].Value);
                this.txtNumero_Cedula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_cedula"].Value);
                this.dtpFecha_Nacimiento.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha_nacimiento"].Value);
                this.cblSexo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sexo"].Value);
                this.cblEstado_Civil.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado_civil"].Value);

                this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
                this.txtOcupacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["ocupacion"].Value);
                this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
                this.txtCorreo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["correo"].Value);



                this.txtPeso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["peso"].Value);
                this.txtTalla.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["talla"].Value);
                this.cblEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);


                this.Deshabilitar();
                this.btnEditar.Enabled = true;
            }
            else
            {

                MessageBox.Show("ERROR!! La lista esta vacia, por favor revise bien las credenciales que desea buscar");

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdpaciente.Text = string.Empty;
            this.Deshabilitar();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los/el pacientes", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NPacientes.Anular(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente El Paciente");
                                //this.OperacionAnularPaciente();
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



        private void OperacionInsertarPaciente()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Registrado a un paciente.");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEditarPaciente()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario " + Session_Actual.Log + " ha Editado un paciente. ");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);




            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionAnularPaciente()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario " + Session_Actual.Log + " ha Anulado a un paciente. ");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




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
            if (validarEmail(this.txtCorreo.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no valido, el correo debe cumplir con un formato: nombre@dominio.com , " + "debe escribir un correo valido.", "Validacion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCorreo.SelectAll();
                this.txtCorreo.Focus();

            }
        }

        private void cblTipo_Cedula_Leave(object sender, EventArgs e)
        {
            //if (cblTipo_Cedula.SelectedIndex == -1)
            //{
            //    errorIcono.SetError(cblTipo_Cedula, "Seleccione una opción");
            //}
        }

        private void txtNombre_Paciente_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtNombre_Paciente.Text))
            //{

            //    errorIcono.SetError(txtNombre_Paciente, "Introduzca el nombre del paciente.");
            //}
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            frmReportePacientes frm = new frmReportePacientes();
            frm.Show();
        }


        private void label12_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label12, "Campo Obligatorio");
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label2, "Campo Obligatorio");
        }

        private void btnSangre_Click(object sender, EventArgs e)
        {
            frmTipoSangre frm = new frmTipoSangre();

            frm.ShowDialog();

        }

        //Filtro de Paciente activo
        private void SoloPacientesActivosyVivos()
        {

            (dataListado.DataSource as DataTable).DefaultView.RowFilter = string.Format("estado = 'Activo' and is_dead = '0'");


        }
      

        private void txtNombre_Paciente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtPeso.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }



        }



        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtTalla.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void dtpFecha_Nacimiento_ValueChanged(object sender, EventArgs e)
        {

           // this.txtEdadSuc.Text = age.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdpaciente.Text = string.Empty;
            this.Deshabilitar();

        }

        private void dtpFecha_Nacimiento_CloseUp(object sender, EventArgs e)
        {

          

                // Save today's date.
                var today = DateTime.Today;

                // Calculate the age.
                var age = today.Year - dtpFecha_Nacimiento.Value.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (dtpFecha_Nacimiento.Value.Date > today.AddYears(-age)) age--;

                if (age < 12)
                {
                    MessageBox.Show("El paciente tiene que ser mayor a 12 años, para poder resivir una consulta");
                }

            

        }
    }
}
