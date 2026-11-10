using System;
using VRage.Utils;

namespace PolarsADSLean;

/// <summary>Writes to the game log with a "[PolarsADSLean]" prefix. Messages are not format strings.</summary>
internal static class Log
{
    private const string Prefix = "[" + Plugin.Name + "] ";

    public static void Info(string message) => MyLog.Default?.WriteLine(Prefix + message);

    public static void Error(string message, Exception e) => MyLog.Default?.WriteLine(Prefix + message + ": " + e);
}
