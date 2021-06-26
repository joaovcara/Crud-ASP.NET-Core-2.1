using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;

namespace VendasWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {

        #region IndexDepartamentos
        public IActionResult Index()
        {

            List<Departamento> lista = new List<Departamento>();

            lista.Add(new Departamento { IdDepartamento = 1, Descricao = "Eletronicos" });
            lista.Add(new Departamento { IdDepartamento = 2, Descricao = "Celulares" });

            return View(lista);
        }
        #endregion
    }
}
