using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace Live
{
    [ScriptImport, ScriptIgnoreNamespace, ScriptName("Object")]
    public class UiOptions
    {
        public UiOptions(params object[] nameValuePairs) { }
        [ScriptField]
        public string Name
        {
            get
            {
                return null;
            }
            set
            {
            }
        }
        [ScriptField]
        public string Element
        {
            get
            {
                return null;
            }
            set
            {
            }
        }
        [ScriptField]
        public string Brand
        {
            get
            {
                return null;
            }
            set
            {
            }
        }
        [ScriptField]
        public string Mode
        {
            get
            {
                return null;
            }
            set
            {
            }
        }
        [ScriptField]
        public string Select
        {
            get
            {
                return null;
            }
            set
            {
            }
        }
        public Action<LoginResponse> Onloggedin;
        public Action<LoginResponse> Onselected;
        public Action<LoginResponse> Onerror;
    }
    
}
