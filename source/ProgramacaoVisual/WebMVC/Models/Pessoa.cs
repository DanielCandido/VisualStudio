namespace WebMVC.Models
{
    public class Pessoa
    {
        public int id {get; set;}

        public string nome {get; set;}
    }

    public string ToString()
    {
        return GetId() + "" + GetNome();
    }
}  