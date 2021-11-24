using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTickSpeed : MonoBehaviour
{
    public void SetTickSpeed(float tickSpeed)
    {
        Time.timeScale = tickSpeed;
    }
}
