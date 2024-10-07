var filename = "doc.txt";
if (File.Exists(filename))
{
    var content = File.ReadAllText(filename);
    Console.WriteLine(content);
}
else
{
    Console.WriteLine("The file does not exist. Do you want to create it?");
}
