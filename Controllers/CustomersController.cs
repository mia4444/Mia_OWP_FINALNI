
using Mia_OWP_FINALNI.Models;
using Mia_OWP_FINALNI.ViewModels;
using System.Data.Entity; //dodala
using System.Linq;//zbog ovoga mogu koristiti kolekcije kao što je SingleOrDefault
using System.Web.Mvc; // za MVC specific klase kao što su Controller i ActionResult


namespace Mia_OWP_FINALNI.Controllers
{
    public class CustomersController : Controller //CustomersController nasleđuje od Controller-a, samim tim postaje controller u MVC obrascu
    {


        private ApplicationDbContext _context;

        public CustomersController()

        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New() {

            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new newCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel); //moramo kreirati pogled---pogledi pa customers pa novi pogled
        }


        // GET: Customer
        //ActionResult Index se aktivira u momentu kada korisnik pristupi URL-u:/Customers/Index
        public ActionResult Index() //action method se zove isto kao view
        {
            // var customers = GetCustomers(); //get customers NE potiče iz klase Customers, nije njen getter putem kod želim da retreive-ujem vrednost, već je privatna metoda koju definišemo ispod
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);

            //returns the data to a view called Index.cshtml
            //(by convention, MVC will look for a view with the same name as the action method).
        }

        public ActionResult Details(int id)

        {
            //pristupni URL /Customers/Details/{id}

            //var customer = GetCustomers().SingleOrDefault(c => c.Id == id);//"hvata" customer-a čiji se id poklapa sa datim
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)

                return HttpNotFound(); //HTTP 404 error, ako u bazi ne postoji customer sa takvim id-jem


            return View(customer); //view u koji će ga vratiti je Details.cshtml

        }


        /*private IEnumerable<Customer> GetCustomers()
        //ovo ćemo inače povlačiti iz baze?
        {

            return new List<Customer>

            {

                new Customer {Id = 1, Name = "John Smith"},

                new Customer { Id = 2, Name = "Mary Wiliams" }

            };

        }*/



    }

}

