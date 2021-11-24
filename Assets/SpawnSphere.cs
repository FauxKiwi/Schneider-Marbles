using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    public float firstThreshold;
    public float repeatTime;

    public GameObject sphere;
    public Cylinders cylinders;

    private bool _active;
    private bool _first;

    private float _timeElapsed;
    
    public void OnDown()
    {
        _active = true;
        _first = true;
        _timeElapsed = 0f;
    }

    public void OnUp()
    {
        _active = false;
    }

    public void Update()
    {
        if (!_active) return;

        if (_timeElapsed == 0f)
        {
            Spawn();
        }
        else if (_first && _timeElapsed > firstThreshold * Time.timeScale)
        {
            _timeElapsed = 0f;
            _first = false;
            Spawn();
            return;
        }
        else if (!_first && _timeElapsed > repeatTime* Time.timeScale)
        {
            _timeElapsed = 0f;
            Spawn();
        }

        _timeElapsed += Time.deltaTime;
    }

    private void Spawn()
    {
        var num = cylinders.Num;
        if (num < 2) return;

        var y = (num - 2) * 2 - 1;

        Instantiate(sphere, new Vector3(0, y, 0), Quaternion.identity);
    }
}
