using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Shorty
{
    static class Speech_recognition
    {
        private static SpeechRecognitionEngine engine;
        static Choices SLES = new Choices(); // class Choice of loadGrammer Method
        public static void init()
        {
                SLES.Add(new String[] { "SHORTY" });
                Grammar gr = new Grammar(new GrammarBuilder(SLES));
                engine = new SpeechRecognitionEngine();
                engine.SetInputToDefaultAudioDevice();
                engine.LoadGrammar(gr);
                engine.RecognizeAsync(RecognizeMode.Multiple);
                engine.SpeechRecognized += rec;
        }

        public static void add_choice(string s) {
            SLES.Add(s);
            init();
        }

        static void rec(object sender, SpeechRecognizedEventArgs e)
        {
            SpeechSynthesizer sythesizer = new SpeechSynthesizer();
            sythesizer.Speak(e.Result.Text);
        }
    }
        
}
