namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Creando instancias de una lista
                Console.ForegroundColor = ConsoleColor.Yellow;
                List<int> list1 = new List<int>();
                list1.Add(10);
                list1.Add(20);
                list1.Add(30);
                list1.Add(40);
                list1.Add(50);
                list1.Add(60);
                list1.Add(70);
                ShowListContain(list1);
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Red;
                if (list1.Contains(50))
                {
                    list1.Remove(50);
                    Console.WriteLine("Se removio el numero 50.");
                }
                ShowListContain(list1);
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Green;
                if (!list1.Contains(50))
                {
                    list1.Insert(4, 50);
                    Console.WriteLine("Se insertó el numero 50.");
                }
                ShowListContain(list1);
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Blue;
                List<int> list2 = new List<int>() { 80, 90, 100 };
                ShowListContain(list2);
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Blue;
                list2.InsertRange(0, list1);
                ShowListContain(list2);
                Console.ReadKey();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"NULL REFERENCE EXCEPTION {ex.Message}");
            }
            catch (FieldAccessException ex)
            {
                Console.WriteLine($"OTHER EXCEPTION {ex.Message}");
            }
            finally
            {
                Console.WriteLine("La aplicacion termino.");
            }
        }

        private static void ShowListContain(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}