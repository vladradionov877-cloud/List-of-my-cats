using System.Text;

namespace SimpleOPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("--- Список всіх моїх котів ---\n");

            Kishki[] list = new Kishki[8];
            list[0] = new Kishki();
            list[0].name = "Мурка";
            list[0].age = 2;
            list[0].color = "Чорний";
            list[0].statʹ = "♀";

            list[1] = new Kishki();
            list[1].name = "Кузя";
            list[1].age = 1;
            list[1].color = "Чорний";
            list[1].statʹ = "♀";

            list[2] = new Kishki();
            list[2].name = "Сніжок";
            list[2].age = 1;
            list[2].color = "Біло-коричневий";
            list[2].statʹ = "♂";

            list[3] = new Kishki();
            list[3].name = "Петро";
            list[3].age = 3;
            list[3].color = "Чорно-білий";
            list[3].statʹ = "♂";

            list[4] = new Kishki();
            list[4].name = "Сімба";
            list[4].age = 3;
            list[4].color = "Скумбрія";
            list[4].statʹ = "♂";

            list[5] = new Kishki();
            list[5].name = "Сніжинка";
            list[5].age = 3;
            list[5].color = "Білий";
            list[5].statʹ = "♀";

            list[6] = new Kishki();
            list[6].name = "Лола";
            list[6].age = 3;
            list[6].color = "Чорно-білий";
            list[6].statʹ = "♀";

            list[7] = new Kishki();
            list[7].name = "Чері";
            list[7].age = 3;
            list[7].color = "Чорно-оранжевий";
            list[7].statʹ = "♀";

            foreach (Kishki k in list)
            {
                Console.WriteLine($"{k.statʹ} {k.name}; Вік: {k.age}; Окрас: {k.color}.\n");

            }
        }
    }
}
