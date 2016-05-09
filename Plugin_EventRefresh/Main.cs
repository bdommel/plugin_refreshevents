using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using rdjInterface;

namespace Plugin_EventRefresh
{
    public class Main: IPlugin  
    {
        // every 30 seconds (30 * 1000ms)
        private Timer _timer = new Timer();
        // the application host
        private IHost _host;

        public void AddTrack2Plugin(TrackPlayer trackData, long TriggerOn, int Position = -1)
        {
        }

        public void AddTrack2Plugin(int trackID, long TriggerOn, int Position = -1)
        {
        }

        public void AssistedStateChanged(bool newState)
        {
        }

        public void AutoDJStateChanged(bool newState)
        {
        }

        public List<Events.EventAction> AvailableActions()
        {
            return null;
        }

        public void Closing()
        {
        }

        public bool HasActions
        {
            get { return false; }
        }

        public void Initialize(IHost Host)
        {
            _host = Host;
            _timer.Interval = 30 * 1000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            _host.RefreshEvents = true;
        }

        public void InputStateChanged(bool newState)
        {
        }

        public void KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
        }

        public System.Windows.Forms.UserControl LoadGUI()
        {
            return null;
        }

        public bool NotifyOnPlaylistChange
        {
            get { return false; }
        }

        public bool NotifyOnTrackChange
        {
            get { return false; }
        }

        public bool NotifyOnUIChange
        {
            get { return false; }
        }

        public void PlaylistChanged()
        {
        }

        public string PluginDescription
        {
            get { return "Plugin for refreshing Events"; }
        }

        public string PluginName
        {
            get { return "Event Refresh"; }
        }

        public string PluginTitle
        {
            get { return "Event Refresh";  }
        }

        public string PluginVersion
        {
            get { return "1.0.0.0"; }
        }

        public int PluginZone
        {
            get { return 0; }
        }

        public void ReloadCategories()
        {
        }

        public void ReloadLanguage()
        {
        }

        public bool RunAction(string ActionName, string[] args)
        {
            return false;
        }

        public void ShowAbout()
        {
            MessageBox.Show("2016, Bart van Dommelen - PureRadio.one.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowConfig()
        {
            // perhaps a timer elapse?
        }

        public void ShowMain()
        {            
        }

        public void TrackChanged(TrackPlayer TrackData)
        {
        }
    }
}
