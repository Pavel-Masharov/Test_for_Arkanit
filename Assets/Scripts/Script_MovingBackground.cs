using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_MovingBackground : MonoBehaviour
{

    private Vector3 _acceleration;

    private readonly float _xRange = 3f;

    private Vector3 _offset;
    void Start()
    {
        _offset = transform.position;
    }
    void Update()
    {
        MoveMenu();
    }
    private void MoveMenu()
    {
        _acceleration = Input.acceleration;
        _offset.x = Mathf.Clamp(_offset.x + _acceleration.x, -_xRange, _xRange);
        transform.position = _offset;
    }
}
