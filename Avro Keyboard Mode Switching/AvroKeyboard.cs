/*
    Author: OmicronLab (http://OmicornLab.com/)
    Date Created: 04 January, 2011
    Last Updated: 04 January, 2011
    Updated By: M. M. Rifat-Un-Nabi (to.rifat@gmail.com)
    Update Description: Initaial Release
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OmicronLab
{
    class AvroKeyboard
    {
        
        [DllImport("User32.dll")]
        private static extern int RegisterWindowMessage(string lpString);

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern Int32 FindWindow(String lpClassName, String lpWindowName);

        //For use with WM_COPYDATA and COPYDATASTRUCT
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, int Msg, int wParam, ref COPYDATASTRUCT lParam);

        public const int WM_COPYDATA = 0x4A;

        //Used for WM_COPYDATA for string messages
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        private static int sendWindowsStringMessage(int hWnd, int wParam, string msg)
        {
            int result = -1;

            if (hWnd > 0)
            {
                byte[] sarr = System.Text.Encoding.Unicode.GetBytes(msg);
                sarr = System.Text.Encoding.Convert(ASCIIEncoding.ASCII, UnicodeEncoding.Unicode, sarr);
                int len = sarr.Length;
                COPYDATASTRUCT cds;
                cds.dwData = (IntPtr)0;
                cds.lpData = System.Text.Encoding.Unicode.GetString(sarr);
                cds.cbData = len + 1;
                result = SendMessage(hWnd, WM_COPYDATA, wParam, ref cds);
            }

            return result;
        }

        private static int getWindowId(string className, string windowName)
        {
            return FindWindow(className, windowName);
        }

        public static int toBangla()
        {
            return sendWindowsStringMessage(getWindowId("TAvroMainForm1", null), 0, "bn");
        }

        public static int toEnglish()
        {
            return sendWindowsStringMessage(getWindowId("TAvroMainForm1", null), 0, "sys");
        }

    }
}
