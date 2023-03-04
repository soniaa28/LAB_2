using System.Numerics;

namespace LAB_2;
class Program
{

    
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        NumberProgression p1 = new NumberProgression(2);
        NumberProgression p2 = new NumberProgression(4);
        NumberProgression p3 = p1 + p2;
        NumberProgression p4 = new NumberProgression();
        p4.FirstMember = 5;
        NumberProgression p5 = p1 + p4;


        Console.WriteLine(p1.getSumOfN(5));

        Console.WriteLine(p1.getSumOfAll());
        Console.WriteLine(p1.getProgression());
        Console.WriteLine(p3.ToString());
        Console.WriteLine(p2 > p1);

        List<NumberProgression> set = new List<NumberProgression>() { p1, p2, p3, p4, p5 };


        for (int i = 0; i < set.Count; i++)
        {
            Console.WriteLine(string.Format("Progression №{0} : {1} ", i + 1, set[i].ToString()));
        }
        void Menu()
        {
            bool _continue = true;
            while (_continue)
            {
                Console.WriteLine("Оберіть один з варіантів :");
                Console.WriteLine("1.Додати нову прогресію.");
                Console.WriteLine("2.Надрукувати всі прогресії.");
                Console.WriteLine("3.Знайти найбільшу прогресію(за сумою чисел)");
                Console.WriteLine("4.Вийти");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.WriteLine("Щоб додати нову прогресію введіть перший член та інкремент через пробіл");

                        string[] progression = Console.ReadLine().Split(" ");
                        NumberProgression newProgression = new NumberProgression(double.Parse(progression[0]), double.Parse(progression[1]));
                        set.Add((NumberProgression)newProgression);
                        Console.WriteLine("Прогресія успішно додана до колекції.");
                        break;
                    case "2":
                        for (int i = 0; i < set.Count; i++)
                        {
                            Console.WriteLine(string.Format("Progression №{0} : {1} ", i + 1, set[i].ToString()));
                        }
                        break;
                    case "3":
                        double max_sum = 0;
                        int index = 0;
                        for(int i = 0; i < set.Count; i++)
                        {
                            if (set[i].getSumOfAll()>max_sum)
                            {
                                max_sum = set[i].getSumOfAll();
                                index = i;
                            }
                        }
                        Console.WriteLine(String.Format("Прогресія {0} має найбільшу суму елементів - {1}", index + 1, set[index]));

                        break;
                    case "4":
                    default:
                        _continue = false;
                        break;

                       
                }
            }




        }
        Menu();
    }
}