using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;


namespace Shorty
{
    static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Speech_recognition.init();

            SpeechSynthesizer sythesizer = new SpeechSynthesizer();
            sythesizer.Speak("ITS SHORTY!");

            Speech_recognition.add_choice("hello");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Shorty());

        }



    }
}
