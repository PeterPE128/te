command.CreateCommand("rollDice")
        .Description("Rolls a random Number between Min and Max")
        .Parameter("Min")
        .Parameter("Max")
        .Do(async e =>
        {
            await e.Channel.SendMessage($"[{random.Next(int.Parse(e.Args[0]), int.Parse(e.Args[1]) + 1)}]);
        });
