using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    private int _num;
    private int[] _scores;

    public void SetNum(float num)
    {
        _num = (int) num - 2;
        _scores = new int[_num];
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
            sb.Append(score);
            sb.Append(" ");
        }

        GetComponent<UnityEngine.UI.Text>().text = sb.ToString();
    }
}
