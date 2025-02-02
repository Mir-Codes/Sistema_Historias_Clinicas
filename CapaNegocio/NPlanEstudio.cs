﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using CapaDatos;

namespace CapaNegocio
{
    public class NPlanEstudio
    {

        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase DPacientes
        //de la CapaDatos
        public static string Insertar(int idpaciente, string listaEstudios)
        {
            DPlanEstudio Obj = new DPlanEstudio();
            Obj.IdPaciente = idpaciente;
            Obj.ListaEstudios = listaEstudios;


            return Obj.Insertar(Obj);
        }

        ////Método Editar que llama al método Editar de la clase DPacientes
        ////de la CapaDatos
        //public static string Editar(int idplanestudio, int idpaciente, string listaEstudios)
        //{
        //    DPlanEstudio Obj = new DPlanEstudio();
        //    Obj.IdPlanEstudio = idplanestudio;
        //    Obj.IdPaciente = idpaciente;
        //    Obj.ListaEstudios = listaEstudios;
        //    return Obj.Editar(Obj);
        //}


        ////Método Eliminar que llama al método Eliminar de la clase DPacientes
        ////de la CapaDatos
        //public static string Eliminar(int idplanestudio)
        //{
        //    DReceta Obj = new DReceta();
        //    Obj.Idplanestudio = idplanestudio;
        //    return Obj.Eliminar(Obj);
        //}



        //Método Mostrar que llama al método Mostrar de la clase DPacientes
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DPlanEstudio().Mostrar();
        }


        //Método CargarNombreExamen que llama al método Mostrar de la clase DPlanEstudio
        //de la CapaDatos
        public static DataTable CargarNombreExamenLab()
        {
            return new DPlanEstudio().CargarNombreExamenLab();
        }


        //Método CargarNombreEstudios que llama al método Mostrar de la clase DPlanEstudio
        //de la CapaDatos
        public static DataTable CargarNombreEstudios()
        {
            return new DPlanEstudio().CargarNombreEstudios();
        }

        public static DataTable Buscar_PlanEstudio_segun_id(int id_planestudio)
        {
            DPlanEstudio Obj = new DPlanEstudio();
            Obj.Id_a_buscar = id_planestudio;
            return Obj.Buscar_PlanEstudio_segun_id(Obj);
        }


    }


}
