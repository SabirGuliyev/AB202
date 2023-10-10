using AccessModifiersRecordTupleEncapsulation.Models;

namespace AccessModifiersRecordTupleEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access modifiers/specifiers Encapsulation
            User user = new User("Sabir", "Quliyev");
            //User user2 = new User("Sabir","Quliyev");

            Console.WriteLine(user.RegisteredAt);




            //user.Password = Console.ReadLine();
            //Console.WriteLine(user.Password);

            //user.Username = "killer98";
            //Console.WriteLine(user.Username);
            //user.SetName(name);

            //Console.WriteLine(user.GetName());


            #endregion

            #region Record
            //PersonRecord person = new PersonRecord("Sabir", "Quliyev");

            //person.Name = "sds";

            //PersonRecord person = new PersonRecord
            //{
            //    Name="Sabir",
            //    Surname="Quliyev"
            //};
            //person = person with { Name = "Ali" };

            //Console.WriteLine(person); 
            #endregion
            #region Tuple

            //Tuple

            //(string Name, int Day) month = ("Yanvar", 31);
            ////month.Item1 = "Fevral";
            ////month.Item2 = 29;

            //month.Name = "Mart";
            //month.Item2 = 30;
            //Console.WriteLine(month);


            //(string Name,int Day) month = Tuple.Create("Yanvar", 31).ToValueTuple();

            //Console.WriteLine(month.Item1);
            //int[] numbers = { 5, 1, 3, 7, 11, 2 };

            //var result=GetMinMax(numbers);


            //Console.WriteLine(result);


            //int a = 5;
            //int b = 10;

            //(a, b) = (b, a);

            //Console.WriteLine(b); 
            #endregion



        }

        //public static (int Min,int Max) GetMinMax(int[] arr)
        //{
        //    return (arr.Min(), arr.Max());
        //}

        
    }
    internal class User
    {

        private string _name;
        private string _surname;

        private string _username;
        private string _password;

        private DateTime _registeredAt;

        public string Name { 
            get 
            {
                return _name;
            } 
            set 
            {
                value = value.Trim();
                if (value.Length >= 3 && value.Length <= 25)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Yanlish deyer");
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                value = value.Trim();
                if (value.Length >= 3 && value.Length <= 25)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Yanlish deyer");
                }
            }
        }

        public string Username
        {
            get { return _username; }
        }

        public string Password
        {
         
            set { _password = value; }
        }

        public DateTime RegisteredAt { get { return _registeredAt; } }



        public User(string name,string surname)
        {
            Name = name;
            Surname = surname;
            _username = name + "." + surname;
            _registeredAt = DateTime.Now;

           _registeredAt= _registeredAt.AddYears(40);

        }









        //public void SetName(string name)
        //{
        //    name = name.Trim();
        //    if (name.Length>=3 && name.Length<=25)
        //    {
        //        Name = name;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Yanlish deyer");
        //    }
        //}

        //public string GetName()
        //{
        //    return Name;
        //}


    }

   
}