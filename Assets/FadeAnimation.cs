using System;
using DG.Tweening;
using UnityEngine;
using PixelPerfectGames.UISystem;
public class FadeAnimation : UIAnimations
{
    private CanvasGroup canvasGroup;
    public override void Awake() {
        canvasGroup = GetComponent<CanvasGroup>();
    }
   

    public override void Show(Action callback = null)
    {
        canvasGroup.alpha = 0;
        canvasGroup.DOFade(1, duration).SetDelay(delay).SetEase(ease).OnComplete(() =>
        {
            callback?.Invoke();
        });
    }
     public override void Hide(Action callback = null)
    {
        canvasGroup.alpha = 1;
        canvasGroup.DOFade(0, duration).SetDelay(delay).SetEase(ease).OnComplete(() =>
        {
            Debug.LogError("Do fade complete on hide");
            callback?.Invoke();
        });
    }
}
