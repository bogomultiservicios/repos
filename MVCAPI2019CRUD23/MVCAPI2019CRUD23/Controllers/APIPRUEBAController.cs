using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCAPI2019CRUD23.Models;
using System.Text.Json;

namespace MVCAPI2019CRUD23.Controllers
{
    public class APIPRUEBAController : ApiController
    {
        // GET: api/APIPRUEBA
        //public IEnumerable<string> Get()
        //{
        //    //return new string[] { "value1 hola mundo", "value2" };

        //    PRUEBASABCEntities db = new PRUEBASABCEntities();
        //    List<string> resultadoDBA = new List<string>();
        //    //VEHICULOS MiCarro = new VEHICULOS();
        //    //var busqueda = from carro in db.VEHICULOS
        //    //            select new
        //    //            {
        //    //                idvehiculoG = carro.IDVEHICULO,
        //    //                marcaG= carro.MARCA,
        //    //                colorG= carro.COLOR,
        //    //                modeloG= carro.MODELO,
        //    //                precioG= carro.PRECIO,
        //    //                fechaImpG= carro.FECHARECEPCION,
        //    //                estadoG= carro.ESTADO,
        //    //                registroG= carro.REGISTRO
        //    //            };

        //    var busqueda = from carro in db.VEHICULOS
        //                   select carro;



        //    ////foreach (var registro in busqueda)
        //    ////{
        //    ////    resultado =resultado + registro.ToString() + ",";
        //    ////}
        //    ////    return new string[] { resultado.ToString() };

        //    //SqlConnection con = new SqlConnection("Data Source=LAPTOP-31I7SPN5/SQLEXPRESS;Initial Catalog=PRUEBASABC;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        //    //SqlCommand cmdo = con.CreateCommand();
        //    //con.Open();

        //    //cmdo.CommandType = System.Data.CommandType.StoredProcedure;
        //    //cmdo.CommandText = "BUSCARVEHICULO";
        //    //cmdo.Parameters.Add("@IDVEHICULO", System.Data.SqlDbType.Int).Value = 0;
        //    //con.Close();

        //    //------------------Funciona---------------------
        //    foreach (var registro in busqueda)
        //    {
        //        resultadoDBA.Add(registro.IDVEHICULO.ToString() +","+
        //                          registro.MARCA.ToString()+","+
        //                          registro.MODELO.ToString()+ ","+
        //                          registro.PRECIO.ToString()+ ","+
        //                          registro.FECHARECEPCION.ToString()+ ","+
        //                          registro.REGISTRO.ToString());
        //    }
        //    //-----------------------------------------------
        //    //resultadoDBA.Add(JsonSerializer.Serialize(busqueda));
        //    //resultadoDBA.Add(busqueda.ToString());// si fuciona la linea


        //    return resultadoDBA;
        //}

