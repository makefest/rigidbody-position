using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ResetPosition : MonoBehaviour
{
    Rigidbody _rigidbody;
    Vector3 _startPosition;
    [SerializeField] private bool _useRigidbodyAPI;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _startPosition = _rigidbody.position;
    }

    void ZeroVelocityOnRigidbodies()
    {
        _rigidbody.velocity = Vector3.zero;
        foreach (var rigidbody in GetComponentsInChildren<Rigidbody>())
        {
            rigidbody.velocity = Vector3.zero;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_useRigidbodyAPI)
            _rigidbody.position = _startPosition;
        else
            transform.position = _startPosition;            
        ZeroVelocityOnRigidbodies();
    }
}
