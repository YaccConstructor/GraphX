using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;

[assembly: AssemblyTitleAttribute("GraphX.WPF.Controls")]
[assembly: AssemblyProductAttribute("QuickGraph")]
[assembly: AssemblyDescriptionAttribute("Graph datastructures and algorithms for .NET.")]
[assembly: AssemblyVersionAttribute("0.0.1")]
[assembly: AssemblyFileVersionAttribute("0.0.1")]
namespace System {
    internal static class AssemblyVersionInformation {
        internal const string Version = "0.0.1";
    }
}

[assembly: XmlnsPrefix("http://schemas.panthernet.ru/graphx/", "graphx")]
[assembly: XmlnsDefinition("http://schemas.panthernet.ru/graphx/",
    "GraphX.Controls")]
[assembly: XmlnsDefinition("http://schemas.panthernet.ru/graphx/",
    "GraphX.Controls.Animations")]
[assembly: XmlnsDefinition("http://schemas.panthernet.ru/graphx/",
    "GraphX.Controls.Models")]

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None,
    ResourceDictionaryLocation.SourceAssembly
)] 
