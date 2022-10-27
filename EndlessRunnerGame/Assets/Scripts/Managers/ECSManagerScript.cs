using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECSManagerScript : MonoBehaviour
{
    public Transform SystemParent;
    public Dictionary<string, SystemScript> SystemContainer;

    public void Initialize()
    {
        // for(int i = 0; i < SystemParent.childCount; i++)
        // {
        //     ViewScript View = SystemParent.GetChild(i).GetComponent<ViewScript>();
        //     Views.Add(View.name, View);
        // }

        // foreach(KeyValuePair<string, ViewScript> View in Views)
        // {
        //     View.Value.Initialize();
        // }
    }
}
