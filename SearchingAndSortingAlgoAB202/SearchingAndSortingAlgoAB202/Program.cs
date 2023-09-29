

#region Linear Searching
// Linear  big 0(n)
//int[] numbers = { 45, 23, 1, 4, 3, 25 };

//int search = 3;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i]==search)
//    {
//        Console.WriteLine(i);
//        break;
//    }
//}

//Console.WriteLine(numbers[4]); 

//ctrl+k+s

//ctrl +k +u
#endregion


#region Binary Searching
// Big O(Log n)
//int[] numbers = { 1, 4, 11, 45, 78, 101, 234, 1250, 1400 };
//int search = 1250;

//int low = 0;
//int high = numbers.Length - 1;
//int mid = (low + high) / 2;

//while (numbers[mid] != search)
//{


//    if (numbers[mid] > search)
//    {
//        high = mid - 1;
//    }
//    else
//    {
//        low = mid + 1;
//    }
//    mid = (low + high) / 2;
//}


//Console.WriteLine(mid);
//Console.WriteLine(numbers[mid]); 
#endregion

#region Buble


//Buble Sort Big O(n squad)
//int[] numbers = { 4, 2, 13, 5, -2, 45, 32, 15,-5 ,0,500,-10};
//int step = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = 0; j < numbers.Length-1-i; j++)
//    {
//        step++;
//        if (numbers[j] > numbers[j+1])
//        {
//1ci
//            //int save = numbers[j];
//            //numbers[j] = numbers[j + 1];
//            //numbers[j + 1] = save;

//2ci
//            numbers[j]=numbers[j]+numbers[j+1];
//            numbers[j+1] = numbers[j] - numbers[j+1];
//            numbers[j] = numbers[j]-numbers[j+1];

//        }

//    }
//}



//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//Console.WriteLine("Addimlari "+step);

#endregion

//Task 5 1ci
//int[] numbers = { 1, 2, 3, 4, 5 };

//int[] nums2 = new int[numbers.Length];

//for (int i = 0; i < numbers.Length; i++)
//{
//    nums2[nums2.Length - 1 -i ] = numbers[i];
//}

////foreach (var item in nums2)
////{
////    Console.WriteLine(item);
////}

//for (int i = 0; i < nums2.Length; i++)
//{
//    Console.WriteLine(nums2[i]);

//}


//2ci

int[] numbers = { 1, 2, 3, 4, 5,6 };

int j = numbers.Length - 1;

for (int i = 0; i < numbers.Length; i++)
{

    if (i > j) { break; }

    int save=numbers[i];
    numbers[i] = numbers[j];
    numbers[j] = save;

    j--;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
