using MemoryProblem_Example2;

Console.Write("Running example 2 of memory problem app... Press ENTER to start.");
Console.ReadLine();

var objClass1 = new ExampleObject();
var objClass2 = new ExampleObject();
var objClass3 = new ExampleObject();
var objClass4 = new ExampleObject();
var objClass5 = new ExampleObject();
var objClass6 = new ExampleObject();
var objClass7 = new ExampleObject();
var objClass8 = new ExampleObject();
var objClass9 = new ExampleObject();
var objClass10 = new ExampleObject();

Console.Write("Press ENTER to force clean.");
Console.ReadLine();

GC.Collect();

Console.Write("Press ENTER to stop.");
Console.ReadLine();