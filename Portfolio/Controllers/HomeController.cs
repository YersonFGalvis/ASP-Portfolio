using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;
using Portfolio.Services.Interfaces;
using System.Diagnostics;
using System.Reflection;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonRepository _personRepository;
        private readonly IConfiguration _configuration;
        private readonly IEmailSender _emailSender;
        private readonly IProjectsRepository _projectsRepository;

        public HomeController(ILogger<HomeController> logger, 
                              IProjectsRepository projectsRepository,
                              IPersonRepository personRepository,
                              IConfiguration configuration,
                              IEmailSender emailSender)
        {
            _logger = logger;
            _personRepository = personRepository;
            _configuration = configuration;
            _emailSender = emailSender;
            _projectsRepository = projectsRepository;
        }

        public IActionResult Index()
        {
            //var ConnectionString = _configuration.GetConnectionString("Production");
            //_logger.LogError($"Connection String {ConnectionString}");
            var projects = _projectsRepository.GetProjects().Take(3).ToList();
            var person = _personRepository.GetPerson();
            var model = new HomeIndexViewModel() { Persona = person , Proyectos = projects };
			return View(model);
        }

        public IActionResult Projects()
        {
            var projects = _projectsRepository.GetProjects();
			return View(projects);
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactoDTO contactoDTO) 
        {
            await _emailSender.Send(contactoDTO);
            return RedirectToAction("MessageSended");
        }

        public IActionResult MessageSended() 
        {

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}