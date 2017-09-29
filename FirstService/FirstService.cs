using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FirstService
{
    public partial class FirstService : ServiceBase
    {
        public FirstService()
        {
            InitializeComponent();
            if (!EventLog.SourceExists("FirstService"))
            {
                EventLog.CreateEventSource("FirstService", "Application");
            }
            eventLog1.Source = "FirstService";
            eventLog1.Log = "Application";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Dienst wird gestartet", EventLogEntryType.Information, 1001);
        }
        protected override void OnStop()
        {
            eventLog1.WriteEntry("Dienst wird beendet", EventLogEntryType.Information, 1001);
        }
        protected override void OnPause()
        {
            eventLog1.WriteEntry("Dienst wird angehalten", EventLogEntryType.Information, 1001);
        }
        protected override void OnContinue()
        {
            eventLog1.WriteEntry("Dienst wird fortgesetzt", EventLogEntryType.Information, 1001);
        }
        protected override void OnShutdown()
        {
            eventLog1.WriteEntry("Dienst wird heruntergefahren", EventLogEntryType.Information, 1001);
        }

    }
}
