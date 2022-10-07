using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MenuViewScript : ViewScript
{

    public void StartGame()
    {
        View.Open("GameHUDView");
        View.Close("MenuView");
        // View.Views["MenuView"].GetComponent<RectTransform>().DOMove(new Vector3(0, 1000, 0), 2);
        Manager.GameStarted = true;
    }

    public override void OnInitialize()
    {
        base.OnInitialize();
    }

    public override void OnStart()
    {
        base.OnStart();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
    }
}
