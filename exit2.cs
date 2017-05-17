commands.CreateCommand("close")
  .Do(async (e) =>
  {
    if(e.User.Id == 245140333330038785)
    {
      await e.Channel.SendMessage($"{e.User} Super Bot is stoping");
      await e.Channel.SendMessage("confirm stop in the consol");
      Consol.WriteLine("Do you want to stop the bot");
      Consol.WriteLine("Yes or No");
      if(Consol.ReadLine() == "Yes")
      {
        await e.Channel.SendMessage("The bot has been stoped");
        Console.ForeGroundColor = ConsoleColor.blue;        Console.Write("D");
        Console.ForeGroundColor = ConsoleColor.Yello;        Console.Write("i");
        Console.ForeGroundColor = ConsoleColor.Green;        Console.Write("s");
        Console.ForeGroundColor = ConsoleColor.Red;        Console.Write("c");
        Console.ForeGroundColor = ConsoleColor.Cyan;        Console.Write("o");
        Console.ForeGroundColor = ConsoleColor.White;        Console.Write("n");
        Console.ForeGroundColor = ConsoleColor.DarkBlue;        Console.Write("e");
        Console.ForeGroundColor = ConsoleColor.Magenta;        Console.Write("c");
        Console.ForeGroundColor = ConsoleColor.DarkGreen;        Console.Write("t");
        Console.ForeGroundColor = ConsoleColor.Orang;        Console.Write("e");
        Console.ForeGroundColor = ConsoleColor.DarkCyan;        Console.Write("d");
        
        await discord.Disconect();
      }
    }
  });
