namespace Portfolio.Models
{
    public class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public List<string> HabilidadesBackend { get; set; } = new List<string>();
        public List<string> HabilidadesFrontend { get; set; } = new List<string>();
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
    }
}
