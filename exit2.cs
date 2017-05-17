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
        Console.ForegroundColor = ConsoleColor.blue;        Console.Write("D");
        Console.ForegroundColor = ConsoleColor.Yello;        Console.Write("i");
        Console.ForegroundColor = ConsoleColor.Green;        Console.Write("s");
        Console.ForegroundColor = ConsoleColor.Red;        Console.Write("c");
        Console.ForegroundColor = ConsoleColor.Cyan;        Console.Write("o");
        Console.ForegroundColor = ConsoleColor.White;        Console.Write("n");
        Console.ForegroundColor = ConsoleColor.DarkBlue;        Console.Write("e");
        Console.ForegroundColor = ConsoleColor.Magenta;        Console.Write("c");
        Console.ForegroundColor = ConsoleColor.DarkGreen;        Console.Write("t");
        Console.ForegroundColor = ConsoleColor.Orang;        Console.Write("e");
        Console.ForegroundColor = ConsoleColor.DarkCyan;        Console.Write("d");
        Task.Delay(5000);
        await discord.Disconect();
      }
    }
  });
