using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public GameObject prefab;

    private int _num;
    private int[] _scores;
    private int _scoreSum;

    private readonly List<GameObject> _instantiated = new List<GameObject>();
    
    private static readonly Quaternion Rotation = Quaternion.Euler(0, 0, 0);

    public void SetNum(float num)
    {
        _num = (int) num * 2 - 2;
        _scores = new int[_num];
        _scoreSum = 0;

        foreach (var instance in _instantiated)
        {
            Destroy(instance);
        }
        _instantiated.Clear();

        for (var i = 0; i < _num / 2; ++i) {
            _instantiated.Add(Instantiate(prefab, new Vector3(i * 2 + 1, -2, 0), Rotation));
            _instantiated.Add(Instantiate(prefab, new Vector3(i * -2 - 1, -2, 0), Rotation));
        }
    }

    public void AddScore(float x)
    {
        var index = (int) ((x + _num - 0.5f) / 2);
        ++_scores[index];
        ++_scoreSum;

        for (int i = 0; i < _scores.Length; ++i) {
            var barIndex = i >= _num / 2 ? (i - _num / 2) * 2 + 1 : -(i - _num / 2) * 2;
            --barIndex;

            var o = _instantiated[barIndex];

            var score = _scores[i];
            var maxSize = _num + 2;
            var size = score * maxSize / (float) _scoreSum;

            var t = o.transform;
            t.position = new Vector3(t.position.x, -2 + size / 2f - maxSize, t.position.z);
            t.localScale = new Vector3(t.localScale.x, size, t.localScale.z);

            /*var text = o.GetComponent<TextMesh>();
            if (text == null) text = o.AddComponent<TextMesh>();
            text.text = "new text set";
            text.fontSize = 30;*/
        }

        /*var sb = new StringBuilder();
        //var i = -_num / 2;
        foreach (var score in _scores)
        {
            //if (i == 0) ++i;
            sb.Append(score);
            sb.Append(" ");
        }*/

        GetComponent<UnityEngine.UI.Text>().text = $"({_scoreSum} marbles)";//sb.ToString();
    }
}
