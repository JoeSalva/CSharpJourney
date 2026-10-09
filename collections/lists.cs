// Lists, just like Arrays, are zero based.
// They can be added to and removed from
// To declare a list:

List<string> words = new List<string> ();

//short form
// List<string> words = new();

// to add values to a list

words.Add("one");
words.Add("two");
words.Add("three");

// to get the values from a list
string firstWord = words[0];
string secondWord = words[1];
string thirdWord = words[2];

// easy overwrite
words[0] = "Zero";