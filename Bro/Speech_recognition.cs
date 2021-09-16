using System;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Threading;
using System.Media;

namespace Bro
{
    static class Speech_recognition
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

            foreach (String line in File.ReadAllLines(Bro.logfile))
            {
                try
                {
                    string[] line_call = line.Split(",");
                    for (int i = 4; i < line_call.Length; i++)
                    {
                        SLES.Add("open " + line_call[i].ToLower() + " bro");
                        SLES.Add("open " + line_call[i].ToLower());
                        //SLES.Add("okey Bro "+line_call.ToLower());
                    }
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

        static void rec(object sender, SpeechRecognizedEventArgs e)
        {


            //MessageBox.Show(e.Result.Text);

            if (e.Result.Confidence < 0.8)
                return;

            if (e.Result.Text == "deactivate shortcuts") {
                //Bro.flag = false;
                //Bro.logo_Click();
            }

            if (e.Result.Text == "hey bro" || e.Result.Text == "bro")
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

            sythesizer.SpeakAsync("openning " + e.Result.Text.Replace("open ",""));

            foreach (String line in File.ReadAllLines(Bro.logfile))
            {
                try
                {
                    string[] line_call = line.Split(",");
                    for (int i = 4; i< line_call.Length; i++) {
                        if (("open " + line_call[i].ToLower()) == e.Result.Text.ToLower())
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = line_call[1], UseShellExecute = true });
                            runtime = 0;
                            break;
                        }
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
