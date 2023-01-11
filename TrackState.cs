// base state class
public class TrackState
{
    public string name;
    protected StateMachine stateMachine;
    
    public virtual void Exit(){}
    public virtual void Update(){}
}
