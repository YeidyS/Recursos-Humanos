using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocio;
using Servicio;


namespace Presentacion.Controllers
{
    public class HomeController : Controller
    {
        Empleado_N elemento = new Empleado_N();
        Departamento_N elementoD = new Departamento_N();
        Cargo_N elementoC = new Cargo_N();
        VacacionN elementoV = new VacacionN();
        Permisos_N elementoP = new Permisos_N();
        Licencia_N elementoL = new Licencia_N();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Proceso()
        {
            return View();
        }

        #region Detalles     //Todos los detalles
        // GET: Home/Details/5
        public ActionResult Details()//Detalles Empleado
        {
            return View(elemento.MostrarDatos());
        }

        public ActionResult DetailD()//Detalles Departamento
        {
            return View(elementoD.MostrarDatosD());
        }

        public ActionResult DetailC()//Detalles Cargo
        {
            return View(elementoC.MostrarDatoC());
        }
        

      
        public ActionResult DetallesE()
        {
            return View(elemento.MostrarDatos());
        }

        public ActionResult DetallesV()
        {
            return View(elementoV.MostrarDatosV());
        }
        public ActionResult DetallesP()
        {
            return View(elementoP.MostrarDatosP());
        }

        public ActionResult DetallesL()
        {
            return View(elementoL.MostrarDatosL());
        }

        public ActionResult DetallesEmplV()
        {
            return View(elemento.MostrarDatos());
        }

        public ActionResult DetallesEmplP()
        {
            return View(elemento.MostrarDatos());
        }
        public ActionResult DetallesEmplL()
        {
            return View(elemento.MostrarDatos());
        }

        public ActionResult DetailsDTEmpl()
        {
            return View(elemento.MostrarDatos());
        }

        public ActionResult DetailsDTDpt()
        {
            return View(elementoD.MostrarDatosD());
        }

        public ActionResult DetailsDTCag()
        {
            return View(elementoC.MostrarDatoC());
        }

        public ActionResult DetailsDTLicn()
        {
            return View(elementoL.MostrarDatosL());
        }
        public ActionResult DetailsDTPerm()
        {
            return View(elementoP.MostrarDatosP());
        }
        #endregion
        public ActionResult IndxE()
        {
            var empleado = elemento.MostrarDatos();
            return View(empleado);
        }

        #region Create    //Todos los create 
        // GET: Home/Create
        public ActionResult Create()//Create Empleado
        {
            return View();
        }

        
        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Empleado empl)//Create Empleado HttpPost
        {

            elemento.GuardarEmpleado(empl);
            return View();
        }
        public ActionResult CreateD()//Create Departamento 
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateD(Departamento dept)//Create Departamento HttpPost
        {
            elementoD.GuardarDepartamento(dept);
            return View();
        }

        public ActionResult CreateC()//Create Cargo 
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateC(Cargo cag)//Create Cargo HttpPost
        {
            elementoC.GuardarCargo(cag);
            return View();
        }

        public ActionResult CreateV()//Create Vacacioens
        {
            return View();
        }


        // POST: Home/Create
        [HttpPost]
        public ActionResult CreateV(Vacacione vac)//Create vacaciones HttpPost
        {

            elementoV.GuardarV(vac);
            return View();
        }

        public ActionResult CreateP()//Create Permisos
        {
            return View();
        }


        // POST: Home/Create
        [HttpPost]
        public ActionResult CreateP(Permiso perm)//Create permisos HttpPost
        {

            elementoP.GuardarP(perm);
            return View();
        }

        public ActionResult CreateL()//Create Licencias
        {
            return View();
        }


        // POST: Home/Create
        [HttpPost]
        public ActionResult CreateL(Licencia licn)//Create licencias HttpPost
        {

            elementoL.GuardarL(licn);
            return View();
        }
        #endregion

        #region Editar  //Todos los Edit
        // GET: Home/Edit/5
        public ActionResult EditarD(int id)
        {
            var dpto = elementoD.GetDepartamento(id);
            return View(dpto);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult EditarD(Departamento dpto)
        {
            elementoD.Editar(dpto);
            return View(dpto);
            
        }
        public ActionResult EditarC(int id)
        {
            var cag = elementoC.GetCargo(id);
            return View(cag);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult EditarC(Cargo cag)
        {
            elementoC.Editar(cag);
            return View(cag);

        }

        public ActionResult EditarE(int id)
        {
            var empl = elemento.ObtenerEmpleado(id);
            return View(empl);
        }
        [HttpPost]
        public ActionResult EditarE(Empleado empl)
        {
            elemento.Editar(empl);
            return View(empl);
        }
        #endregion
       

        #region Borrar  //Todos los delelte
        // GET: Home/Delete/5
        public ActionResult DeleteD(int? id)//Delete departamento
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var dpto = elementoD.GetDepartamento(id.Value);
            return View(dpto);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult DeleteD(int id)//Delete departamento
        {
            elementoD.Eliminar(id); 
            return View();
        }

        public ActionResult DeleteC(int? id)//Cargo departamento
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var cag = elementoC.GetCargo(id.Value);
            return View(cag);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult DeleteC(int id)//Cargo departamento
        {
            elementoC.Eliminar(id);
            return View();
        }

        public ActionResult DeleteE(int? id)//
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var empl = elemento.GetEmpleado(id.Value);
            return View(empl);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult DeleteE(int id)//
        {
            elemento.Eliminar(id);
            return View();
        }
        //public ActionResult GetDepartamento(int id)
        //{
        //    var dept = elementoD.GetDepartamento(id);
        //    return View(dept);
        //}

        //public ActionResult GetCargo(int id)
        //{
        //    var cag = elementoC.GetCargo(id);
        //    return View(cag);
        //}
        #endregion

        #region Buscar 
        public ActionResult BuscarE()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ResultadoE(string nombre)
        {
            return View(Servicios.BuscarEmpleado(nombre));
        }
        #endregion

        

        public ActionResult Informes()
        {
            return View();
        }

        public JsonResult GetDepartamentos()
        {
            var lista = elementoD.MostrarDatosD();
            return Json(new {data = lista}, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCargos()
        {
            var lista = elementoC.MostrarDatoC();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEmpelado()
        {
            var lista = elemento.ListarEmpl();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }
    }
}


