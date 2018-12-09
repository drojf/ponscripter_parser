﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonscripterParser
{
    public enum TokenType
    {
        ClickWait,
        PageWait,
        IgnoreNewLine,
        Text,
        FnCall,
        Colon,
        Literal,
        Operator,
        Comma,
        Alias, //numAlias, stringalias etc
    }
}
