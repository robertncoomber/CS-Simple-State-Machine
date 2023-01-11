public class IsPlayingState : TrackState
{
    public IsPlayingState(ArenaTrackStateMachine state)
    {
        stateMachine = state;
        UnityEngine.Debug.Log("entered is playing state");
        name = "IsPlayingState";
    }
    public override void Exit()
    {
        if(stateMachine.currentState.name == "IsPlayingState"){
            stateMachine.currentState = new NotPlayingState(stateMachine);
        }
    }

    public override void Update()
    {
        UnityEngine.Debug.Log("currently in is Playing state");
    }
}
