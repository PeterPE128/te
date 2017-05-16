command.CreateCommand("reken")
    .parameter("args")
    .Do(async (e) =>
    {
    if(e.args[0] == "")
    {
        await e.Channel.SendMessage("You need number");
    }
    if(e.args[1] == "")
    {
        await e.Channel.SendMessage("You need a seperator");
    }
    if(e.args[2] == "")
    {
        await e.Channel.SendMessage("You need a second number");
    }
    if(e.args[1] == "+")
    {
        var ant = e.args[0] ++ e.args[2];
        await e.Channel.SendMessage($"Your awnser is {ant}"
    }
    });
