using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddScore : MonoBehaviour
{
    [SerializeField] Data _data;
    [SerializeField] Animator _animator;
    private TextMeshProUGUI _scoreText;

    private void Awake()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();       
    }

    private void Start()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        _scoreText.text = $"{ _data._score.ToString()}";
        _animator.SetTrigger("Score");
    }
}
