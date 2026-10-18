// // Dictionaries are used to store key, value pairs
// // They are dynamic in size
// // The keys are unique, but values do not need to be

// // to declare a dictionary
// Dictionary<string, int> WordToNumber = new Dictionary<string, int>();
// Dictionary<string,int> shorthand = new();

// // To add entries to a dictionary
// WordToNumber.Add("one", 1);
// WordToNumber.Add("two", 2);
// WordToNumber.Add("three", 3);

// // Console.WriteLine(WordToNumber);

// Dictionary<int,string> numbersToWords = new()
// {
//   [1]="one",
//   [2]="two",
//   [3]="three",
// };

// // Console.WriteLine(numbersToWords);

// // to check if a dictionary contains a key
// bool contain = numbersToWords.ContainsKey(2);

// // to check if a dictionary has a value and to get it

// bool contain2 = numbersToWords.TryGetValue(3, out string? value);

// Console.WriteLine(contain);
// Console.WriteLine(contain2);