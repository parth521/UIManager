
namespace PixelPerfectGames.UISystem
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    public class UIAnimator: MonoBehaviour
    {
        public List<UIAnimations> animations=new List<UIAnimations>();
        public List<UIAnimations> customAnimations=new List<UIAnimations>();
        private Action onAnimationShowComplete;
        public Action onAnimationHideComplete;
        private int showanimCount=0;
        private int hideanimCount=0;
        public void RegisterAnimation(UIAnimations animation)
        {
            if(animation.animationName==AnimationName.None)
            {
                animations.Add(animation);
            }
            else
            {
                customAnimations.Add(animation);
            }
        }
        private void OnDestroy() {
            animations.Clear();
        }
        public void ShowUIAnimation(Action onCompleteCallback = null)
        {
           
            showanimCount=animations.Count;
            onAnimationShowComplete=onCompleteCallback;
            foreach (UIAnimations animation in animations)
            {
                animation.Show(onShowComplete);
            }
        }
        public void HideUIAnimation(Action onCompleteCallback = null)
        {
            hideanimCount=animations.Count;
            onAnimationHideComplete=onCompleteCallback;
            foreach (UIAnimations animation in animations)
            {
                animation.Hide(onHideComplete);
            }
        }
        public void DoCustomAnimation(AnimationName animationName,Action onCompleteCallback = null)
        {
          customAnimations.Find(x=>x.animationName==animationName).Show(onCompleteCallback);
        }
        private void onShowComplete()
        { 
            showanimCount--;
            Debug.LogError("ChangeScreen1"+showanimCount);
            if(showanimCount==0)
            {
                Debug.LogError("==> ShowUIAnimation");
                onAnimationShowComplete?.Invoke();
            }
        }
        private void onHideComplete()
        {
            hideanimCount--;    
            if(hideanimCount==0)
            {
                onAnimationHideComplete?.Invoke();
            }
        }
    }
}