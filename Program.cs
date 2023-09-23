// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Binary_Tree b = new Binary_Tree();
b.Add(15);
b.Add(12);
b.Add(20);
b.Add(11);
b.Add(21);
//b.Add(13);
Console.WriteLine(b.GetTreeDepth());
//b.Remove(12);
b.TraverseInOrder(b.Root);
Console.WriteLine();
/*Node search = b.Find(15);
try
{
    if (search.Data != null)
    Console.WriteLine("Data was found");
}
catch (Exception e)
{
    Console.WriteLine("Data doesnt exist");
}*/
