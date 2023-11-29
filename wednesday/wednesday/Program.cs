using wednesday;

GenericCustomList<int> generic = new();

//generic.Capacity = 1;


//Console.WriteLine(generic.Capacity);
//Console.ReadKey();

generic.Add(1);
generic.Add(2);
generic.Add(3);
generic.Add(4);
generic.Add(5);
Console.WriteLine(generic.Count);
Console.WriteLine(generic.Capacity);