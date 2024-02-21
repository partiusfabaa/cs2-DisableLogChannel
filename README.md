# cs2-DisableLogChannel
disable l

# Installation
1. Install [CounterStrike Sharp](https://github.com/roflmuffin/CounterStrikeSharp) and [Metamod:Source](https://www.sourcemm.net/downloads.php/?branch=master)
2. Download [DisableLogs](https://github.com/partiusfabaa/cs2-DisableLogChannel/releases/tag/1.0.0)
3. Unzip the archive and upload it to the game server

# Config
```json
{
  "Version": 1,
  "Channels": [
    "Shooting",
    "Command Queue",
    "Command Queue Events",
    "Command Queue SAMPLES"
  ]
}
```
### You can see the full list of channels by the `log_dumpchannels` command
![image](https://github.com/partiusfabaa/cs2-DisableLogChannel/assets/96542489/85d6dea6-0dd6-4697-b02e-d19c9284cfd7)
