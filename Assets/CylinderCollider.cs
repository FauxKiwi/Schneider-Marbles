using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CylinderCollider : MonoBehaviour
{
    public float force;

    public static float rngValue = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        var rng = Random.value <= rngValue;
        Debug.Log(rng ? "Left" : "Right");

        var xForce = rng ? -force : force;

        other.attachedRigidbody.AddForce(xForce, 0, 0);
    }
}
