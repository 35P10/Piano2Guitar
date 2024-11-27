namespace Piano2Guitar.Models
{
    public class Note
    {
        public string Nombre { get; set; } = string.Empty;
        public int Octava { get; set; } = 0;
        public int Id {  get; set; } = 0;
        public List<Tuple<int, int>> GuitarPosition { get; set; } = new List<Tuple<int, int>>(); //cuerda , traste
        public bool EsSostenida { get; set; } = false;

        public Note() { }

        public Note(string nombre, int octava, int id,List<Tuple<int, int>> guitarPosition, bool esSostenida = false)
        {
            Nombre = nombre;
            Octava = octava;
            Id = id;
            GuitarPosition = guitarPosition;
            EsSostenida = esSostenida;
        }

        public Note(string nombre, int octava, int id, bool esSostenida = false)
        {
            Nombre = nombre;
            Octava = octava;
            Id = id;
            EsSostenida = esSostenida;
        }
    }
}
