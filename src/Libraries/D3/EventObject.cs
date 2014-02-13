using System;
using System.Html;
using System.Runtime.CompilerServices;
using System.Collections;

namespace D3Api
{
    [ScriptImport, ScriptIgnoreNamespace]
    public class EventObject
    {
        public void StopPropagation(){}
        public string Translate;
        public string Scale;
    }
}
