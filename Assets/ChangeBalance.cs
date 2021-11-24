using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBalance : MonoBehaviour
{
    public void SetBalance(float balance)
    {
         CylinderCollider.rngValue = (balance - 1) / -2f;
    }
}
