using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New data", menuName = "Space Invaders/Create Data")]
public class Data : ScriptableObject
{
    public int _lives = 3;
    public float _score = 0;
    public float _scoreMutliplier = 5;
    public int _levelReq = 0;
    public int _level = 1;
}
