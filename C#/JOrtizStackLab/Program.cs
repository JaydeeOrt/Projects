/*
 * Jorge Ortiz
 * CPT-244-A01H
 * StackssLab
 */

//I was confused about actually taking someones Browser stuff so i simulate it
Stack<string> webSiteLog = new Stack<string>();
string userInput = "";

while (userInput != "EXIT")
{
    Console.WriteLine("Commands:Search,Back,Peek,Exit");
    userInput = Console.ReadLine();
    //Simulates you searching for a website
    if (userInput.ToUpper() == "SEARCH")
    {
        Console.WriteLine("Pleaese enter Website to log: ");
        userInput = Console.ReadLine();
        webSiteLog.Push(userInput);
    }
    //Peeks back at your last website
    else if (userInput.ToUpper() == "PEEK")
    {

        if (webSiteLog.Count() == 0)
        {
            Console.WriteLine("Nothing to check.");
        }
        else
        {
            Console.WriteLine("Your last website was:" + webSiteLog.Peek());
        }
    }
    //Brings you back to your last website
    else if (userInput.ToUpper() == "BACK")
    {
        if (webSiteLog.Count() == 0)
        {
            Console.WriteLine("Nothing to go back to.");
        }
        else
        {
            Console.WriteLine(webSiteLog.Pop());
        }
    }
    //Exits when your finished
    else if (userInput.ToUpper() == "EXIT")
    {
        userInput = "EXIT";
    }
    else 
    {
        Console.WriteLine("Not valid input");
    }
}