using UnityEngine;
using PixelPerfectGames.UISystem;
using System;
public class SplashScreen : UIElement
{
    public override void Show(Action callback = null)
    {
        base.Show(callback);
    }
    public override void Hide(Action callback = null)
    {
        base.Hide(callback);
    }
    public override void onShowComplete()
    {
        Debug.LogError("ChangeScreen1");
        base.onShowComplete();
        Invoke("ChangeScreen", 4f);
       
    }
    private void ChangeScreen()
    {
        Debug.LogError("ChangeScreen");
        UIManager.Instance.ChangeScreen(UIScreen.Mainmenu);
    }

}
