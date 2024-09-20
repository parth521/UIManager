using System;
using PixelPerfectGames.UISystem;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class GamePopup : UIElement
{
    public override void Show(Action callback = null)
    {
        base.Show(callback);
    }
    public override void Hide(Action callback = null)
    {
        base.Hide(callback);
    }
    public void Back()
    {
        UIManager.Instance.HideScreen(UIScreen.GamePopup);
    }
}
