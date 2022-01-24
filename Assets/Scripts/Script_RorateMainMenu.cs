using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Script_RorateMainMenu : MonoBehaviour
{
    private Vector3 _acceleration;

    private readonly float _xRange = 7f;

    private Vector3 _angle;
    void Start()
    {
        _angle = transform.eulerAngles;
    }

    
    void Update()
    {
        RotateMenu();
    }

    private void RotateMenu()
    {
        _acceleration = Input.acceleration;
        _angle.z = Mathf.Clamp(_angle.z + _acceleration.x, -_xRange, _xRange);
        transform.eulerAngles = _angle;
    }
}
