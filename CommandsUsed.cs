int count = int.Parse(File.ReadAllText("CommandsUsed.dat"));
count++;
File.WriteAllText("CommandsUsed.dat", count.ToString());

int count = 0;
File.WriteAllText("CommandsUsed.dat", count.ToString());
