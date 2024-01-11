using System.Collections.Generic;
using Portfolio.Models;
using Portfolio.Services.Interfaces;
using static System.Net.WebRequestMethods;

namespace Portfolio.Services
{
    public class PersonRepository : IPersonRepository
    {
        public Persona GetPerson()
        {
            return new Persona
            {
                Nombre = "Yerson Fabian Galvis",
                Edad = 22,
                HabilidadesBackend = new List<string>
                {
                    "<img width=\"50\" height=\"50\" src=\"https://img.icons8.com/color/144/net-framework.png\" alt=\"net-framework\" />",
                    "<img width=\"50\" height=\"50\" src=\"https://img.icons8.com/color/144/c-sharp-logo.png\" alt=\"c-sharp-logo\" />",
                    "<img width=\"50\" height=\"50\" src=\"https://img.icons8.com/color/144/microsoft-sql-server.png\" alt=\"microsoft-sql-server\" />",
                    "<img width=\"50\" height=\"50\" src=\"https://img.icons8.com/color/144/nodejs.png\" alt=\"nodejs\" />",
                    "<img width=\"50\" height=\"50\" src=\"https://img.icons8.com/color/144/typescript.png\" alt=\"typescript\" />",
                },
                HabilidadesFrontend = new List<string>
                {
                    "<img width=\"50\" height=\"50\" src=\"https://img.icons8.com/color/144/javascript--v1.png\" alt=\"javascript--v1\" />",
                    "<img width=\"48\" height=\"48\" src=\"https://img.icons8.com/color/48/angularjs.png\" alt=\"angularjs\"/>"
                },
                Titulo = "¿Quien Soy?",
                Descripcion = "Soy un Estudiante aspirante a grado de Ingeniería de Sistemas con un enfoque principal en el desarrollo " +
                    "Backend.\r\n\t\t\t\tGraduado del Bootcamp de programación COEX, un programa de 9 meses donde apliqué tecnologías de " +
                    "vanguardia en el lado del servidor (Backend),\r\n\t\t\t\tescribiendo código escalable y siguiendo las mejores prácticas de " +
                    "desarrollo, con un enfoque en la calidad y el rendimiento del software. " +
                    "Actualmente, me desempeño como desarrollador FullStack en Biofile Software Médico de Calidad, donde llevo trabajando durante " +
                    "más de un año.\r\n\t\t\t\tEn mi rol, he estado involucrado en la resolución de tickets, análisis de calidad del código de mis " +
                    "compañeros de equipo, en la\r\n\t\t\t\tdelegación de tareas a otros desarrolladores del equipo, desarrollo de nuevas funcionalidades " +
                    "del software y además en mejoras del mismo\r\n\t\t\t\taplicando estándares y prácticas de desarrollo actuales haciendo uso de herramientas " +
                    "como Visual Basic, C#/ASP.NET, SQL Server, JavaScript principalmente."
            };
        }
    }
}
