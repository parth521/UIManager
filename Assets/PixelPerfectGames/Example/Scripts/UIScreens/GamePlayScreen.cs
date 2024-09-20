using PixelPerfectGames.UISystem;
using UnityEngine;
using System;
public class GamePlayScreen : UIElement
{
    public override void Show(Action callback = null)
    {
        base.Show(callback);
    }
    public override void Hide(Action callback=null)
    {
        base.Hide(callback);
    }
    public void Back()
    {
        UIManager.Instance.ChangeScreen(UIScreen.Mainmenu);
    }
    public void OpenGamePopup()
    {
        UIManager.Instance.ShowScreen(UIScreen.GamePopup);
    }
  
}
