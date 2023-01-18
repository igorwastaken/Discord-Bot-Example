using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.SlashCommands;

namespace DiscordBot;
class Program
{
    static void Main(string[] args)
    {
        MainAsync().GetAwaiter().GetResult();
    }

    static async Task MainAsync()
    {
        var discord = new DiscordClient(new DiscordConfiguration()
        {
            Token = System.Environment.GetEnvironmentVariable("token"),
            TokenType = TokenType.Bot,
            Intents = DiscordIntents.AllUnprivileged
        });
        var slash = discord.UseSlashCommands();
        
        slash.RegisterCommands<PingCommand>();
        await discord.ConnectAsync();
        await Task.Delay(-1);
    }
}