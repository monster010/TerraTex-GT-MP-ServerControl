using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TerraTex_GT_MP_ServerControl
{
    class CheckProcess
    {
        private Form1 _form;
        private int _liveOfflineCounter = 0;
        private int _devOfflineCounter = 0;

        private int _liveLastCheck = 0;
        private int _devLastCheck = 0;

        public CheckProcess(Form1 form)
        {
            _form = form;
        }

        public Int32 GetUnixTimeStamp()
        {
            return (Int32) (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        public void DoWork()
        {
            while (!_shouldStop)
            {
                CheckLiveProcess();
                CheckDevProcess();
                Thread.Sleep(500);
            }
        }
        public void RequestStop()
        {
            _shouldStop = true;
        }
        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
        private volatile bool _shouldStop;

        private void CheckLiveProcess()
        {
            string livePath = app.Default.live_path;
            decimal liveSeconds = app.Default.live_timeuntilrestart;
            bool liveAutoRestart = app.Default.live_autorestart;

            List<Process> p = GetProcessByFilename(livePath);
            if (p.Count > 0)
            {
                _form.SetLiveServerStatus(1, 0);
                _liveOfflineCounter = 0;
                _liveLastCheck = GetUnixTimeStamp();
            }
            else
            {
                if (_liveLastCheck == 0)
                {
                    _liveLastCheck = GetUnixTimeStamp();
                }

                Int32 time = GetUnixTimeStamp() - _liveLastCheck;
                _liveLastCheck = GetUnixTimeStamp();
                _liveOfflineCounter += time;

                _form.SetLiveServerStatus(0, _liveOfflineCounter);

                if (_liveOfflineCounter > liveSeconds && liveAutoRestart)
                {
                    _form.SetLiveServerStatus(2, _liveOfflineCounter);
                    if (CheckBuildStatusOfJenkins("master"))
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WorkingDirectory = Path.GetDirectoryName(livePath);
                        startInfo.FileName = livePath;
                        Process.Start(startInfo);
                        Thread.Sleep(5000);
                        _liveOfflineCounter = 0;
                    }
                }
            }

        }

        private void CheckDevProcess()
        {
            string devPath = app.Default.dev_path;
            decimal devSeconds = app.Default.dev_timeuntilrestart;
            bool devAutoRestart = app.Default.dev_autorestart;

            List<Process> p = GetProcessByFilename(devPath);
            if (p.Count > 0)
            {
                _form.SetDevServerStatus(1, 0);
                _devOfflineCounter = 0;
                _devLastCheck = GetUnixTimeStamp();

                if (!CheckBuildStatusOfJenkins("develop"))
                {
                    p[0].Kill();
                }
            }
            else
            {
                if (_devLastCheck == 0)
                {
                    _devLastCheck = GetUnixTimeStamp();
                }

                Int32 time = GetUnixTimeStamp() - _devLastCheck;
                _devLastCheck = GetUnixTimeStamp();
                _devOfflineCounter += time;
                _form.SetDevServerStatus(0, _liveOfflineCounter);

                if (_devOfflineCounter > devSeconds && devAutoRestart)
                {
                    _form.SetDevServerStatus(2, _devOfflineCounter);

                    if (CheckBuildStatusOfJenkins("develop"))
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WorkingDirectory = Path.GetDirectoryName(devPath);
                        startInfo.FileName = devPath;
                        Process.Start(startInfo);
                        Thread.Sleep(5000);
                        _devOfflineCounter = 0;
                    }
                }
            }

        }

        private bool CheckBuildStatusOfJenkins(string branch)
        {
            // Path 1: 
            // Path 2: http://build.terratex.eu:8080/job/TerraTex-Community/job/GT-MP-Reallife-RPG-Script/job/develop/{latestBuildId}/api/json
            // 3.: building: false && result: SUCCESS

            WebRequest request = WebRequest.Create("http://build.terratex.eu:8080/job/GT-MP-Reallife-RPG-Script/job/" + branch + "/api/json");
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            JObject jo = JObject.Parse(responseFromServer);
            JObject lastBuild = (JObject)jo.GetValue("lastBuild");
            string buildUrl = (string)lastBuild.GetValue("url");
            buildUrl += "api/json";

            request = WebRequest.Create(buildUrl);
            response = request.GetResponse();
            dataStream = response.GetResponseStream();
            reader = new StreamReader(dataStream);
            responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();

            jo = JObject.Parse(responseFromServer);

            string result = (string) jo.GetValue("result");
            string building = (string) jo.GetValue("building");

            if (building.Equals("False") && result.Equals("SUCCESS"))
            {
                return true;
            }
            return false;
        }

        private static List<Process> GetProcessByFilename(string filename)
        {
            List<Process> processes = new List<Process>();

            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    if (process.MainModule.FileName == filename)
                    {
                        processes.Add(process);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return processes;
        }
    }
}
