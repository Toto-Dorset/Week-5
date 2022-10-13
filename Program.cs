using OOP_WEEK_5_2;
using System.Collections;
using System.Xml.Linq;
using System.Linq;

int[] ages = { 12, 15, 10, 9, 90, 34, 28, 89, 23, 21, 56, 34, 92, 11, 2, 4, 66, 78, 88, 99, 24 };

//int sizeNewArray = 0;
//for (int i = 0; i < ages.Length; i++)
//{
//    if (ages[i] >= 35)
//    {
//        sizeNewArray++;
//    }
//}
//int[] ageGrThn35 = new int[sizeNewArray];

//int compt = 0;

//for(int i = 0; i < ages.Length; i++)
//{
//    if (ages[i] >= 35)
//    {
//        ageGrThn35[compt] = ages[i];
//        compt++;
//    }
//}
//Array.Sort(ageGrThn35);
//Array.Reverse(ageGrThn35);
//for(int j = 0; j < ageGrThn35.Length; j++)
//{
//    Console.WriteLine(ageGrThn35[j]);
//}
//Console.ReadLine();

//var ageGrThn35 = from age in ages
//                 where age > 35
//                 orderby age descending
//                 select age;

//var ageGrThn35 = ages.Where(age => age > 35).OrderByDescending(age => age).Select(age=>age);

//foreach (var age in ageGrThn35)
//{
//    Console.Write(age + " ; ");
//}
//Console.WriteLine();

//ages[0] = 100;
//foreach (var age in ageGrThn35)
//{
//    Console.Write(age + " ; ");
//}


//Console.ReadKey();

//static int add(int x, int y, int z)
//{
//    return(x+ y + z);
//}

//Func<int,int,int,int>add1 = (x,y,z) => x + y + z;
//Console.WriteLine(add1(1,2,3));


//static bool addAndCompare(int x, int y, int z)
//{
//    int addition = x + y + z;
//    Console.WriteLine(addition);
//    return (addition > 100);
//}

//Func<int, int, int, bool> addAndCompare1 = (x, y, z) =>
//{
//    int a = x + y + z;
//    Console.WriteLine(a);
//    return (a > 100);
//};

ArrayList famAnimals = new ArrayList()
{
    new Animal{Name = "Heidi",Height= .8,Weight =  18 },
    new Animal{Name = "Shrek",Height = 4, Weight =  130 },
    new Animal{Name = "Conga",Height = 3.8, Weight =  90}


};

var famAnimalEnum = famAnimals.OfType<Animal>();

var smallAnimals = from animal in famAnimalEnum
                   where animal.Weight <= 90
                   orderby animal.Name
                   select animal;

foreach(var animal in smallAnimals)
{
    Console.WriteLine(animal.ToString());
}
Console.ReadLine();

var animalList = new List<Animal>()
{
    new Animal { Name = "Heidi", Height = 25, Weight = 77 },
    new Animal { Name = "Chihuahua", Height = 7, Weight = 4.4 },
    new Animal { Name = "Saint Bernard", Height = 30, Weight = 200 }
};

var bigDogs = from dog in animalList
              where (dog.Weight > 70) && (dog.Height > 25)
              orderby dog.Name
              select dog;

foreach(var dog in bigDogs)
{
    Console.WriteLine("A {0} weighs {1}lbs", dog.Name, dog.Weight);
}

Console.ReadLine();

string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Lassie" , "Snoopie"};

var dogWithSpaceInName = from dog in dogs
                         where dog.Contains(" ")
                         orderby dog
                         select dog;

foreach(var dog in dogWithSpaceInName)
{
    Console.Write(dog + " ; ");
}
Console.ReadLine();