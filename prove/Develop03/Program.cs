using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the scripture memorizer!\n");
        Scripture scriptures1 = new Scripture("Helaman", 7, 1, "Behold, now it came to pass in the sixty and ninth year of the reign of the judges over the people of the Nephites, that Nephi, the son of Helaman, returned to the land of Zarahemla from the land northward.");
        Scripture scriptures2 = new Scripture("1 Nephi", 12, 1, 3, "And it came to pass that the angel said unto me: Look, and behold thy seed, and also the seed of thy brethren. And I looked and beheld the land of promise; and I beheld multitudes of people, yea, even as it were in number as many as the sand of the sea. And it came to pass that I beheld multitudes gathered together to battle, one against the other; and I beheld wars, and rumors of wars, and great slaughters with the sword among my people. And it came to pass that I beheld many generations pass away, after the manner of wars and contentions in the land; and I beheld many cities, yea, even that I did not number them.");
        Console.Write(scriptures1.GetScriptureReference());
        scriptures1.ShowScripture();
        bool quitnow = false;
        string continuing = "";
        while(continuing != "q" && quitnow==false){
            Console.Write("Press q to quit and enter to hide the scripture: ");
            continuing = Console.ReadLine();
            if(continuing != "q"){
                quitnow = scriptures1.HideSomeWords();
            }
            else if(quitnow==true || continuing=="q"){
                System.Environment.Exit(0);
            }
            scriptures1.ShowScripture();
        }
    }
}