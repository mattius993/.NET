//nella cartella del progetto ci sono due cartelle. In dipendenze ci sono le librerie che utilizza, ce ne sono alcune già di default.
//per aggiungere librerie come in angular abbiamo usato NPM qui c'è "NuGet". Cliccando su Strumenti -> Gestione pacchetti NuGet
//Console di Gestione Pacchetti apre la console dove poter importare dal "market" le librerie che ti servono

//in esplora risorse c'è la cartella bin dove si trova l'eseguibile una volta cliccato su "Run"

//namespace è il nome del progetto come fosse in java "com.matteo.progetto"
//se si crea una cartella dentro il progetto verrà utilizzato "namespace Lezione1.nomesottocartella"
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Lezione1
{
    public class Program
    {
        //funzione main di solito è void, la mettiamo int cosi ritorniamo un valore e sappiamo in caso di programmi grandi 
        //se ritorniamo un errore e il codice dell'errore alla terminazione del programma stesso
        public static int Main(string[] args)
        {
            //forte tipizzazioni.. Una volta dichiarata e non assegnato nessun valore usa un valore come default (0 per i numeri
            //null per le stringhe)
            int a;
            uint b; //unsigned e si può fare con tutti i tipi numerici (ufloat, udouble, ecc)
            short s;
            long l;
            float f; //7 cifre dopo la virgola
            double d; //15 cifre dopo la virgola
            char c;
            string str;


            //string dichiarazione con la minuscola, è una classe come java
            //utilizzato come un puntatore alla heap dal compilatore ma in realtà viene utilizzato come in java
            string stampa = "ciao Alice";

            Console.WriteLine(stampa);

            //puoi fare il confronto delle stringhe con == oltre che con Equals
            if (stampa == "ciao Alice")
            {
                Console.WriteLine(stampa + " si può fare");
            }
            //meglio usare prima "ciao Alice" perchè nel caso stampa fosse "null" darebbe errore e il programma scoppierebbe
            if ("ciao Alice".Equals(stampa))
            {
                Console.WriteLine(stampa + " si può fare anche così");
            }
            //se scrivi nome variabile stringa e poi inserisci il "." ottieni la lista delle funzioni che puoi utilizzare con la
            //descrizione es. stampa. ecc


            // new per instanziare gli array
            int[] array = new int[12];
            Console.WriteLine(array.Length);
            //si può fare anche questo ma solo nella dichiarazione di una nuova variabile
            int[] pippo = { 2, 3, 1, 4 };
            Console.WriteLine(pippo.Length);
            Console.WriteLine(pippo.Min()); //minimo di un array, c'è anche la funzione Max()
                                            //array usati ma non tantissimo perchè ci sono strutture dati più flessibili

            //rialloca un nuovo array con perdita dei dati già definiti
            pippo = new int[5];

            for (int i = 0; i < pippo.Length; i++)
            {
                int pippetto = pippo[i];
                Console.WriteLine(pippetto);
                //stampa 0 perchè viene inizializzato a 0 di default
            }
            //in questo caso for e foreach fanno la stessa identica cosa
            foreach (int pluto in pippo)
            {
                Console.WriteLine(pluto);
            }

            //while random finchè genera un numero inferiore a 100
            int j = 0;
            Random random = new Random();

            while (j < 100)
            {
                j = random.Next(200);
                Console.WriteLine(j);
            }
            //stessa cosa di prima ma con do-while (prima fa il do e poi controlla con il while, almeno una volta si esegue)
            do
            {
                j = random.Next(200);
                Console.WriteLine(j);
            }
            while (j < 100);  //ricordarsi il ";" dopo il while in caso di do-while

            //test funzione Max
            int a1 = 0;
            int b1 = 2;

            int c1 = Max(a1, b1);

            int d1 = Max2(1, 2, 3, 4, 5, 6, 0xFF);  //non solo decimali

            //struct poco usate, vantaggio del fatto che sia usato come una variabile e quindi ha un valore di default
            Vector v = new Vector();
            Console.WriteLine(v.x + " " + v.y);
            v.x = 12.5;
            v.y = 10.3;
            /*string s;
             * int l = s.Length; da errore a differenza di struct perchè non ha un valore di default*/



            return 0;
        }

        //le funzioni vengono dichiarare con la prima lettera maiuscola per convenzione
        //static chiamato dal main statico e non su un oggetto
        static int Max(int x, int y)
        {
            /*if(x>y){
             * return x
             * }
             * return y*/
            return x > y ? x : y; //operatore ternario sostitutivo dell'if-else 
        }

        //params int[] various può prendere infiniti parametri 
        static int Max2(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new Exception("Inserisci almeno un numero"); //lancia una eccezione in caso di chiamata della funzione senza parametri
            }
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;

            //return numbers.Max(); esiste già una funzione che lo fa
        }

        //struct sta nello stack a differenza degli oggetti che sono nella heap 
        public struct Vector
        {
            public double x; //IMPORTANTE chiamarli public altrimenti sono inaccessibili
            public double y;

            //costruttore per definire un valore di default diverso
            public Vector()
            {
                x = 1;
                y = 1;
            }
        }
    }

    public enum Mese
    {
        GENNAIO = 1,
        FEBBRAIO, //AGGIUNGE UN +1 (se passi il mouse sopra vedi il valore)
        MARZO,
        APRILE,
        MAGGIO,
        GIUGNO,
        LUGLIO,
        AGOSTO,
        SETTEMBRE,
        OTTOBRE,
        NOVEMBRE,
        DICEMBRE
    }
}