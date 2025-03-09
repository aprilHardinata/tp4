// See https://aka.ms/new-console-template for more information

class KodePos
{
    private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijawura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public string GetKodePos(string kelurahan)
    {
        if (tabelKodePos.ContainsKey(kelurahan))
        {
            return tabelKodePos[kelurahan];
        }
        else
        {
            return "Kode Pos tidak ditemukan";
        }
    }

    }
class DoorMachine
{
    public enum State { terkunci, terbuka }
    private State currentState;

    public DoorMachine()
    {
        currentState = State.terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void KunciPintu()
    {
        if (currentState == State.terkunci)
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
        else
        {
            currentState = State.terbuka;
            Console.WriteLine("Pintu terkunci");
        }
    }

    public void BukaPintu()
    {
        if (currentState == State.terbuka)
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
        else
        {
            currentState = State.terkunci;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}

    class Program
    {
        static void Main()
        {
            KodePos kodePos = new KodePos();

            string kelurahan = "Mengger";

            Console.WriteLine($"Kode pos untuk {kelurahan} adalah: {kodePos.GetKodePos(kelurahan)}");

            //bagian 2
            DoorMachine pintu = new DoorMachine();
                string input = "buka";

                if (input == "buka")
                {
                    pintu.BukaPintu();
                }
                else if (input == "kunci")
                {
                    pintu.KunciPintu();
                }
        }
    }

