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
            discord.Disconect();
            Console.WriteLine("The Bot has been Disconected");
        }
     }
  
});
