using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public void Show()
    {
        GameManager.instance.Stop();
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        GameManager.instance.Resume();
        gameObject.SetActive(false);
    }
}
