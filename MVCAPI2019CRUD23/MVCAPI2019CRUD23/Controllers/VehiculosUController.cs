using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using MVCAPI2019CRUD23.Models;
using System.Text.Json;

namespace MVCAPI2019CRUD23.Controllers
{
    public class VehiculosUController : Controller
    {
        // GET: VehiculosU
        List<string> carroDeserializado = new List<string>();
        public async Task <ActionResult> Index()
        {
            var url = "https://localhost:44375/api/APIPRUEBA";

            //using (var httpClient = new HttpClient())
            //{
            //    var respuesta = await httpClient.GetStringAsync(url);
            //    //List<string> carroDeserializado = JsonSerializer.Deserialize<List<string>>(respuesta);

            //     carroDeserializado.Add(respuesta);

            //    // ViewBag.DatosCarro = respuesta.ToString();
            //    foreach(var carro in carroDeserializado)
            //    {
            //        ViewBag.DatosCarro = carro.ToString();
            //        ViewBag.DatosCarro = ViewBag.DatosCarro + carro.Substring(2,1).ToString()+ "<br>"+2;
            //    }

            //}

            using (var httpClient = new HttpClient())
            {
                //var carroApiData = await httpClient.GetStringAsync(url);
                List<String> CarroApiData = new List<string>();
                 CarroApiData.Add(await httpClient.GetStringAsync(url));
                //List<string> carroDeserializado = JsonSerializer.Deserialize<List<string>>(respuesta);



                // ViewBag.DatosCarro = respuesta.ToString();
                foreach (var carro in CarroApiData)
                {
                    ViewBag.DatosCarro = carro.ToString();
                    
                }

            }

            return View();
        }

        // GET: VehiculosU/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehiculosU/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehiculosU/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VehiculosU/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehiculosU/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VehiculosU/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehiculosU/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
