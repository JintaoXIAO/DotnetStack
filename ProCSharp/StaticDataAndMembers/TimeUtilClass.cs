namespace StaticDataAndMembers;

using static Console;
using static DateTime;

static class TimeUtilClass
{
    public static void PrintTime()
        => WriteLine(Now.ToShortTimeString());

    public static void PrintDate()
        => WriteLine(Today.ToShortDateString());
}