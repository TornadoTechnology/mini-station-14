using Content.Server.Maps;
using Robust.Shared.Prototypes;

namespace Content.Server._Taipan.Components;

[RegisterComponent]
public sealed partial class StationTaipanLoaderComponent : Component
{
    [DataField]
    public ProtoId<GameMapPrototype> Station = "Saltern";
}
