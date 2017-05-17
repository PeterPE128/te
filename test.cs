if(CommandsUsed >= 0)
{
    var path = @"memes\lol.txt";
    var line = "1";//haha
    var CommandsUsed1 = File.readLines(path, line);
    CommandsUsed1++
    File.writeLine(path, $"{CommandsUsed1}");
    Console.WriteLine($"ther are now {CommandsUsed1} used");
    CommandsUsed = 0;
}
else
{
    return;
}
