using System;
using System;
using System.Html;
using System.Runtime.CompilerServices;
using System.Collections;
namespace D3Api
{
    public class BehaviorObject
    {
        public BehaviorObject Zoom(){return null;}
        public BehaviorObject X(ScaleObject o){return null;}
        public BehaviorObject Y(ScaleObject o) { return null; }
        public BehaviorObject Center() { return null; }

        public BehaviorObject On(string eventType, Action<Dictionary> callback) { return null; }
        public BehaviorObject ScaleExtent(int[] scale) { return null; }

    }
}
