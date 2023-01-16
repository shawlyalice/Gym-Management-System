using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using GYMONE.Models;
using Dapper;
using WebMatrix.WebData;
using GYMONE.Filters;
using GYMONE.Repository;

namespace GYMONE.Controllers
{
    public class AboutusController : Controller
    {
        //
        // GET: /Aboutus/

        public ActionResult Index()
        {
            return View();
        }

    }
}
