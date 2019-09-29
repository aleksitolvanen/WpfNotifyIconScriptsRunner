using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfNotifyIconScriptsRunner.Commands
{
    /// <summary>
    /// Command that calls nircmd.dll setdefaultsounddevice with given parameter
    /// to set default sound device
    /// </summary>
    public class SetDefaultSoundDeviceCommand : ICommand
    {
        public void Execute(object parameter)
        {
            NirCmdCall.DoNirCmd($"setdefaultsounddevice \"{parameter}\"");
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }
    }
}
