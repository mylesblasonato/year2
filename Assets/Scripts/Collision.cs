using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public class Collision : MonoBehaviour
{
    [SerializeField] FlowMachine _flowMachine;
    [SerializeField] string _unityEventName;
    [SerializeField] string _tag;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.collider.CompareTag(_tag))
        {
            _flowMachine.TriggerUnityEvent(_unityEventName);
        }
    }
}
