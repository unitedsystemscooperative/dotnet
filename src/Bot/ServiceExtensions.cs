using System.Diagnostics.CodeAnalysis;
using Discord;
using Discord.Interactions;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UnitedSystemsCooperative.Bot.Interfaces;
using UnitedSystemsCooperative.Bot.Models;
using UnitedSystemsCooperative.Bot.Modules;
using UnitedSystemsCooperative.Bot.Modules.Commands;
using UnitedSystemsCooperative.Bot.Modules.Events;
using UnitedSystemsCooperative.Bot.Services;

namespace UnitedSystemsCooperative.Bot;

[ExcludeFromCodeCoverage]
public static class ServiceExtensions
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        DiscordSocketConfig socketConfig = new()
        {
            GatewayIntents = GatewayIntents.Guilds | GatewayIntents.GuildMessages |
                             GatewayIntents.GuildMessageReactions | GatewayIntents.GuildMembers,
            AlwaysDownloadUsers = true
        };
        
        services.AddSingleton(configuration);
        services.AddSingleton(socketConfig);
        services.AddSingleton<DiscordSocketClient>();
        services.AddSingleton(x => new InteractionService(x.GetRequiredService<DiscordSocketClient>()));
        services.AddSingleton<CommandHandler>();
        services.AddSingleton<EducationCommandModule>();
        services.AddSingleton<BotEventHandler>();
        services.AddSingleton<IDatabaseService, MongoDbService>();
        services.AddSingleton<GalnetModule>();

        services.AddHttpClient<InaraCommandModule>(client => new HttpClient
            {BaseAddress = new Uri(configuration["InaraConfig:ApiUrl"])});
        services.AddHttpClient<GalnetModule>();
        services.AddHttpClient();
    }

    public static void AddConfigs(this IServiceCollection services)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.local.json", true)
#if DEV
            .AddJsonFile("appsettings.dev.json", false)
#else
            .AddJsonFile("appsettings.prod.json", false)
#endif
            .AddJsonFile("appsettings.json", false)
            .Build();
        services.Configure<InaraConfig>(configuration.GetSection(InaraConfig.ConfigName));
        services.Configure<ServerValues>(configuration.GetSection(ServerValues.ConfigName));
        services.Configure<List<Rank>>(configuration.GetSection("ranks"));
    }
}