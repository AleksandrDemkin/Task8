using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed = 4f;

    private Vector3 _position;


    void Start()
    {
        _position = _target.InverseTransformPoint(transform.position);
    }

    
    void Update()
    {
        var currentPosition = _target.TransformPoint(_position);
        transform.position = Vector3.Lerp(transform.position, currentPosition, _speed * Time.deltaTime);
        var currentRotation = Quaternion.LookRotation(_target.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, currentRotation, _speed * Time.deltaTime);
    }
}