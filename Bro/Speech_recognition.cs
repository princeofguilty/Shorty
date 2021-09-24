using System;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Threading;
using System.Media;

namespace Bro
{

    class Speech_recognition
    {
        internal static CancellationTokenSource _tokensource = null;
        private static SpeechRecognitionEngine engine;
        private static Choices SLES = new Choices(); // class Choice of loadGrammer Method
        private static System.Timers.Timer aTimer;
        private static int runtime = 0;
        private static SpeechSynthesizer sythesizer;
        private static SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.yes);
        
        public static void init()
        {
            SLES.Add("hey bro");
            SLES.Add("bro");
            SLES.Add("deactivate shortcuts");
            SLES.Add("activate shortcuts");

            foreach (String line in File.ReadAllLines(Bro.logfile))
            {
                try
                {
                    string line_call = line.Split(",")[4];
                    SLES.Add("open " + line_call.ToLower());

                }
                catch (Exception)
                {
                    continue;
                }
            }

            sythesizer = new SpeechSynthesizer();

            Grammar gr = new Grammar(new GrammarBuilder(SLES));
            engine = new SpeechRecognitionEngine();
            engine.SetInputToDefaultAudioDevice();
            engine.LoadGrammar(gr);
            engine.RecognizeAsync(RecognizeMode.Multiple);
            engine.SpeechRecognized += rec;
        }


        internal static void rec(object sender, SpeechRecognizedEventArgs e)
        {

            //if (e.Result.Confidence < 0.4)
            //  return;

            if (e.Result.Text.Equals("deactivate shortcuts"))
            {
                sythesizer.SpeakAsync(e.Result.Text);
                Bro.flag_speech = true;
            }
            else if (e.Result.Text.Equals("activate shortcuts"))
            {
                sythesizer.SpeakAsync(e.Result.Text);
                Bro.flag_speech = true;
            }


            if (e.Result.Text.Equals("hey bro") || e.Result.Text.Equals("bro"))
            {
                if (runtime == 1)
                {
                    aTimer.Stop();
                    aTimer.Start();
                }
                runtime = 1;
                aTimer = new System.Timers.Timer(5000);
                aTimer.AutoReset = false;
                aTimer.Elapsed += async (sender, e) => await HandleTimer();
                aTimer.Start();

                player.Play();

                return;
            }

            if (runtime == 0)
                return;

            sythesizer.SpeakAsync("openning " + e.Result.Text.Replace("open ", ""));

            foreach (String line in File.ReadAllLines(Bro.logfile))
            {
                try
                {
                    string[] line_call = line.Split(",");
                    if (("open " + line_call[4].ToLower()).Equals(e.Result.Text.ToLower()))
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = line_call[1], UseShellExecute = true });
                        runtime = 0;
                        break;
                    }

                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        static Task HandleTimer()
        {
            runtime = 0;
            //sythesizer.Speak(runtime.ToString());
            aTimer.Stop();
            //sythesizer.Dispose();
            return Task.CompletedTask;
        }

    }

}
