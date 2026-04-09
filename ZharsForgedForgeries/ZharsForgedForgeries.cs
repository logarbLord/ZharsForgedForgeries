using System.Reflection;
using JetBrains.Annotations;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;

namespace ZharsForgedForgeries;

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 5), UsedImplicitly]
public class ZharsForgedForgeries(WTTServerCommonLib.WTTServerCommonLib wttServerCommonLib) : IOnLoad
{
    public async Task OnLoad() //async means waiting for process
    {
        var assembly = Assembly.GetExecutingAssembly(); //This references the dll
        await wttServerCommonLib.CustomItemServiceExtended.CreateCustomItems(assembly); //this creates the item
        
    }
}
