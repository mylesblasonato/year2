using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="GameData", menuName ="Space Invaders/Data/Create Game Data")]
public class GameData : ScriptableObject
{
    public int _lives = 3;
    public int _score = 0;
    public int _level = 0;
    public int _highscore = 0;

    public void SaveGame()
    {
        PlayerPrefs.SetInt("Highscore", _highscore);
    }

    public void LoadGame()
    {
        _highscore = PlayerPrefs.GetInt("Highscore", _highscore);
    }
}
