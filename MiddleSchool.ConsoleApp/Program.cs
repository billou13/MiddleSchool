using System.Drawing;

switch(args[0])
{
    case "embed":
        var image = SteganographyHelper.embedText(File.ReadAllText(args[1]), new Bitmap(@"Images\Bordeaux.png"));
        image.Save($"{Path.GetFileNameWithoutExtension(args[1])}.png");
        Console.WriteLine("Image créée !");
        break;
    case "extract":
        string text = SteganographyHelper.extractText(new Bitmap(args[1]));
        File.WriteAllText($"{Path.GetFileNameWithoutExtension(args[1])}.txt", text);
        Console.WriteLine("Texte récupéré !");
        break;
}
