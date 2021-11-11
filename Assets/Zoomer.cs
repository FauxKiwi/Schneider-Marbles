using UnityEngine;

public class Zoomer : MonoBehaviour
{
    public void ChangeZoomLevel(float slider)
    {
        var cam = GetComponent<Camera>();
        cam.orthographicSize = slider * 2 * 2;
        cam.transform.SetPositionAndRotation(new Vector3(0, slider, -10), Quaternion.identity);
    }
}
