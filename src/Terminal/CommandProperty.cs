//  Author:
//       Teeknofil <teeknofil@gmail.com>
//
//  Copyright (c) 2015 Teeknofil
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.



using System;
using System.Text.RegularExpressions;
using crisis.CommandLine;

namespace crisis
{
    [CommandLineManager(ApplicationName = "\n\n Crisis Wordlist Generator by Teeknofil,", Version = ": 1.1.1\n\n", Copyright = "SYNOPSIS\n\n crisis [method] -l [len] -f [charset string] [options] \n\nDESCRIPTION \n\n  Crisis can create a wordlist based on criteria you specify. The output  from crisis can be sent to the screen, file, or  to  another  program.  The required parameters are: ", EnabledOptionStyles = OptionStyles.Group | OptionStyles.LongUnix)]

    [CommandLineOptionGroup("method", Name = "Method", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("parameter", Name = "Parameter", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("help", Name = "Help", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("options", Name = "Options", Require = OptionGroupRequirement.None)]

    public partial class Command
    {       


    }
}
