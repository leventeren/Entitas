//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class VisualDebuggingMatcher {

    static IMatcher<VisualDebuggingEntity> _matcherAnimationCurve;

    public static IMatcher<VisualDebuggingEntity> AnimationCurve {
        get {
            if(_matcherAnimationCurve == null) {
                var matcher = (Matcher<VisualDebuggingEntity>)Matcher<VisualDebuggingEntity>.AllOf(VisualDebuggingComponentsLookup.AnimationCurve);
                matcher.componentNames = VisualDebuggingComponentsLookup.componentNames;
                _matcherAnimationCurve = matcher;
            }

            return _matcherAnimationCurve;
        }
    }
}