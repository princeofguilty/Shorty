using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace Shorty
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
            SLES.Add("okey shorty");
            foreach (String line in File.ReadAllLines(Shorty.logfile)) {
                try
                {
                    string line_call = line.Split(", ")[4];
                    SLES.Add("open "+line_call.ToLower()+ " shorty");
                    SLES.Add("open " + line_call.ToLower());
                    //SLES.Add("okey shorty "+line_call.ToLower());
                }
                catch (Exception) {
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

            if (e.Result.Confidence < 0.80)
                return;

            if (e.Result.Text == "okey shorty")
            {
                if (runtime == 1) {
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

            sythesizer.Speak("openning "+e.Result.Text.Split(" ")[1]);
            foreach (String line in File.ReadAllLines(Shorty.logfile))
            {
                try
                {
                    string[] line_call = line.Split(", ");

                    if (("open " + line_call[4].ToLower()) == e.Result.Text.ToLower()) {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = line_call[1], UseShellExecute = true });
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            //sythesizer.Dispose();
            

        }

        static Task HandleTimer() {
            runtime = 0;
            //sythesizer.Speak(runtime.ToString());
            aTimer.Stop();
            //sythesizer.Dispose();
            return Task.CompletedTask;
        }
    }
        
}
