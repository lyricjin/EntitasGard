//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public NavigationCommandComponent navigationCommand { get { return (NavigationCommandComponent)GetComponent(GameComponentsLookup.NavigationCommand); } }
    public bool hasNavigationCommand { get { return HasComponent(GameComponentsLookup.NavigationCommand); } }

    public void AddNavigationCommand(int newTargetCellID) {
        var index = GameComponentsLookup.NavigationCommand;
        var component = CreateComponent<NavigationCommandComponent>(index);
        component.targetCellID = newTargetCellID;
        AddComponent(index, component);
    }

    public void ReplaceNavigationCommand(int newTargetCellID) {
        var index = GameComponentsLookup.NavigationCommand;
        var component = CreateComponent<NavigationCommandComponent>(index);
        component.targetCellID = newTargetCellID;
        ReplaceComponent(index, component);
    }

    public void RemoveNavigationCommand() {
        RemoveComponent(GameComponentsLookup.NavigationCommand);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherNavigationCommand;

    public static Entitas.IMatcher<GameEntity> NavigationCommand {
        get {
            if (_matcherNavigationCommand == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.NavigationCommand);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherNavigationCommand = matcher;
            }

            return _matcherNavigationCommand;
        }
    }
}