using UnityEngine;

public class ScaleTween : Tween{
    public ScaleTween(GameObject objectToTween) : base(objectToTween)
    {
    }

    protected override void StartTween()
    {
        Debug.Log("Start tween");
        this.active = true;
        
    }

    protected override void PerformTween()
    {
        Debug.Log("Update tween");
        _gameObject.transform.localScale = new Vector3(3, 3, 3);
        this.LogicIsOver = true;
    }

    protected override void TweenEnd()
    {
        Debug.Log("Stop tween");
        this.active = false;
    }
}
