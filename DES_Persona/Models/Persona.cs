namespace DES_Persona.Models
{
    public class Persona
    {
        //DUI, Nombre, Apellido, Fecha de nacimiento, Dirección y correo electrónico
        public int id { get; set; }
        public string dui { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNac {  get; set; }
        public string direccion {  get; set; }
        public string correo {  get; set; }
    }
}
