using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BotRunner.Harness.Bot
{
    public interface ICompiler
    {
        bool HasPackageManager();
        bool RunPackageManager();
        bool RunCompiler();
    }
}
