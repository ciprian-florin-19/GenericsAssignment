using Generics;

var collection = new GenericCollection<string>(10);
collection[0] = "1";
collection[1] = "2";
try
{
    collection.SwapItems(0, collection[0]);
} 
catch(Exception e)
{
    Console.WriteLine(e.Message);
}