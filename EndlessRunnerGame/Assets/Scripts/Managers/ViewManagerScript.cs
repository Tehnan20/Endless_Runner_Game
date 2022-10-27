using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManagerScript : MonoBehaviour
{
    public RectTransform Canvas;
    public Dictionary<string, ViewScript> Views;

    public void Initialize()
    {
        Views = new Dictionary<string, ViewScript>();

        for(int i = 0; i < Canvas.childCount; i++)
        {
            ViewScript View = Canvas.GetChild(i).GetComponent<ViewScript>();
            Views.Add(View.name, View);
        }

        foreach(KeyValuePair<string, ViewScript> View in Views)
        {
            View.Value.Initialize();
        }
    }

    public void Setup()
    {
        foreach(KeyValuePair<string, ViewScript> View in Views)
        {
            View.Value.OnStart();
        }
    }

    public void Process()
    {
        foreach(KeyValuePair<string, ViewScript> View in Views)
        {
            View.Value.OnUpdate();
        }
    }

    public void Open(string ViewName)
    {
        if(Views.ContainsKey(ViewName) == true)
        {
            Views[ViewName].gameObject.SetActive(true);
        }
        else
        {
            Debug.LogWarning(ViewName + "does not exist");
        }
    }

    public void Close(string ViewName)
    {
        if(Views.ContainsKey(ViewName) == true)
        {
            Views[ViewName].gameObject.SetActive(false);
        }
        else
        {
            Debug.LogWarning(ViewName + "does not exist");
        }
    }

    public ViewScript Get(string ViewName)
    {
        if(Views.ContainsKey(ViewName) == true)
        {
            return Views[ViewName];
        }
        else
        {
            Debug.LogWarning(ViewName + "does not exist");
        }

        return null;
    }
}
