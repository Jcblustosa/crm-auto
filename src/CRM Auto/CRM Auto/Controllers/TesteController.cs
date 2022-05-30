using CRM_Auto.Models;
using CRM_Auto.Util;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace CRM_Auto.Controllers
{
    public class TesteController : Controller
    {
        //public IActionResult Index()
        //{
        //    //string command = "SELECT * FROM CLIENTE";
        //    //DAL dal = new DAL();
        //    //DataTable dt = dal.GetData(command);
        //    //List<TesteModel> list = new List<TesteModel>();
        //    //for (int i = 0; i < dt.Rows.Count; i++)
        //    //{
        //    //    TesteModel model = new TesteModel();
        //    //    model.Nome_Cliente = dt.Rows[i]["Nome_Cliente"].ToString();
        //    //    model.Telefone = dt.Rows[i]["Telefone"].ToString();
        //    //    list.Add(model);
        //    //}
        //    //ViewBag.Pessoas = list;
        //    //return View();
        //}

        [HttpPost]
        public IActionResult TestandoInsert(TesteModel formulario)
        {
            string command = $"INSERT INTO CLIENTE VALUES('{formulario.Nome_Cliente}', '{formulario.Telefone}')";
            DAL dal = new DAL();
            dal.InsertData(command);
            return RedirectToAction("Index");
        }
    }
}
