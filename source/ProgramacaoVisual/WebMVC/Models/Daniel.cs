namespace WebMVC.Models
{
    public class Daniel :  Pessoa
    {
        public Daniel()
        {
            this.GetId();
            var outraPessoa = new Pessoa();
            outraPessoa.GetId();
            outraPessoa.GetNome();
        }
    }
}