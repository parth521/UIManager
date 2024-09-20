using System;
using UnityEngine;
using DG.Tweening;
public abstract class UIAnimations : MonoBehaviour
{
    [SerializeField]protected float duration;
    [SerializeField]protected float delay;
    [SerializeField]protected Ease ease;
    public abstract void Show(Action callback=null);
    public abstract void Hide(Action callback=null);
}
