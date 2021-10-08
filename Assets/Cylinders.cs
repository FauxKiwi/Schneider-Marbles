using System.Collections.Generic;
using UnityEngine;

public class Cylinders : MonoBehaviour
{
    public GameObject prefab;

    public int Num { get; private set; } = 0;

    private readonly List<GameObject> _instantiated = new List<GameObject>();
    
    private static readonly Quaternion Rotation = Quaternion.Euler(-90, 0, 0);
    
    public void OnSliderChanged(float value)
    {
        Num = (int) value;

        foreach (var instance in _instantiated)
        {
            Destroy(instance);
        }

        for (var y = 0; y < Num - 1; ++y)
        {
            var posY = y * 2;
            
            if (y % 2 == 0) 
                _instantiated.Add(Instantiate(prefab, new Vector3(0, posY, 0), Rotation));

            var offset = y % 2 != 0 ? 1 : 0;
            
            for (var x = 1; x <= (Num - y - 1) / 2; ++x)
            {
                _instantiated.Add(Instantiate(prefab, new Vector3(-2 * x + offset, posY, 0), Rotation));
                _instantiated.Add(Instantiate(prefab, new Vector3(2 * x - offset, posY, 0), Rotation));
            }
        }
    }
}
