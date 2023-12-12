using System;

class BubbleSort
{
    public static void Start()
    {
       
        
            // Eingabe der Arraygröße
            Console.WriteLine("Geben Sie die Arraygröße ein: ");
            int arrayGroesse = Convert.ToInt32(Console.ReadLine());

            // Erstellen des Arrays
            int[] array = new int[arrayGroesse];

            // Befüllen des Arrays mit Zufallszahlen
            for (int i = 0; i < arrayGroesse; i++)
            {
                array[i] = new Random().Next(1000);
            }

            // Ausgabe des unsortierten Arrays
            Console.WriteLine("Unsortiertes Array:");
            for (int i = 0; i < arrayGroesse; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Sortieren des Arrays mit Bubblesort
            bubbleSort(array);

            // Ausgabe des sortierten Arrays
            Console.WriteLine("Sortiertes Array:");
            for (int i = 0; i < arrayGroesse; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void bubbleSort(int[] array)
        {
            // Iteration über das Array
            for (int i = 0; i < array.Length - 1; i++)
            {
                // Iteration über das Array von hinten nach vorne
                for (int j = array.Length - 1; j > i; j--)
                {
                // In jeder Iteration der inneren Schleife werden die beiden aktuellen Elemente miteinander verglichen.
                // Die Variable array[j] enthält den Wert des Elements an der Position j im Array.
                // Die Variable array[j - 1] enthält den Wert des Elements an der Position j - 1 im Array.
                    if (array[j] < array[j - 1])
                    {
                        // Tausch der beiden Elemente
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }
