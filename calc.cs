command.CreateCommand("reken")
    .parameter("ags")
    .Do(async (e) =>
    {
    if(Args[0] == "")
    {
        e.Channel.SendMessage("You need number");
    }
    if(Args[1] == "")
    {
        e.Channel.SendMessage("You need a seperator");
    }
    if(Args[2] == "")
    {
        e.Channel.SendMessage("You need a second number");
    }
    if(Args[1] == "+")
    {
    var ant = Args[0] ++ Args[2];
    await e.Channel.SendMessage($"Your awnser is {ant}"
    }
    });
