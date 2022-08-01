using System.Diagnostics;

string text = File.ReadAllText("C:\\Users\\Asktosimon\\Downloads\\Text1.txt");

char[] delimiters = new char[] { ' ', '\r', '\n' };

// LIST
var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
var list = new List<string>(words);
var watch = Stopwatch.StartNew();

list.Add("Hello");

Console.WriteLine($"Вставка в  list: {watch.Elapsed.TotalMilliseconds}  мс");

// LINKED LIST
var linkedList = new LinkedList<string>(words);
var watchTwo = Stopwatch.StartNew();

linkedList.AddLast("Hello");

Console.WriteLine($"Вставка в  linkedList: {watchTwo.Elapsed.TotalMilliseconds}  мс");
