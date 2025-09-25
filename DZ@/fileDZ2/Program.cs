using fileDZ2.stucture;
using System;
using System.Threading;




namespace fileDZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 1");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"short -  {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");

            Console.WriteLine("Упр 2");
            dataUser dataUser = new dataUser();
            Console.Write("Введите имя: ");
            dataUser.name = Console.ReadLine();
            Console.Write("Введите город: ");
            dataUser.city = Console.ReadLine();
            Console.Write("Введите возраст: ");
            dataUser.age = int.Parse(Console.ReadLine());
            Console.Write("Введите PIN-код: ");
            dataUser.pinCode = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ваши данные:\n" +
                $"Ваше имя: {dataUser.name}\n" +
                $"Ваш город: {dataUser.city}\n" +
                $"Ваш возраст: {dataUser.age}\n" +
                $"Ваш PIN-код: {dataUser.pinCode}");

            Console.WriteLine("Упр 3");
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (char.IsLower(c))
                {
                    res += char.ToUpper(c);
                }
                else
                {
                    res += char.ToLower(c);
                }
            }
            Console.WriteLine(res);

            Console.WriteLine("Упр 4");
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string subtextinput = Console.ReadLine();
            int count = 0;
            if (string.IsNullOrEmpty(subtextinput))
            {
                Console.WriteLine("Подстрока не должна быть пустой!");
                return;
            }
            text = text.Replace(subtextinput, "*");
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '*')
                {
                    count++;
                }
            }
            Console.WriteLine($"Подстрок: {count}");


            Console.WriteLine("Упр 5");
            Console.Write("Введите цену за одну бутылку");
            float normPrise = float.Parse(Console.ReadLine());
            Console.Write("Введите скидку в процентах!: ");
            float sale = float.Parse(Console.ReadLine());//в процентах скидка
            Console.Write("Введите цену отпуска: ");
            float holidayPrise = float.Parse(Console.ReadLine());
            int result = (int)Math.Truncate(holidayPrise / (normPrise * sale / 100));
            Console.WriteLine(result);


            Console.WriteLine("Упр 6");
            dataStudent St1 = new dataStudent();
            St1.Name = "Anton";
            St1.Surname = "Ficus";
            St1.Birthday = "07.07.1999";
            St1.Id = 1;
            St1.alcoStatus = "c";
            St1.VolumeAlco = 12;

            dataStudent St2 = new dataStudent();
            St1.Name = "John";
            St1.Surname = "Smith";
            St1.Birthday = "01.01.1999";
            St1.Id = 2;
            St1.alcoStatus = "c";
            St1.VolumeAlco = 9;

            dataStudent St3 = new dataStudent();
            St1.Name = "Lazer";
            St1.Surname = "Lactor";
            St1.Birthday = "01.07.1997";
            St1.Id = 3;
            St1.alcoStatus = "d";
            St1.VolumeAlco = 0;

            dataStudent St4 = new dataStudent();
            St1.Name = "Arina";
            St1.Surname = "Pivo";
            St1.Birthday = "23.11.1999";
            St1.Id = 4;
            St1.alcoStatus = "a";
            St1.VolumeAlco = 89;

            dataStudent St5 = new dataStudent();
            St1.Name = "Ramzy";
            St1.Surname = "Foch";
            St1.Birthday = "07.01.1998";
            St1.Id = 5;
            St1.alcoStatus = "d";
            St1.VolumeAlco = 0;

            dataStudent[] group = new dataStudent[5];
            datadrinkVodka drinks = new datadrinkVodka();


        }
    }
}
