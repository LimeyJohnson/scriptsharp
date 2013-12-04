// ReadyState.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Net {

    
    
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptConstants]
    public enum ReadyState {

        //Ready States can be found here: http://www.w3.org/TR/XMLHttpRequest/#states
        Uninitialized = 0,

        Open = 1,

        HeadersReceived = 2,

        Receiving = 3,

        Done = 4
    }
}
