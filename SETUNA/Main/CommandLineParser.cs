using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization; // For int.Parse

namespace SETUNA.Main
{
    // Enum to represent different command types
    public enum CommandType
    {
        OpenFile,
        CutRectangle,
        ShowOptions,
        StartCapture,
        ShowSubMenu, // Though not currently handled, include for completeness
        Unknown
    }

    // Base class for parsed commands
    public abstract class ParsedCommand
    {
        public CommandType Type { get; protected set; }
    }

    // Command to open a file
    public class OpenFileCommand : ParsedCommand
    {
        public string FilePath { get; }
        public OpenFileCommand(string filePath)
        {
            Type = CommandType.OpenFile;
            FilePath = filePath;
        }
    }

    // Command to cut a rectangle from the screen
    public class CutRectangleCommand : ParsedCommand
    {
        public Rectangle Region { get; }
        public string OutputPath { get; } // Optional path from /P:
        public CutRectangleCommand(Rectangle region, string outputPath = null)
        {
            Type = CommandType.CutRectangle;
            Region = region;
            OutputPath = outputPath;
        }
    }

    // Command to show the options window
    public class ShowOptionsCommand : ParsedCommand
    {
        public ShowOptionsCommand()
        {
            Type = CommandType.ShowOptions;
        }
    }

    // Command to start screen capture
    public class StartCaptureCommand : ParsedCommand
    {
        public StartCaptureCommand()
        {
            Type = CommandType.StartCapture;
        }
    }

    // Command to show the sub menu (currently not implemented in Mainform)
    public class ShowSubMenuCommand : ParsedCommand
    {
        public ShowSubMenuCommand()
        {
            Type = CommandType.ShowSubMenu;
        }
    }

    // Class to represent an unknown or invalid command
    public class UnknownCommand : ParsedCommand
    {
        public string OriginalArgument { get; }
        public UnknownCommand(string originalArgument)
        {
            Type = CommandType.Unknown;
            OriginalArgument = originalArgument;
        }
    }

    public class CommandLineParser
    {
        private const string RectPrefix = "/R:";
        private const string PathPrefix = "/P:";
        private const string CommandPrefix = "/C:";

        private const string OptionCommandName = "OPTION";
        private const string CaptureCommandName = "CAPTURE";
        private const string SubMenuCommandName = "SUBMENU";

        public List<ParsedCommand> Parse(string[] args)
        {
            var commands = new List<ParsedCommand>();
            if (args == null || args.Length == 0)
            {
                return commands;
            }

            Rectangle parsedRect = Rectangle.Empty;
            string parsedPath = null;
            CommandType commandTypeFromC = CommandType.Unknown; // Command specified by /C:
            List<string> filesToOpen = new List<string>();
            List<UnknownCommand> unknownCommands = new List<UnknownCommand>();


            foreach (string arg in args)
            {
                try
                {
                    string currentArg = arg;
                    string prefix = "";
                    string value = currentArg;

                    if (currentArg.Length > 2 && currentArg.StartsWith("/") && currentArg.Substring(2, 1) == ":")
                    {
                        prefix = currentArg.Substring(0, 3).ToUpperInvariant();
                        value = currentArg.Substring(3);
                    }


                    if (!string.IsNullOrEmpty(prefix))
                    {
                        switch (prefix)
                        {
                            case RectPrefix:
                                string[] parts = value.Split(',');
                                if (parts.Length == 4)
                                {
                                    parsedRect = new Rectangle(
                                        int.Parse(parts[0], CultureInfo.InvariantCulture),
                                        int.Parse(parts[1], CultureInfo.InvariantCulture),
                                        int.Parse(parts[2], CultureInfo.InvariantCulture),
                                        int.Parse(parts[3], CultureInfo.InvariantCulture)
                                    );
                                }
                                else
                                {
                                    unknownCommands.Add(new UnknownCommand(arg + " (Invalid Rect format)"));
                                }
                                break;
                            case PathPrefix:
                                parsedPath = value;
                                break;
                            case CommandPrefix:
                                string cmdName = value.ToUpperInvariant();
                                if (cmdName == OptionCommandName)
                                {
                                    commandTypeFromC = CommandType.ShowOptions;
                                }
                                else if (cmdName == CaptureCommandName)
                                {
                                    commandTypeFromC = CommandType.StartCapture;
                                }
                                else if (cmdName == SubMenuCommandName)
                                {
                                     commandTypeFromC = CommandType.ShowSubMenu;
                                }
                                else
                                {
                                    unknownCommands.Add(new UnknownCommand(arg + " (Unknown /C: command)"));
                                }
                                break;
                            default:
                                unknownCommands.Add(new UnknownCommand(arg + " (Unknown prefix)"));
                                break;
                        }
                    }
                    else // No prefix, treat as file path
                    {
                        filesToOpen.Add(value);
                    }
                }
                catch (Exception ex) // Catch parsing errors (e.g., int.Parse)
                {
                    unknownCommands.Add(new UnknownCommand(arg + " (Exception: " + ex.Message + ")"));
                }
            }

            // Consolidate parsed arguments based on original logic's precedence
            // 1. If a valid /R: was parsed, it takes top priority.
            if (parsedRect.Width >= 10 && parsedRect.Height >= 10)
            {
                commands.Add(new CutRectangleCommand(parsedRect, parsedPath));
                // In original code, if rect is valid, it executes and returns.
                // So, we add this command and likely ignore others or handle them based on desired behavior.
                // For now, if /R: is valid, it's the primary command.
                // We will add any file open commands as well, as the original seems to allow opening files
                // and then immediately performing a cut.
                 foreach (var file in filesToOpen)
                {
                    commands.Add(new OpenFileCommand(file));
                }
                commands.AddRange(unknownCommands); // Add any unknown commands encountered
                return commands; // Mimic original behavior of /R: taking precedence and "returning"
            }

            // 2. If /R: was not valid or not present, then process /C: commands.
            if (commandTypeFromC != CommandType.Unknown)
            {
                switch (commandTypeFromC)
                {
                    case CommandType.ShowOptions:
                        commands.Add(new ShowOptionsCommand());
                        break;
                    case CommandType.StartCapture:
                        commands.Add(new StartCaptureCommand());
                        break;
                    case CommandType.ShowSubMenu:
                        commands.Add(new ShowSubMenuCommand());
                        break;
                }
            }

            // 3. Add any OpenFile commands if no higher precedence command caused an "early exit".
            // If /R was valid, files were already added. If not, and /C was (or wasn't) present, add files now.
            // This ensures files are added unless /R already handled them.
            if (!(parsedRect.Width >= 10 && parsedRect.Height >= 10))
            {
                 foreach (var file in filesToOpen)
                {
                    commands.Add(new OpenFileCommand(file));
                }
            }

            // Add any unknown commands encountered if not already added with a dominant /R: command
            commands.AddRange(unknownCommands);

            return commands;
        }
    }
}
