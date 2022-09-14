using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ViewFinished : MonoBehaviour
{
    public TextMeshProUGUI text_percentage;
    public TextMeshProUGUI text_rating;
    public TextMeshProUGUI text_message;

    private void Start()
    {
        
    }

    public void LoadData()
    {
        float percentage = (AppManager.instance.currSuccessCount / AppManager.instance.currTest.repetitions) * 100;
        percentage = Mathf.RoundToInt(percentage);

        text_percentage.SetText(percentage.ToString() + "%");

        string rating = percentage >= 80 ? "geschafft" : "nicht geschafft";
        if (percentage == 69) rating = "Nice :)";
        text_rating.SetText(rating);

        bool positive = percentage >= 80;
        text_message.SetText(AppManager.instance.GetMessage(positive));
    }
}
