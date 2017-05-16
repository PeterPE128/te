if(CommandsUsed >= 0)
{
    var path = @"memes\lol.txt";
    var line = "1";//haha
    var CommandsUsed1 = File.readLines(path, line);
    CommandsUsed1++
    File.writeLine(path, $"{CommandsUsed1}$");
}
