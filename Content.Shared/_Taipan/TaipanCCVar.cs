using Robust.Shared.Configuration;

namespace Content.Shared._Taipan;

[CVarDefs] // Важный атрибут!
public sealed class TaipanCCVar
{
    public static readonly CVarDef<bool> TaipanEnabled =
        CVarDef.Create("taipan.enabled", true, CVar.SERVERONLY);
}
