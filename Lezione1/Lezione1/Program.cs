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
            if(stampa == "ciao Alice")
            {
                Console.WriteLine(stampa + " si può fare");
            }
            //meglio usare prima "ciao Alice" perchè nel caso stampa fosse "null" darebbe errore e il programma scoppierebbe
            if("ciao Alice".Equals(stampa))
            {
                Console.WriteLine(stampa + " si può fare anche così");
            }
            //se scrivi nome variabile stringa e poi inserisci il "." ottieni la lista delle funzioni che puoi utilizzare con la
            //descrizione es. stampa. ecc
            

           
            return 0;
        }
    }
}