        // GET: api/APIPRUEBA/5
        public IEnumerable<VEHICULOS> Get()
        {
            //return new string[] { "value1 hola mundo", "value2" };

            //PRUEBASABCEntities db = new PRUEBASABCEntities();
            List<VEHICULOS> resultadoDBA = new List<VEHICULOS>();
            //VEHICULOS MiCarro = new VEHICULOS();
            //var busqueda = from carro in db.VEHICULOS
            //            select new
            //            {
            //                idvehiculoG = carro.IDVEHICULO,
            //                marcaG= carro.MARCA,
            //                colorG= carro.COLOR,
            //                modeloG= carro.MODELO,
            //                precioG= carro.PRECIO,
            //                fechaImpG= carro.FECHARECEPCION,
            //                estadoG= carro.ESTADO,
            //                registroG= carro.REGISTRO
            //            };

            //var busqueda = from carro in db.VEHICULOS
            //               select carro;



            ////foreach (var registro in busqueda)
            ////{
            ////    resultado =resultado + registro.ToString() + ",";
            ////}
            ////    return new string[] { resultado.ToString() };

            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-31I7SPN5/SQLEXPRESS;Initial Catalog=PRUEBASABC;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            //SqlCommand cmdo = con.CreateCommand();
            //con.Open();

            //cmdo.CommandType = System.Data.CommandType.StoredProcedure;
            //cmdo.CommandText = "BUSCARVEHICULO";
            //cmdo.Parameters.Add("@IDVEHICULO", System.Data.SqlDbType.Int).Value = 0;
            //con.Close();

            //------------------Funciona---------------------
            //foreach (var registro in busqueda)
            //{
            //    resultadoDBA.Add(registro.IDVEHICULO + 
            //                      registro.MARCA.ToString() + "," +
            //                      registro.MODELO.ToString() + "," +
            //                      registro.PRECIO.ToString() + "," +
            //                      registro.FECHARECEPCION.ToString() + "," +
            //                      registro.REGISTRO.ToString());
            //}
            //-----------------------------------------------
            //resultadoDBA.Add(JsonSerializer.Serialize(busqueda));
            //resultadoDBA.Add(busqueda.ToString());// si fuciona la linea

            using (PRUEBASABCEntities db = new PRUEBASABCEntities()) 
            {
                return db.VEHICULOS.Where(e => e.REGISTRO == "ACTIVO").ToList();
            }
                //return resultadoDBA;
        }
        public string Get([FromUri]int id)
        {
            //return "retorno";
            PRUEBASABCEntities db = new PRUEBASABCEntities();
            string resultadoDBA="";

            var busqueda = from carro in db.VEHICULOS
                           where carro.IDVEHICULO == id
                           select new
                           {
                               idvehiculoG = carro.IDVEHICULO,
                               marcaG = carro.MARCA,
                               colorG = carro.COLOR,
                               modeloG = carro.MODELO,
                               precioG = carro.PRECIO,
                               fechaImpG = carro.FECHARECEPCION,
                               estadoG = carro.ESTADO,
                               registroG = carro.REGISTRO
                           };

            foreach (var registro in busqueda)
            {
                resultadoDBA =registro.ToString();
            }

            return resultadoDBA;

        }

        // POST: api/APIPRUEBA
        //

        public void Post([FromUri] string value, [FromUri] string Marca, [FromUri] string Color, [FromUri] string modelo, [FromUri] string precio, [FromUri] string fechaingreso, [FromUri] string estado, [FromUri] string registro, [FromUri] int id)
       // public string Post([FromUri] string value, [FromUri] string Marca, [FromUri] string Color, [FromUri] string modelo, [FromUri] string precio, [FromUri] string fechaingreso, [FromUri] string estado, [FromUri] string registro, [FromUri] int id)

        {
            if (value == "1")//guardar
            {
                using (PRUEBASABCEntities dba = new PRUEBASABCEntities())
                {
                    //dba.INGRESARVEHICULO("TOYOTA","NEGRA","2018","2550.00","02/02/2022","COMO NUEVO","ACTIVO");
                    dba.INGRESARVEHICULO(Marca, Color, modelo, precio, fechaingreso, estado, registro);
                    dba.SaveChanges();
                }
            }
            if (value == "2")//ACTUALIZAR
            {
                using (PRUEBASABCEntities dba = new PRUEBASABCEntities())
                {
                    //dba.ACTUALIZARVEHICULO("TOYOTA", "NEGRA", "2018", "2550.00", "02/02/2022", "COMO NUEVO", "ACTIVO",2);
                    dba.ACTUALIZARVEHICULO(Marca, Color, modelo, precio, fechaingreso, estado, registro, id);

                    dba.SaveChanges();
                }
            }
            if (value == "3")//ELIMINACIÓN LOGICA
            {
                using (PRUEBASABCEntities dba = new PRUEBASABCEntities())
                {
                    //dba.ELIMINARVEHICULO (2,"ACTIVO");
                    dba.ELIMINARVEHICULO(id, registro);

                    dba.SaveChanges();
                }
            }
            //return "valido" + value + Marca + Color + modelo + precio + fechaingreso + estado + registro + id;
        }

        // PUT: api/APIPRUEBA/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/APIPRUEBA/5
        public void Delete(int id)
        {
        }
    }
}
