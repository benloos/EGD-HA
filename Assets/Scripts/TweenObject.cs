using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenObject : MonoBehaviour
{

    public float tweenTime;
    public float tweenToSize;
    public LeanTweenType easeType;

    public void doScaleTween()
    {
        LeanTween.scale(gameObject, Vector3.one * tweenToSize, tweenTime).setEase(easeType);
    }
}
