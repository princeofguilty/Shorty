using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Threading;

namespace Shorty
{
    static class Speech_recognition
    {
        internal static CancellationTokenSource _tokensource = null;
        private static SpeechRecognitionEngine engine;
        static Choices SLES = new Choices(); // class Choice of loadGrammer Method
        public static void init()
        {

                SLES.Add(new String[] { "SHORTY" });
            foreach (String line in File.ReadAllLines(Shorty.logfile)) {
                try
                {
                    string line_call = line.Split(", ")[4];
                    SLES.Add(line_call);
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

        public static void add_choice(string s) {
            SLES.Add(s);
            //init();
            engine.RequestRecognizerUpdate();
        }

        private static void new_call(object sender, EventArgs e)
        {
            _tokensource?.Cancel();
            _tokensource = new CancellationTokenSource();
            _ = awaitforAsync(_tokensource.Token);
        }

        private static async Task awaitforAsync(CancellationToken token)
        {
            try
            {
                await Task.Delay(1000, token);
            }
            catch (OperationCanceledException)
            {
                throw;
            }

            

        }

        static void rec(object sender, SpeechRecognizedEventArgs e)
        {
            
            SpeechSynthesizer sythesizer = new SpeechSynthesizer();
            //sythesizer.Speak(e.Result.Text);
            //sythesizer.Speak(e.Result.Confidence.ToString());

            if (e.Result.Confidence < 0.92)
            {
                return;
            }
            else { 
                //new_call()
            }
            foreach (String line in File.ReadAllLines(Shorty.logfile))
            {
                try
                {
                    string[] line_call = line.Split(", ");
                    if (line_call[4].ToLower() == e.Result.Text.ToLower()) {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = line_call[1], UseShellExecute = true });
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }

            //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @applocation, UseShellExecute = true });

        }
    }
        
}
