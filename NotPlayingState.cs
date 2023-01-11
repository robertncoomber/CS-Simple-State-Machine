public class NotPlayingState : TrackState
{
    public NotPlayingState(StateMachine state)
    {
        stateMachine = state;
        UnityEngine.Debug.Log("entered not playing state");
        name = "NotPlayingState";
    }
    public override void Exit()
    {
        if(stateMachine.currentState.name == "NotPlayingState"){
            stateMachine.currentState = new IsPlayingState(stateMachine);
        }
    }

    public override void Update()
    {
        UnityEngine.Debug.Log("currently in not playing state");
    }
}
