using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    protected GameManagerScript Manager;
    protected ViewManagerScript View;
    protected ECSManagerScript ECSManager;

    public void LoadManagers()
    {
        Manager = GameManagerScript.Instance;
        View = Manager.ViewManager;
        ECSManager = Manager.ECSManager;
    }
}
