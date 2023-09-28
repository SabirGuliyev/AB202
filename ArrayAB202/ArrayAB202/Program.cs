
//string name = "Ayshen";

//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}


//Fixed Length ve Ardicil yaddash bloklarinda yerleshir
//string[] students = { "Amin", "Farid", "Azer", "Fidan" };

//Console.WriteLine(students[1][4]);


//int[] numbers = { 1, 2, 3, 4, 5, 6 };

//string[] students2 = new string[3];


//students[1] += " AB202";

//students2[0] = "Salam";
//students2[1] = "Hello";
//students2[2] = students[3];
//Console.WriteLine(students[students.Length - 1]);
//for (int i = 0; i < students2.Length; i++)
//{

//    Console.WriteLine(students2[i]);
//}

//for (int i = 0; i < students.Length; i++)
//{
//    students[i] += " AB202";
//    Console.WriteLine(students[i]);
//}



//int[,] numbers =
//{
//    {1,2},
//    {4,5},
//    {5,6}
//};

//Console.WriteLine(numbers[0,2]);




//string name = "yshen";

//bool result = false;

//for (int i = 0; i < name.Length; i++)
//{
//    if (name[i] == 'a' || name[i]=='A')
//    {
//        result = true;
//        break;
//    }
//}

//if (result)
//{
//    Console.WriteLine("a herfi var");
//}
//else
//{
//    Console.WriteLine("a herfi yoxdur");
//}



//int age = 2000000;

//if (age>17)
//{
//    Console.WriteLine("Yetkindir");
//}




//Console.WriteLine(numbers[0]);

//int num = 20;


//int[] numbers = { 1, 25, 3, 23, 6, 0, 9, 9, 9,1 };
//int step = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//    step++;
//}

//Console.WriteLine("addimlarin sayi "+step);


//int num = 49;
//int step = 0;

//for (int i = 2; i*i <=num; i++)
//{
//    step++;
//    if (num%i==0)
//    {
//        Console.WriteLine("Murekkeb");
//        break;
//    }
//}

//Console.WriteLine(step);



int num = 20;
int step = 0;
for (int i = 0; i < num; i++)
{
    
    for (int j = 0; j <num; j++)
    {

        step++;
        Console.WriteLine("Salam");
    }
}

Console.WriteLine(step);