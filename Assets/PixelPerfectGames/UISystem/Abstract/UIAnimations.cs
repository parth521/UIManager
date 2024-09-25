using System;
using UnityEngine;
using DG.Tweening;
using PixelPerfectGames.UISystem;
public abstract class UIAnimations : MonoBehaviour
{
    [SerializeField]protected float duration;
    [SerializeField]protected float delay;
    [SerializeField]protected Ease ease;
    [SerializeField] protected RectTransform rectTransform;
    public AnimationName animationName;
    public virtual void Awake()
    {
        UIAnimator uIAnimator=transform.root.GetComponent<UIAnimator>();
        if(uIAnimator!=null)
        {
            uIAnimator.RegisterAnimation(this);
        }
        rectTransform = GetComponent<RectTransform>();
    }
    public abstract void Show(Action callback=null);
    public abstract void Hide(Action callback=null);
}
