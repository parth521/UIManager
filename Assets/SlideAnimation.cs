using System;
using DG.Tweening;
using UnityEngine;
using PixelPerfectGames.UISystem;

public class SlideAnimation : UIAnimations
{
     private RectTransform rectTransform;
     private void Awake() {
            UIAnimator uIAnimator=transform.root.GetComponent<UIAnimator>();
            if(uIAnimator!=null)
            {
                uIAnimator.RegisterAnimation(this);
            }
            rectTransform = GetComponent<RectTransform>();
     }
    public override void Show(Action callback = null)
    { 
        rectTransform.anchoredPosition = new Vector2(-Screen.width, 0);
        rectTransform.DOAnchorPosX(0, duration).SetDelay(delay).SetEase(ease).OnComplete(() =>
        {
            callback?.Invoke();
        });

    }
    public override void Hide(Action callback = null)
    { 
        rectTransform.anchoredPosition = new Vector2(0, 0);
        rectTransform.DOAnchorPosX(-Screen.width, duration).SetDelay(delay).SetEase(ease).OnComplete(() =>
        {
            callback?.Invoke();
        });
    }

}
