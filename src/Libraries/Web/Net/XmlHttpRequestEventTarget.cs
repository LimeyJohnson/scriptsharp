// XMLHttpRequestEventTarget.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Net {

    [ScriptIgnoreNamespace]
    [ScriptImport]
    public abstract class XmlHttpRequestEventTarget
    {
        [ScriptField, ScriptName("onloadstart")]
        public Action<XmlHttpRequestProgressEvent> OnLoadStart { get { return null; } set { } }
        [ScriptField, ScriptName("onprogress")]
        public Action<XmlHttpRequestProgressEvent> OnProgress { get { return null; } set { } }
        [ScriptField, ScriptName("onabort")]
        public Action<XmlHttpRequestProgressEvent> OnAbort { get { return null; } set { } }
        [ScriptField, ScriptName("onerror")]
        public Action<XmlHttpRequestProgressEvent> OnError { get { return null; } set { } }
        [ScriptField, ScriptName("onload")]
        public Action<XmlHttpRequestProgressEvent> OnLoad { get { return null; } set { } }
        [ScriptField, ScriptName("ontimeout")]
        public Action<XmlHttpRequestProgressEvent> OnTimeout { get { return null; } set { } }
        [ScriptField, ScriptName("onloadend")]
        public Action<XmlHttpRequestProgressEvent> OnLoadend { get { return null; } set { } }
    }
}
