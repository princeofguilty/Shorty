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

namespace Shorty
{
    static class Speech_recognition
    {
        internal static CancellationTokenSource _tokensource = null;
        private static SpeechRecognitionEngine engine;
        static Choices SLES = new Choices(); // class Choice of loadGrammer Method
        public static void init()
        {

            foreach (String line in File.ReadAllLines(Shorty.logfile)) {
                try
                {
                    string line_call = line.Split(", ")[4];
                    SLES.Add("open "+line_call.ToLower()+ " shorty");
                    SLES.Add("okey shorty "+line_call.ToLower());
                }
                catch (Exception) {
                    continue;
                }
            }

            Grammar gr = new Grammar(new GrammarBuilder(SLES));
            engine = new SpeechRecognitionEngine();
            engine.SetInputToDefaultAudioDevice();
            engine.LoadGrammar(gr);
            engine.RecognizeAsync(RecognizeMode.Multiple);
            engine.SpeechRecognized += rec;
        }

        static void rec(object sender, SpeechRecognizedEventArgs e)
        {
            
            SpeechSynthesizer sythesizer = new SpeechSynthesizer();
            MessageBox.Show(e.Result.Text);

            if (e.Result.Confidence < 0.73)
                return;

            sythesizer.Speak("openning "+e.Result.Text.Split(" ")[2]);
            foreach (String line in File.ReadAllLines(Shorty.logfile))
            {
                try
                {
                    string[] line_call = line.Split(", ");

                    if (("okey shorty " + line_call[4].ToLower()) == e.Result.Text.ToLower()) {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = line_call[1], UseShellExecute = true });
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            sythesizer.Dispose();
            

        }
    }
        
}
