using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CylinderCollider : MonoBehaviour
{
    public float force;

    private void OnTriggerEnter(Collider other)
    {
        var rng = Random.value <= 0.5f;
        Debug.Log(rng ? "Left" : "Right");

        var xForce = rng ? -force : force;

        other.attachedRigidbody.AddForce(xForce, 0, 0);
    }
}
