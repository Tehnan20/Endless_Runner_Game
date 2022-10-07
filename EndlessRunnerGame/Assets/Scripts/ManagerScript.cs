using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    protected GameManagerScript Manager;
    protected ViewManagerScript View;

    public void LoadManagers()
    {
        Manager = GameManagerScript.Instance;
        View = Manager.ViewManager;
    }
}
