namespace ConsoleApp1
{



    public class Car
    {


        public Car()
        {
            Console.WriteLine("Car is ready 1111");
            this.color = "no color yet";
            this.nameType = "no name yet";
            this.carCode = "no code yet";
        }

        public Car(string color, string nameType, string carCode)
        {
            Console.WriteLine("Car is ready 2222");
            this.color = color ?? "no color yet";
            this.nameType = nameType ?? "no name yet";
            this.carCode = carCode ?? "no code yet";
        }

        public Car(string color, string nameType, string carCode, int maxSpeed) : this(color, nameType, carCode)
        {
            Console.WriteLine("Car is ready 3333");
            this.maxSpeed = maxSpeed;
        }



        public int x1;



        public int x
        {

            get
            {
                return 55;
            }

            set
            {
                x1 = value;
            }
        }





        public string color;
        public string nameType;
        public int maxSpeed;
        public int speed;

        private string carCode = "123BMW";


        public void stop()
        {
            if (speed > 100)
            {
                speed = 0;
                Console.WriteLine($"the car with name {nameType} has stoped !!");

            }
        }

        public virtual void move()
        {
            Console.WriteLine($"The car with name {nameType} has moved!!");
        }

        public string getCarCode()
        {
            return carCode;
        }


        ~Car()
        {
            Console.WriteLine("Distructor !!!!!!! ");
        }
    }






    public abstract class ACAR
    {

        public abstract void move();


        public abstract void doit(Object o);

        public void stop()
        {
            Console.WriteLine("Stop !!!!!!!!!!");
        }







    }


    public class BMW : Car
    {
        //public BMW(string Color, string NameType, string CarCode)
        //   : base(Color, NameType, CarCode)
        //{
        //}

        public override void move()
        {

            Console.WriteLine($"the car with name BMW has move !!");


        }


        public void doit(Object o)
        {
            BMW m = o as BMW;
            m.move();
            Console.WriteLine($"is the object o !!!!!!");


        }
    }


    public class MAR : ACAR
    {


        public override void move()
        {

            Console.WriteLine($"the car with name MAR has move !!");


        }


        public override void doit(Object o)
        {

            Console.WriteLine($"the car with name MAR has move !!");


        }
    }



    public class MAR1 : ICar, ICar1
    {


        public void move()
        {

            Console.WriteLine($"the car with name MAR has move !!");


        }

        public void doit(Object o)
        {

            Console.WriteLine($"the car with name MAR has move !!");


        }
    }


    interface ICar
    {
        void move();
    }


    interface ICar1
    {
        void doit(Object o);
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            //   const int x = 5;
            //   int[] a = { 1, 2, 3, 4, 5 };
            //   a = new int[x] { 1, 2, 3, 4, 5 };
            //
            //   int y = x;
            //   y = 10;
            //
            //   int[] b = a;
            //
            //   b[0] = 6;
            //
            //   if (a[0] == 6)
            //   {
            //       Console.WriteLine("a is a ref type ");
            //   }
            //
            //
            //   int day = 2;
            //
            //   string dayName = day switch
            //   {
            //       0 => "sat",
            //       1 => "sun",
            //       2 => "mon",
            //       _ => "no day yet @@"
            //   };
            //
            //
            //   for (int i = 0; i < a.Length; i++)
            //   {
            //       Console.WriteLine($"a[i] in for loop : {a[i]} ");
            //   }
            //


            //  foreach (var item in b)
            //   {
            // v Console.WriteLine($"item in foreach : {item} ");

            //   }

            //  int q = 0;

            //  while (q < 5)
            //  {
            // Console.WriteLine($"a[i] in while loop : {a[q]} ");
            //  q++;
            //  }


            //  string test = "test   5   5";

            // if (!string.IsNullOrEmpty(test))
            // {
            //   string test1 = test.Substring(2, 5);
            //   string test2 = test.Replace("5", "10");
            //   string[] test3 = test.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            //   Console.WriteLine($"test : {test} ");
            //   Console.WriteLine($"Length test : {test.Length} ");
            //    Console.WriteLine($"ToLower test : {test.ToLower()} ");
            //    Console.WriteLine($"ToUpper test : {test.ToUpper()} ");
            //   Console.WriteLine($"Trim test : {test.Trim()} ");
            //   Console.WriteLine($"Contains test : {test.Contains("5")} ");
            //     Console.WriteLine($"IndexOf test : {test.IndexOf("s")} ");
            //    Console.WriteLine($"IndexOf test : {test.IndexOf("55")} ");
            //    Console.WriteLine($"Substring test : {test1} ");
            //    Console.WriteLine($"Replace test : {test2} ");
            //    Console.WriteLine($"Replace test : {test2} ");
            //    Console.WriteLine($"Split test : {test3[2]} ");
            //    Console.WriteLine($"GetType test : {test3.GetType()} ");
            //   }
            //   else
            //   {
            //       Console.WriteLine(($"test : is null value "));
            //  }









            // Car c1 = new Car("black","BMW","12345");

            //c1.color = "red";
            // c1.nameType = "BMW";
            // c1.maxSpeed = 120;
            // c1.speed = 700;
            // string car = c1.getCarCode();

