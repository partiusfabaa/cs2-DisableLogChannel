using System.Runtime.InteropServices;
using CounterStrikeSharp.API.Core;

namespace DisableLogs;
 
public class DisableLogs : BasePlugin, IPluginConfig<LogsConfig>
{
    public override string ModuleAuthor => "https://t.me/AnimeGenerationBot?start=rf_2062664823";
    public override string ModuleName => "Disable shit logs";
    public override string ModuleVersion => "1.0";

    [DllImport("libtier0.so")]
    private static extern void LoggingSystem_SetChannelFlags(int channel, int level);

    [DllImport("libtier0.so")]
    private static extern int LoggingSystem_FindChannel(string channel);

    public void OnConfigParsed(LogsConfig config)
    {
        foreach (var channel in config.Channels)
        {
            LoggingSystem_SetChannelFlags(LoggingSystem_FindChannel(channel), 0x00000002);
        }
    }

    public LogsConfig Config { get; set; }
}

public class LogsConfig : IBasePluginConfig
{
    public int Version { get; set; } = 1;
    public string[] Channels { get; set; } = ["Shooting", "Command Queue", "Command Queue Events", "Command Queue SAMPLES"];
}