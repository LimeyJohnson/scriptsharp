// ReadyState.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Net
{



    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptConstants(UseNames=true)]
    public enum XMLHttpRequestResponseType
    {

        //http://www.w3.org/TR/XMLHttpRequest/#xmlhttprequestresponsetype
        [ScriptName("arraybuffer")]
        ArrayBuffer,
        [ScriptName("blob")]
        Blob,
        [ScriptName("document")]
        Document,
        [ScriptName("json")]
        Json,
        [ScriptName("text")]
        Text

    }
}
