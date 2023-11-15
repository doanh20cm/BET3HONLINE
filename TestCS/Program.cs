public abstract class Animal
    {
        protected Animal(string name, string color)
        {
            Name = name;
            Color = color;
        }
        protected string Name { get; set; }
        protected string Color { get; set; }
        public abstract string Sound();
    }

    public class Cat : Animal
    {
        public Cat(string name, string color) : base(name, color)
        {

        }
        public override string Sound()
        {
            return "meo meo";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, string color) : base(name, color)
        {

        }
        public override string Sound()
        {
            return "gau gau";
        }
    }

    public class MayDoiTien
    {
        private readonly int[] DSMenhGia = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        private int[] DSSoTo = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void DoiTien(int sotien)
        {
            for (var i = 0; i < 9; i++)
            {
                if (sotien >= DSMenhGia[i])
                {
                    DSSoTo[i] = sotien / DSMenhGia[i];
                    sotien %= DSMenhGia[i];
                }
            }
        }

        public void KetQua()
        {
            Console.Write("Nhap so tien can doi(k): ");
            DoiTien(int.Parse(Console.ReadLine()));
            Console.WriteLine("Ket qua sau khi doi:");
            for (var i = 0; i < 9; i++)
            {
                if (DSSoTo[i] > 0)
                {
                    Console.WriteLine($"- {DSSoTo[i]} to {DSMenhGia[i]}k");
                }
            }
        }
    }

    public class SuperMan
    {
        public SuperMan(string name)
        {
            Name = name;
        }

        public string Name {get; set;}
        public int Hp {get; set;} = 100;

        public void Attack(Monster monster)
        {
            if(Hp < 0 || monster.Hp <0) return;
            Console.WriteLine($"SuperMan's HP: {Hp} vs Monster's HP: {monster.Hp}");
            Hp -= 1;
            monster.Hp -= 10;
            if(Hp == 0)
            {
                Console.WriteLine("SuperMan is die");
                return;
            }
            if(monster.Hp == 0)
            {
                Console.WriteLine("Monster is die");
                return;
            }     
        }
    }

    public class Monster
    {
        public Monster(string name)
        {
            Name = name;
        }

        public string Name {get; set;}
        public int Hp {get; set;} = 100;
    }
    
    class Program
    {
        static void Main()
        {
            var mdt = new MayDoiTien();
            mdt.KetQua();

            var DsDongVat = new List<Animal>
            {
                new Cat("Kitty", "White"),
                new Dog("Spike", "Black"),
                new Dog("Mike", "Brown"),
                new Cat("Miu", "Gray"),
            };
            var DsCho = DsDongVat.Where(animal => animal is Dog).ToList();

            var batman = new SuperMan("Batman");
            var killer = new Monster("Killer");
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            batman.Attack(killer);
            
        }
    }
