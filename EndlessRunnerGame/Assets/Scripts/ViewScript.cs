using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewScript : ManagerScript
{
    public void Initialize()
    {
        this.LoadManagers();
        this.OnInitialize();
    }

    public virtual void OnInitialize()
    {
    }

    public virtual void OnStart()
    {
        // Debug.Log("ViewInheritanceScript OnStart Function Called");
    }

    public virtual void OnUpdate()
    {
        // Debug.Log("ViewInheritanceScript OnUpdate Function Called");
    }
}
