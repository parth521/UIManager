using PixelPerfectGames.UISystem;
using System;
public class MenuScreen : UIElement
{
    public override void Show(Action callback = null)
    {
        base.Show(callback);
    }
    override public void Hide(Action callback = null)
    {
        base.Hide(callback);
    }
    public void OnPlay()
    {
        UIManager.Instance.ChangeScreen(UIScreen.GamePlay);
    }
}
