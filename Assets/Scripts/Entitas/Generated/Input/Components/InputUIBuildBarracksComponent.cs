//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly UIBuildBarracks uIBuildBarracksComponent = new UIBuildBarracks();

    public bool isUIBuildBarracks {
        get { return HasComponent(InputComponentsLookup.UIBuildBarracks); }
        set {
            if (value != isUIBuildBarracks) {
                var index = InputComponentsLookup.UIBuildBarracks;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : uIBuildBarracksComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherUIBuildBarracks;

    public static Entitas.IMatcher<InputEntity> UIBuildBarracks {
        get {
            if (_matcherUIBuildBarracks == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.UIBuildBarracks);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherUIBuildBarracks = matcher;
            }

            return _matcherUIBuildBarracks;
        }
    }
}
