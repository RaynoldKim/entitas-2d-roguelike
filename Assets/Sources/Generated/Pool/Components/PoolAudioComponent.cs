//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PoolEntity {

    public AudioComponent audio { get { return (AudioComponent)GetComponent(PoolComponentsLookup.Audio); } }
    public bool hasAudio { get { return HasComponent(PoolComponentsLookup.Audio); } }

    public void AddAudio(Audio[] newClips, bool newRandomizePitch) {
        var index = PoolComponentsLookup.Audio;
        var component = CreateComponent<AudioComponent>(index);
        component.clips = newClips;
        component.randomizePitch = newRandomizePitch;
        AddComponent(index, component);
    }

    public void ReplaceAudio(Audio[] newClips, bool newRandomizePitch) {
        var index = PoolComponentsLookup.Audio;
        var component = CreateComponent<AudioComponent>(index);
        component.clips = newClips;
        component.randomizePitch = newRandomizePitch;
        ReplaceComponent(index, component);
    }

    public void RemoveAudio() {
        RemoveComponent(PoolComponentsLookup.Audio);
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
public sealed partial class PoolMatcher {

    static Entitas.IMatcher<PoolEntity> _matcherAudio;

    public static Entitas.IMatcher<PoolEntity> Audio {
        get {
            if (_matcherAudio == null) {
                var matcher = (Entitas.Matcher<PoolEntity>)Entitas.Matcher<PoolEntity>.AllOf(PoolComponentsLookup.Audio);
                matcher.componentNames = PoolComponentsLookup.componentNames;
                _matcherAudio = matcher;
            }

            return _matcherAudio;
        }
    }
}
