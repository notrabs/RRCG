using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;

class Utils
{
    public static Task awaitNextTick()
    {
        var promise = new TaskCompletionSource<bool>();
        EditorApplication.delayCall += delegate ()
        {
            promise.SetResult(true);
        };
        return promise.Task;
    }
}
