using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Live
{
    [ScriptImport, ScriptIgnoreNamespace, ScriptName("Object")]
    public class ApiResponse:Response
    {
        [ScriptField, ScriptName("first_name")]
        public string FirstName { get { return null; } set { } }
    }
}
