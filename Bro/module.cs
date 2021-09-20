using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Bro
{
    class module
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static int VK_SHIFT = 0x10;
        private static int VK_CONTROL = 0x11;
        private static int VK_MENU = 0x12;


        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 vKey);

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        public static void Start()
        {
            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }

        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {

            if (Bro.flag == true)
                foreach (var line in File.ReadAllLines(Bro.logfile))
                {
                    string[] info = line.Split(",");
                    if (info[2].Equals("3"))
                        if ((GetAsyncKeyState(VK_CONTROL) != 0) & (GetAsyncKeyState(VK_MENU) != 0) & GetAsyncKeyState(char.Parse(info[3])) != 0)
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @info[1], UseShellExecute = true });

                        }
                    if (info[2].Equals("6"))
                        if ((GetAsyncKeyState(VK_CONTROL) != 0) & (GetAsyncKeyState(VK_SHIFT) != 0) & GetAsyncKeyState(char.Parse(info[3])) != 0)
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @info[1], UseShellExecute = true });
                        }
                }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
    }
}
