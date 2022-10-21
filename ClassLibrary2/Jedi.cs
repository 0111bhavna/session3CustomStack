namespace ClassLibrary2
{
    public class Jedi : IIntern
    {

        private string Name { get; set; }   
        private int Id { get; set; }    
        private string NameId=> $"Jedi-{Name}:{Id}";

        public Jedi(string name, int id)
        {
            Name = name;
            Id = id;
        }
            public string Getname()
        {
            return NameId;
        }
    }
}