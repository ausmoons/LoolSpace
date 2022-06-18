using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActions : MonoBehaviour
{
    public GameObject objectToHide;
    public GameObject objectToShow;
    public GameObject objectToShowNext;

    public void Update()
    {
        if (objectToHide != null && objectToShow != null && Input.GetKeyDown(KeyCode.Space))
        {
            this.HideObject(objectToHide);
            this.ShowObject(objectToShow);
            this.ShowObject(objectToShowNext);
        }
    }

    public void ShowObject(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void HideObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void ShowInShelf(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
}
