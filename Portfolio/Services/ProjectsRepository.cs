using Portfolio.Models;
using Portfolio.Services.Interfaces;

namespace Portfolio.Services
{
    public class ProjectsRepository : IProjectsRepository
    {
        public List<Proyecto> GetProjects()
        {
            return new List<Proyecto>() {
                   new Proyecto
                   {
                        Titulo = "SDK OFFICE First Look",
                        Descripcion = "Proyecto realizado como prueba del sdk de office para generar archivos word por medio" +
                        "de un texto que ponga el usuario",
                        Link = "https://www.amazon.com/",
                        ImagenURL = "/images/myself.png",
                        Tipo = "Backend"

                   },
                    new Proyecto
                   {
                        Titulo = "SDK OFFICE First Look",
                        Descripcion = "Proyecto realizado como prueba del sdk de office para generar archivos word por medio" +
                        "de un texto que ponga el usuario",
                        Link = "https://www.amazon.com/",
                        ImagenURL = "/images/myself.png",
                        Tipo = "Backend"

                   }, new Proyecto
                   {
                        Titulo = "SDK OFFICE First Look",
                        Descripcion = "Proyecto realizado como prueba del sdk de office para generar archivos word por medio" +
                        "de un texto que ponga el usuario",
                        Link = "https://www.amazon.com/",
                        ImagenURL = "/images/myself.png",
                        Tipo = "Backend"

                   }, new Proyecto
                   {
                        Titulo = "SDK OFFICE First Look",
                        Descripcion = "Proyecto realizado como prueba del sdk de office para generar archivos word por medio" +
                        "de un texto que ponga el usuario",
                        Link = "https://www.amazon.com/",
                        ImagenURL = "/images/myself.png",
                        Tipo = "Backend"

                   }, new Proyecto
                   {
                        Titulo = "SDK OFFICE First Look",
                        Descripcion = "Proyecto realizado como prueba del sdk de office para generar archivos word por medio" +
                        "de un texto que ponga el usuario",
                        Link = "https://www.amazon.com/",
                        ImagenURL = "/images/myself.png",
                        Tipo = "Backend"

                   }, new Proyecto
                   {
                        Titulo = "SDK OFFICE First Look",
                        Descripcion = "Proyecto realizado como prueba del sdk de office para generar archivos word por medio" +
                        "de un texto que ponga el usuario",
                        Link = "https://www.amazon.com/",
                        ImagenURL = "/images/myself.png",
                        Tipo = "Backend"

                   }
            };
        }
    }
}
