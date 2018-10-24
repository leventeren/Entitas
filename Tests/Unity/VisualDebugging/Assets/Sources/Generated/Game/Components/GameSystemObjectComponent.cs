//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SystemObjectComponent systemObject { get { return (SystemObjectComponent)GetComponent(GameComponentsLookup.SystemObject); } }
    public bool hasSystemObject { get { return HasComponent(GameComponentsLookup.SystemObject); } }

    public void AddSystemObject(object newSystemObject) {
        var index = GameComponentsLookup.SystemObject;
        var component = (SystemObjectComponent)CreateComponent(index, typeof(SystemObjectComponent));
        component.systemObject = newSystemObject;
        AddComponent(index, component);
    }

    public void ReplaceSystemObject(object newSystemObject) {
        var index = GameComponentsLookup.SystemObject;
        var component = (SystemObjectComponent)CreateComponent(index, typeof(SystemObjectComponent));
        component.systemObject = newSystemObject;
        ReplaceComponent(index, component);
    }

    public void RemoveSystemObject() {
        RemoveComponent(GameComponentsLookup.SystemObject);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSystemObject;

    public static Entitas.IMatcher<GameEntity> SystemObject {
        get {
            if (_matcherSystemObject == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SystemObject);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSystemObject = matcher;
            }

            return _matcherSystemObject;
        }
    }
}
