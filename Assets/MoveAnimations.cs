using System;
using DG.Tweening;
using PixelPerfectGames.UISystem;
using UnityEngine;
public class MoveAnimations : UIAnimations
{
    
    public override void Hide(Action callback = null)
    {
        rectTransform.localScale = Vector3.one;
        rectTransform.DOScale(Vector3.zero,duration).SetDelay(delay).SetEase(ease).OnComplete(() =>
        {
            callback?.Invoke();
        });
    }

    public override void Show(Action callback = null)
    {
        rectTransform.localScale = Vector3.zero;
        rectTransform.DOScale(Vector3.one,duration).SetDelay(delay).SetEase(ease).OnComplete(() =>
        {
            callback?.Invoke();
            
        });
    }
}
