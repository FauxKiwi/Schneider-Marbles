using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public GameObject prefab;

    private int _num;
    private int[] _scores;

    private readonly List<GameObject> _instantiated = new List<GameObject>();
    
    private static readonly Quaternion Rotation = Quaternion.Euler(0, 0, 0);

    public void SetNum(float num)
    {
        _num = ((int) num - 2) * 2;
        _scores = new int[_num];

        foreach (var instance in _instantiated)
        {
            Destroy(instance);
        }
        _instantiated.Clear();

        _instantiated.Add(Instantiate(prefab, new Vector3(0, -2, 0), Rotation));
    }

    public void AddScore(float x)
    {
        var index = (int) ((x + _num - 0.5f) / 2);
        ++_scores[index];

        var sb = new StringBuilder();
        //var i = -_num / 2;
        foreach (var score in _scores)
        {
            //if (i == 0) ++i;
            sb.Append(score * 2);
            sb.Append(" ");
        }

        GetComponent<UnityEngine.UI.Text>().text = sb.ToString();
    }
}