            // c1.stop();



            // Car c2 = new BMW();

            // c1.maxSpeed = 120;
            // c1.speed = 700;
            //string car2 = c2.getCarCode();

            // c1.stop();



            //  Console.WriteLine(car);
            // Console.WriteLine(c2.color);











            //Console.WriteLine($"{dayName} dayName test osama !!! ");
            //Console.WriteLine($"{a[0]} A test osama !!! ");
            //Console.WriteLine($"{b[0]} B test osama !!! ");
            //Console.WriteLine(x);
            //Console.WriteLine("Hello, World!");



            // Car m = new Car();
            // m.move();
            //
            // Car[] cars = { new BMW(), new BMW() };
            // ACAR[] cars1 = { new MAR(), new MAR() };
            //
            //
            // m.x = 5;
            //
            // int f = m.x;
            // int r = m.x1;
            //
            // Console.WriteLine($" x value {f}   and x1 value {r}");
            //
            // foreach (var item in cars)
            // {
            //     item.move();
            //     //   Console.WriteLine($" item value of car {item}");
            // }
            //
            //
            // foreach (var item in cars1)
            // {
            //     item.move();
            //     //   Console.WriteLine($" item value of cars1 {item}");
            // }





            Car car = new BMW();

            //car.move();

            Object o = new BMW();
            ((BMW)o).move();







            Car c1 = new Car();
            Car c2 = new Car();
            Car c3 = new Car();

            c1.nameType = "BMW";
            c2.nameType = "KIA";
            c3.nameType = "MAR";

            c1.maxSpeed = 200;
            c2.maxSpeed = 120;
            c3.maxSpeed = 170;

            List<Car> cars = new List<Car> { c1, c2, c3 };

            // Where
            //فلترة

            var n = cars.Where(l => l.maxSpeed > 150 && l.nameType == "MAR");

            foreach (var item in n)
            {
                Console.WriteLine($"Where {item.nameType}");
            }




            // Select 
            //تغير ع نفس الحبة

            var k = cars.Select(l => new { name = l.nameType, speed = l.maxSpeed });



            foreach (var item in k)
            {
                Console.WriteLine($"Select {item}");
            }

            // OrderBy
            //ترتيب حسب

            var Order = cars.OrderBy(l => -l.maxSpeed);



            foreach (var item in Order)
            {
                Console.WriteLine($"Order {item.maxSpeed}   - {item.nameType}");
            }







            // GroupBy
            //ترتيب حسب

            var Group = cars.GroupBy(l => l.maxSpeed > 130).ToList();



            foreach (var group in Group)
            {
                Console.WriteLine($"Group Key (Speed): {group.Key}");

                foreach (var t in group)
                {
                    Console.WriteLine($"   {t.nameType} - {t.maxSpeed}");
                }
            }






            // DistinctBy
            //???

            var Distinct = cars.DistinctBy(l => l.maxSpeed > 130).ToList();



            foreach (var des in Distinct)
            {
                Console.WriteLine($"Distinct Key (Speed): {des.maxSpeed}");
            }





            // First
            // برجع اول حبة بتحقق الشرط معلم 
            // المشكلة انها بتفقع ايرور اذا ما لقت 
            //var first = cars.First(l => l.maxSpeed < 200) ?? c1 ; ما راح تفقع

            var first = cars.First(l => l.maxSpeed < 200);

            Console.WriteLine($"first : {first.maxSpeed} - {first.nameType} ");




            // First
            // برجع اول حبة بتحقق الشرط معلم 
            // هاي ما بتفقع معلم لانها بتوخذ قيمة ديفولت

            var firstOr = cars.FirstOrDefault(l => l.maxSpeed > 200, c1);

            Console.WriteLine($"firstOr : {firstOr.maxSpeed} - {firstOr.nameType} ");






            // any && all
            // بترجع true  و false

            var any = cars.Any(l => l.maxSpeed >= 200);

            Console.WriteLine($"any : {any}");



            var all = cars.All(l => l.maxSpeed >= 100);

            Console.WriteLine($"all : {all}");






            // Sum && avg && min && max

            var max = cars.Max(l => l.maxSpeed);

            Console.WriteLine($"max : {max}");

            var min = cars.Min(l => l.maxSpeed);

            Console.WriteLine($"min : {min}");

            var sum = cars.Sum(l => l.maxSpeed);

            Console.WriteLine($"sum : {sum}");

            var avg = cars.Average(l => l.maxSpeed);

            Console.WriteLine($"avg : {avg}");




            // Skip && Take 
            // بوخذوا ارقام وبوخذ وبطنش على حسب القيمة 

            var skip = cars.Skip(1).Take(3);

            foreach (var des in skip)
            {
                Console.WriteLine($"skip: {des.nameType}");
            }



            // Skip && Take 
            // اذا الها اكثر من قيمة بتفقع
            //  اذا ما في ماتش 

            var single = cars.Single(l => l.nameType == "BMW");

            Console.WriteLine($"single : {single.nameType}");


            var singleOR = cars.SingleOrDefault(l => l.nameType == "BMW1", c3);

            Console.WriteLine($"singleOR : {singleOR.nameType}");








            // test github
        }
    }
}
