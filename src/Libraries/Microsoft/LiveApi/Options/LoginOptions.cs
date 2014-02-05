using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace Live
{
    [ScriptImport, ScriptIgnoreNamespace, ScriptName("Object")]
    public class LoginOptions
    {
        public LoginOptions(params object[] nameValuePairs) { }
        public string[] Scope;
        public string Redirect_uri;
    }
}
