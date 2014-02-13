// D3.cs
//

using System;
using System.Html;
using System.Runtime.CompilerServices;
using System.Collections;
namespace D3Api
{
    public delegate int IntDelegate(Dictionary D);
    public delegate string StringDelegate(Dictionary D);
    [ScriptImport, ScriptIgnoreNamespace]
    [ScriptName("d3")]
    public static class D3
    {
       
        public static LayoutObject Layout;
        public static SelectObject Select(string selector) { return null; }
        public static ScaleObject Scale;
        public static EventObject Event;
        public static BehaviorObject Behavior;
        
    }
    [ScriptImport, ScriptIgnoreNamespace, ScriptName("Object")]
    public class Node
    {
        public string Name;
        public int Group;
        public string ID;
    }
    [ScriptImport, ScriptIgnoreNamespace, ScriptName("Object")]
    public class Link
    {
        public int Source;
        public int Target;
        public int Value;
    }
    [ScriptImport, ScriptIgnoreNamespace]
    public class SelectObject
    {
        public SelectObject Append(string append) { return null; }
        public SelectObject Attr(string attribute, object value) { return null; }
        public SelectObject Attr(string attribute, IntDelegate action) { return null; }
        public SelectObject Attr(string attribute, StringDelegate action) { return null; }
        public SelectObject SelectAll(string selector) { return null; }
        public SelectObject Enter() { return null; }
        public SelectObject Style(string style, IntDelegate callback) { return null; }
        public SelectObject Data(Link[] links) { return null; }
        public SelectObject Data(Node[] nodes) { return null; }
        public SelectObject Call(Action action) { return null; }
        public SelectObject Call(BehaviorObject obj) { return null; }
        public SelectObject Text(StringDelegate callback) { return null; }

        public SelectObject On(string eventName, Action<Dictionary> callback) { return null; }
    }
    [ScriptImport, ScriptIgnoreNamespace]
    public class ForceObject
    {
        public ForceObject Charge(int charge) { return null; }
        public ForceObject LinkDistance(int distance) { return null; }
        public ForceObject Size(int[] size) { return null; }
        public ForceObject Nodes(Node[] nodes) { return null; }
        public ForceObject Links(Link[] links) { return null; }
        public ForceObject Start() { return null; }
        public Action Drag;
        public ForceObject On(string on, Action action) { return null; }
    }
    public class LayoutObject
    {
        public ForceObject Force() { return null; } 

    }
    public class ScaleObject
    {
        public int[] Catagory20() { return null; }
        public ScaleObject Linear() { return null; }
        public ScaleObject Domain(int[] domain) { return null; }
        public ScaleObject Range(int[] range) { return null; }
       

    }

}


