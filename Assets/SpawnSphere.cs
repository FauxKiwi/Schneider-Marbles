using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    public GameObject sphere;
    public Cylinders cylinders;
    
    public void OnClick()
    {
        var y = (cylinders.Num - 2) * 2 - 1;

        Instantiate(sphere, new Vector3(0, y, 0), Quaternion.identity);
    }
}
