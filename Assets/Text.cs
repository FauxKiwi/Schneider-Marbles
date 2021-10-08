using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public void SetText(float value)
    {
        GetComponent<UnityEngine.UI.Text>().text = ((int) value).ToString();
    }
}
