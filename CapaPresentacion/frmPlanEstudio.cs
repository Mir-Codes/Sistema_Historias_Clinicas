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
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmPlanEstudio : Form
    {

        private bool IsNuevo = false;

        public static DUsuario Session_Actual = frmPrincipal.User_Actual;




        /// <summary>
        /// Data to transfer into / out of form
        /// </summary>
        public string Data
        {
            get { return lbl_idplanestudio.Text; }
            set { lbl_idplanestudio.Text = value; }
        }




        public frmPlanEstudio(string cedula)
        {
            InitializeComponent();



        }

        /// <summary>
        /// Event to indicate new data is available
        /// </summary>
        public event EventHandler DataAvailable;
        /// <summary>
        /// Called to signal to subscribers that new data is available
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        /// <summary>
        /// Tell the parent the data is ready.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnSeleccionarPlanEstudio_Click(object sender, EventArgs e)
        {

            //Dentro de este try se hace la insercion de los datos de PlanEstudio a la BD
            try
            {
                string rpta = "";
                if (this.txtNombre_Paciente.Text == string.Empty)
                {
                    MessageBox.Show("No puede dejar campos vacios o sin seleccionar. ", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.tabControl1.SelectedIndex = 1;
                }
                else
                {



                    if (this.IsNuevo)
                    {


                        SqlConnection SqlCon = new SqlConnection();



                        //Código
                        SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                        SqlCon.Open();
                        //Establecer el Comando
                        SqlCommand SqlCmd = new SqlCommand();
                        SqlCmd.Connection = SqlCon;
                        SqlCmd.CommandText = "spinsertar_planestudio";
                        SqlCmd.CommandType = CommandType.StoredProcedure;

                        string hoy = DateTime.Now.ToShortDateString();




                        //este es el mejor metodo para hacerlo un string y separarlo con un salto de linea \n
                        var listaExamenesEstudios = listBox1.Items.Cast<String>().ToList(); //convertir el control en una lista
                        string cadenaExamenesEstudios = string.Join("\n", listaExamenesEstudios); //convertir la lista en un string separando cada linea por una coma


                        SqlCmd.Parameters.AddWithValue("@idpaciente", Buscar_idPac_por_cedula());
                        SqlCmd.Parameters.AddWithValue("@listamedicamentos", cadenaExamenesEstudios);
                        SqlCmd.Parameters.AddWithValue("@fechaemision", hoy);


                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";



                        //Establecer el Comando para traer el id del ultimo row añadido
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = SqlCon;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select @@IDENTITY";
                        int Id_plan_estudio_recien_guardado = Convert.ToInt32(cmd.ExecuteScalar());

                        //se asigna el id al label para mostrar cual es el id del plan estudio recien guardado
                        this.lbl_idplanestudio.Text = Convert.ToString(Id_plan_estudio_recien_guardado);



                    }



                    if (this.IsNuevo)
                    {
                        MessageBox.Show("Se Insertó de forma correcta el plan estudio");
                    }


                    this.IsNuevo = false;
                    this.Deshabilitar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }







            //esto es para enviar la señal al frmHistoria para hacerle saber que la data está disponible
            OnDataAvailable(null);






        }




        private void frmPlanEstudio_Load(object sender, EventArgs e)
        {

            this.listBox1.Items.Add("Laboratorio: ");

            this.listBox2.Items.Add("Estudios: ");




            //Llenar el combobox de Examenes de laboratorio que estan registrados en la BD
            LlenarCbExamenes();

            //Llenar el combobox de Estudios que estan registrados en la BD
            LlenarCbEstudios();




            // Realizar la carga de datos del paciente y bloquear los txtbox
            CargarDatosPaciente();



            //Asignar la fecha de emision de hoy
            this.lbl_fecha_emision.Text = DateTime.Now.ToShortDateString();

            Deshabilitar();




            //en caso de que la historia ya tenga un ID de PlanEstudio almacenado en la BD
            if (this.lbl_idplanestudio.Text == "0")
            {
                //no posee un plan estudio
                this.btnNuevo_PlanEstudio.Enabled = true;
                this.btnAsignar_PlanEstudio.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                //ya tiene un plan estudio asignado
                this.btnNuevo_PlanEstudio.Enabled = false;
                this.btnAsignar_PlanEstudio.Enabled = false;
                this.btnCancelar.Enabled = false;

                //cargar dicho plan estudio
                Cargar_Plan_Estudio_En_Campos();

            }

        }




        private void CargarDatosPaciente()
        {
            // mandar la cedula del paciente a este form y cargar los datos.
            int id_del_paciente_a_cargar;

            id_del_paciente_a_cargar = Buscar_idPac_por_cedula();

            if (id_del_paciente_a_cargar <= 0)
            {
                MessageBox.Show("Este paciente no esta registrado");
            }

        }





        /// <summary>
        /// Es una tabla donde se guardan todos los datos de el Plan Estudioextraidos de un query.
        /// </summary>
        /// <param name="idplanestudio"></param>
        /// <returns></returns>
        private DataTable Datos_PlanEstudio(int idplanestudio)
        {
            //aca se buscará el plan estudio que coincida con ese id exacto

            DataTable DtResultado = new DataTable("Datos_PlanEstudio");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_plan_Estudio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDBuscar = new SqlParameter();
                ParIDBuscar.ParameterName = "@id_plan_estudio";
                ParIDBuscar.SqlDbType = SqlDbType.Int;
                ParIDBuscar.Size = 50;
                ParIDBuscar.Value = idplanestudio;
                SqlCmd.Parameters.Add(ParIDBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }


            return DtResultado;

        }



        private void Cargar_Plan_Estudio_En_Campos()
        {

            DataTable PlanEstudio_del_Paciente = Datos_PlanEstudio(Convert.ToInt32(this.lbl_idplanestudio.Text));

            if (PlanEstudio_del_Paciente.Rows.Count <= 0)
            {

                MessageBox.Show("Este paciente NO tiene plan estudio :s porfavor contacte al admin");
                PlanEstudio_del_Paciente = null;

            }
            else
            {


                //meter los row/column de esa datatable en cada campo del form

                this.lbl_idplanestudio.Text = Convert.ToString(PlanEstudio_del_Paciente.Rows[0][0]);
                this.lbl_fecha_emision.Text = Convert.ToString(PlanEstudio_del_Paciente.Rows[0][3]);

                string examenes_estudios_cadena = Convert.ToString(PlanEstudio_del_Paciente.Rows[0][2]);

                List<string> examenes_estudios_separados_con_coma = examenes_estudios_cadena.Split(new char[] { '\n' }).ToList();

                this.listBox1.DataSource = examenes_estudios_separados_con_coma;



            }


        }







        DataTable dbdataset;

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



        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {

                int id_del_paciente_a_cargar;

                id_del_paciente_a_cargar = Buscar_idPac_por_cedula();

                if (id_del_paciente_a_cargar > 0)
                {

                }
                else
                {
                    MessageBox.Show("Este paciente no esta registrado");
                }

            }
        }


        private int Buscar_idPac_por_cedula()
        {

            string cedula_del_pac = this.txtCedulaPac_Estudio.Text;

            DataTable paciente_tabla = new DataTable();

            paciente_tabla = NPacientes.BuscarNum_Documento(cedula_del_pac);

            int id_del_pac = 0;

            if (paciente_tabla.Rows.Count == 0)
            {
                MessageBox.Show("no existe ese paciente");
                id_del_pac = 0;
            }
            else
            {

                id_del_pac = Convert.ToInt32(paciente_tabla.Rows[0][0]);
                string nombre_del_pac = Convert.ToString(paciente_tabla.Rows[0][1]);
                string sexo_del_pac = Convert.ToString(paciente_tabla.Rows[0][5]);

                this.txtNombre_Paciente.Text = nombre_del_pac;
                this.txtSexo.Text = sexo_del_pac;



                //lblTotal.Text = "Total de Pacientes: " + Convert.ToString(paciente_tabla.Rows.Count);
            }

            return id_del_pac;

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            string laboratorio = this.cbLab.Text;
            
            //string nota = this.txtNota.Text;
            // Add more items to the list  
            //listBox1.Items.Add(examen + " " + muestra + "  \n Notas: " + nota + "  \n");


            // Add more items to the list  
            listBox1.Items.Add(laboratorio + " ");

            
        }

        private void btnGuardar_informe_Click(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";
                if (this.txtNombre_Paciente.Text == string.Empty)
                {
                    MessageBox.Show("No puede dejar campos vacios o sin seleccionar. ", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.tabControl1.SelectedIndex = 1;
                }
                else
                {



                    if (this.IsNuevo)
                    {


                        SqlConnection SqlCon = new SqlConnection();



                        //Código
                        SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                        SqlCon.Open();
                        //Establecer el Comando
                        SqlCommand SqlCmd = new SqlCommand();
                        SqlCmd.Connection = SqlCon;
                        SqlCmd.CommandText = "spinsertar_planestudio";
                        SqlCmd.CommandType = CommandType.StoredProcedure;


                        string hoy = DateTime.Now.ToShortDateString();


                        //construir el string de Laboratorios
                        StringBuilder sb_lab = new StringBuilder();
                        foreach (string a in listBox1.Items)
                            sb_lab.Append(a);

                        string laboratorios_all = sb_lab.ToString();



                        //construir el string de Examen
                        StringBuilder sb_estudios = new StringBuilder();
                        foreach (string b in listBox2.Items)
                            sb_estudios.Append(b);

                        string estudios_all = sb_estudios.ToString();




                        SqlCmd.Parameters.AddWithValue("@idpaciente", Buscar_idPac_por_cedula());
                        SqlCmd.Parameters.AddWithValue("@laboratorios_all", laboratorios_all);
                        SqlCmd.Parameters.AddWithValue("@estudios_all", estudios_all);
                        SqlCmd.Parameters.AddWithValue("@fechaemision", hoy);


                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




                    }



                    if (this.IsNuevo)
                    {
                        MessageBox.Show("Se Insertó de forma correcta el plan de estudio");
                    }


                    this.IsNuevo = false;
                    this.Limpiar();
                    this.Deshabilitar();




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }



        private void Deshabilitar()
        {
            this.groupBox3.Enabled = false;



        }

        private void Habilitar()
        {

            this.groupBox3.Enabled = true;


        }




        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAñadirEstudios_Click(object sender, EventArgs e)
        {
            string estudios = this.cbEstudios.Text;

            // Add more items to the list  
            listBox2.Items.Add(estudios + " " );
        }

        private void btnNuevo_informe_Click(object sender, EventArgs e)
        {
            Habilitar();
            IsNuevo = true;
        }

        private void btnQuitarLab_Click(object sender, EventArgs e)
        {

        }
    }
}
