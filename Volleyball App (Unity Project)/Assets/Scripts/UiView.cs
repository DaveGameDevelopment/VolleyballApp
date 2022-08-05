using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiView : MonoBehaviour
{
    public GameObject content;

    public void Show()
    {
        print("test");
        content.SetActive(true);
    }

    public void Hide()
    {
        content.SetActive(false);
    }
}