using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ViewTest : MonoBehaviour
{
    public List<TestData> testDatas;

    public TextMeshProUGUI text_title;
    public TextMeshProUGUI text_description;

    public void LoadTestData(int testIndex)
    {
        TestData data = testDatas[testIndex];

        text_title.SetText(data.title);
        text_description.SetText(data.description);
    }
}
