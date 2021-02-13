using Bolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionController : MonoBehaviour
{
    [SerializeField] FlowMachine _flowMachine;
    [SerializeField] string _collidedObjectName = "LeftWall";
    [SerializeField] string _boltEventName = "GoRight";
    [SerializeField] string _tag = "Bullet";

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (string.Compare(collider.name, _collidedObjectName) == 0)
        {
            _flowMachine.TriggerUnityEvent(_boltEventName);
        }

        if (_tag!="" && collider.CompareTag(_tag))
        {
            _flowMachine.TriggerUnityEvent(_boltEventName);
        }
    }
}
