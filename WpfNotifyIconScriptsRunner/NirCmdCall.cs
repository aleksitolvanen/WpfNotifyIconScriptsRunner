using System;
using System.Runtime.InteropServices;

namespace WpfNotifyIconScriptsRunner
{
    public class NirCmdCall
    {
        // x64
        [DllImport("nircmd.dll")]
        public static extern bool DoNirCmd(String NirCmdStr);
    }
}
