using System;
using System.Runtime.CompilerServices;
namespace Live
{

    #region Classes
    [ScriptImport, ScriptIgnoreNamespace, ScriptName("WL")]
    public static class LiveApi
    {
        public extern static PromiseGeneric<LoginResponse> Login(params object[] nameValuePairs);
        public extern static PromiseGeneric<LoginResponse> Login(LoginOptions options);
        public extern static PromiseGeneric<Response> Api(ApiOptions options);
        [ScriptName("api")]
        public extern static PromiseGeneric<FileListResponse> FileListApi(ApiOptions options);
        public extern static PromiseGeneric<LoginResponse> Init(InitOptions options);
        public extern static Promise Ui(UiOptions options);
        public extern static Promise FileDialog(FileDialogOptions options);
        [ScriptName(PreserveCase=true)]
        public static EventObject Event;
        public extern static PromiseGeneric<LoginResponse> GetLoginStatus();
    }
    [ScriptImport, ScriptIgnoreNamespace]
    public class EventObject
    {
        public extern void subscribe(string authType, Action<LoginResponse> callback);
    }
    #endregion
   
}
