
namespace Id
{
    internal class Program
    {
        static List<string> IdCards = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. ID qo‘shish");
                Console.WriteLine("2. ID o‘chirish");
                Console.WriteLine("3. ID larni ko‘rish");
                Console.WriteLine("0. Chiqish");

                Console.Write("Tanlang: ");
                int.TryParse(Console.ReadLine(), out int tanlov);

                if (tanlov == 1)
                {
                    Console.Write("ID raqam kiriting: ");
                    string id = Console.ReadLine()!;
                    CreateId(id);
                }
                else if (tanlov == 2)
                {
                    Console.Write("O‘chiriladigan ID ni kiriting: ");
                    string id = Console.ReadLine()!;
                    DeleteId(id);
                }
                else if (tanlov == 3)
                {
                    ReadIds();
                }
                else if (tanlov == 0)
                {
                    break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        // ------------------ CREATE ------------------
        static void CreateId(string id)
        {
            if (!IsValidId(id))
            {
                Console.WriteLine(" Xato ID raqam");
                return;
            }

            if (IdCards.Contains(id))
            {
                Console.WriteLine("Bu ID raqam allaqachon kiritilgan");
                return;
            }

            IdCards.Add(id);
            Console.WriteLine(" ID muvaffaqiyatli qo‘shildi");
        }





        // ------------------ DELETE ------------------
        static void DeleteId(string id)
        {
            if (IdCards.Remove(id))
                Console.WriteLine(" ID o‘chirildi");
            else
                Console.WriteLine(" Bunday ID topilmadi");
        }




        // ------------------ READ ------------------
        static void ReadIds()
        {
            if (IdCards.Count == 0)
            {
                Console.WriteLine(" Ro‘yxat bo‘sh");
                return;
            }

            foreach (var id in IdCards)
                Console.WriteLine(id);
        }





        // ------------------ VALIDATION ------------------
        static bool IsValidId(string id)
        {

            if (id.Length != 9)
                return false;


            if (!char.IsLetter(id[0]) || !char.IsLetter(id[1]))
                return false;

          
            for (int i = 2; i < 9; i++)
            {
                if (!char.IsDigit(id[i]))
                    return false;
            }

            return true;
        }

    }
}
