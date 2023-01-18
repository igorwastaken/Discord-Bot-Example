using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.SlashCommands;

namespace DiscordBot;
public class PingCommand : ApplicationCommandModule {
  [SlashCommand("ping", "ping pong")]
  public async Task run(InteractionContext ctx) {
    await ctx.CreateResponseAsync($"Pong! {ctx.Client.Ping}ms");
  }
}