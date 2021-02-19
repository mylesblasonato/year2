using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLives : MonoBehaviour
{
    public int _livesCount = 3;
    [SerializeField] GameObject _heartPrefab, _parent;
    private List<GameObject> _lives;

    private void Start()
    {
        _lives = new List<GameObject>();

        for (int i = 0; i < _livesCount; i++)
        {
            _lives.Add(GameObject.Instantiate(_heartPrefab, _parent.transform));
        }
    }

    public void RemoveLife()
    {
        GameObject.Destroy(_lives[_lives.Count - 1]);
        _lives.RemoveAt(_lives.Count - 1);
    }
}
