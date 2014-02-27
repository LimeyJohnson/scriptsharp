// Class1.cs
//

using System;
using System.Html;
using System.Runtime.CompilerServices;
using System.Collections;

namespace FreindsLibrary
{
    [ScriptImport, ScriptIgnoreNamespace, ScriptName("Object")]
    public class Error
    {
        public int Code;
        public string Message, Type;
    }
}
