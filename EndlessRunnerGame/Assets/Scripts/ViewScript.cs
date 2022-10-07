using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewScript : ManagerScript
{
    public virtual void OnInitialize()
    {
        this.LoadManagers();
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
