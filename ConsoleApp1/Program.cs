namespace SistemAutentificare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string usernameCorect = "Andreea";
            const string parolaCorecta = "Cata";

            bool autentificat = false;

            while (!autentificat)
            {
                Console.WriteLine("Introduceti username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Introduceti parola: ");
                string parola = Console.ReadLine();

                if (username == usernameCorect && parola == parolaCorecta)
                {
                    Console.WriteLine("Bine ai venit , " + usernameCorect);
                    autentificat = true;

                }
                else
                {
                    Console.WriteLine("Autentificare esuata.Introduceti din nou");
                }


            }
        }
    }
}