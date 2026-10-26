// These loops are used to iterate between collections
// foreach (Type thing in CollectionOfThings)
// {
//    //do something
// }

int[] numbers = {1, 2, 3, 4, 5, 6, 7};

foreach (int number in numbers)
{
    Console.WriteLine(number * 2);
}

Dictionary<string, int> age = new()
{
   ["Tayo"]= 13,
   ["Mary"]=15,
   ["Ayo"]=12,
};

foreach(var person in age)
{
    Console.WriteLine($"{person.Key} is {person.Value} ");
}