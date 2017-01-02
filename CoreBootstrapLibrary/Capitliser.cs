
namespace CoreBootstrapLibrary
{
    public interface ICapitaliser
    {
        string Captialise(string input);
    }

    public class Capitaliser : ICapitaliser
    {
        public string Captialise(string input) 
        {
            return input.ToUpper();
        }
    }
}
