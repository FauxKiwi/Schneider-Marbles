using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public string before;
    public bool integers = true;

    public void SetText(float value)
    {
        GetComponent<UnityEngine.UI.Text>().text = before + (integers ? (int) value : (int) (value * 100) / 100f).ToString();
    }
}
