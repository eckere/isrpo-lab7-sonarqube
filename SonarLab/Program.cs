namespace SonarLab
{
    public class Program
    {
        public string DbPassword = "qwerty123";
        public List<int> grades = new List<int>();

        public static void Main(string[] args)
        {
            Program journal = new Program();
            journal.grades.Add(5);
            journal.grades.Add(4);
            journal.grades.Add(3);

            journal.print_report("Иванов");
            journal.SaveToFile("journal.txt");
        }

        public void print_report(string studentName)
        {
            int counter = 0;

            Console.WriteLine("Студент: " + studentName);
            Console.WriteLine("Средний балл: " + GetAverage());

            if (GetAverage() > 4.5 == true)
            {
                Console.WriteLine("Отличник");
            }
            else if (GetAverage() > 3.5)
            {
                Console.WriteLine("Хорошист");
            }
            else
            {
                Console.WriteLine("Хорошист");
            }
        }

        public double GetAverage()
        {
            int sum = 0;
            foreach (int grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Count;
        }

        public void SaveToFile(string path)
        {
            try
            {
                File.WriteAllText(path, "Средний балл: " + GetAverage());
            }
            catch (Exception ex)
            {
            }
            // TODO: добавить шифрование файла
        }
    }
}
