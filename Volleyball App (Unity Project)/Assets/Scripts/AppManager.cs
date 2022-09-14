using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public static AppManager instance;

    public Path path;
    public enum Path
    {
        Excersise,
        Test,
        Stats
    }

    public float currSuccessCount;
    public TestData currTest;

    public List<string> positiveMessages;
    public List<string> negativeMessages;

    public PlayerStats stats;

    private void Awake()
    {
        instance = this;
    }

    #region Paths

    public void SetPath(int index)
    {
        if (index == 0) path = Path.Test;
        if (index == 1) path = Path.Excersise;
        if (index == 2) path = Path.Stats;
    }

    #endregion

    #region Getters

    public string GetMessage(bool positive)
    {
        if (positive)
            return positiveMessages[UnityEngine.Random.Range(0, positiveMessages.Count)];
        else
            return negativeMessages[UnityEngine.Random.Range(0, negativeMessages.Count)];
    }

    #endregion
}

[Serializable]
public class PlayerStats
{
    public int totalExcersisesDone;

}
