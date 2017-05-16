commands.CreateCommand("close")
.Do(async (e) =>
{
  await e.Channel.SendMessage($"{e.User} Super Bot is stoping")
}
