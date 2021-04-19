using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTester : MonoBehaviour
{
    public Vector3 targetPosition;
    public float speed;

    public EaseTypes easeType;
    public TweenTypes tweenTypes;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (tweenTypes)
            {
               case TweenTypes.PositionTween:
                   handlePositionTween();
                   break;
               case TweenTypes.RotateTween:
                   handleRotateTween();
                   break;
               case TweenTypes.ScaleTween:
                   handleScaleTween();
                   break;
            }
        }
    }

    private void handleRotateTween()
    {
        TweenMachine.RotateGameObject(gameObject);
    }

    private void handleScaleTween()
    {
        TweenMachine.ScaleGameObject(gameObject);
    }

    private void handlePositionTween()
    {
        switch (easeType)
        {
            case EaseTypes.Linear: 
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.Linear);
                break;
            case EaseTypes.EaseInQuad: 
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInQuad);
                break;
            case EaseTypes.EaseInCubic:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInCubic);
                break;
            case EaseTypes.EaseInQuart:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInQuart);
                break;
            case EaseTypes.EaseInQuint:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInQuint);
                break;
            case EaseTypes.EaseInBack:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInBack);
                break;
            case EaseTypes.EaseInCirc:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInCirc);
                break;
            case EaseTypes.EaseInSine:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInSine);
                break;
            case EaseTypes.EaseOutQuad:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutQuad);
                break;
            case EaseTypes.EaseOutCubic:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutCubic);
                break;
            case EaseTypes.EaseOutQuart:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutQuart);
                break;
            case EaseTypes.EaseOutQuint:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutQuint);
                break;
            case EaseTypes.EaseOutBack:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutBack);
                break;
            case EaseTypes.EaseOutCirc:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutCirc);
                break;
            case EaseTypes.EaseOutSine:
                TweenMachine.MoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutSine);
                break;
        }
    }
}
