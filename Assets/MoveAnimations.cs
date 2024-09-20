using System;
using DG.Tweening;
using PixelPerfectGames.UISystem;
using UnityEngine;
public class MoveAnimations : UIAnimations
{
    private RectTransform rectTransform;
    private void Awake()
    {
        UIAnimator uIAnimator=transform.root.GetComponent<UIAnimator>();
        rectTransform = GetComponent<RectTransform>();
        if(uIAnimator!=null)
        {
            uIAnimator.RegisterAnimation(this);
        }
    }
    public override void Hide(Action callback = null)
    {
        rectTransform.localScale = Vector3.one;
        transform.DOScale(Vector3.zero,duration).SetDelay(delay).SetEase(ease).OnComplete(() =>
        {
            callback?.Invoke();
        });
    }

    public override void Show(Action callback = null)
    {
        rectTransform.localScale = Vector3.zero;
        transform.DOScale(Vector3.one,duration).SetDelay(delay).SetEase(ease).OnComplete(() =>
        {
            callback?.Invoke();
        });
    }
}
