using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemScript : ManagerScript
{
    public void Initialize()
    {
        this.LoadManagers();
        this.OnInitialize();
    }

    public virtual void OnInitialize()
    {
        
    }
    
    public virtual void OnUpdate()
    {   

    }
}
