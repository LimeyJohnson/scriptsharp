// XmlHttpRequestProgressEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace System.Net
{

    [ScriptIgnoreNamespace]
    [ScriptImport]
    public class XmlHttpRequestProgressEvent
    {
        [ScriptField]
        public bool LengthComputable { get { return false; } }
        [ScriptField]
        public int Loaded { get { return 0; } }
        [ScriptField]
        public int Total { get { return 0; } }
    }
}
