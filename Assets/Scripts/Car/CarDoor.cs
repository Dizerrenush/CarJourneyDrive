using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDoor : CarPart
{
    [SerializeField]private float _currentAngle;
    [SerializeField] private float LRDoor;

    public override void PartInteraction()
    {
        if (_currentAngle == 0) _currentAngle = 60 * LRDoor;
        else _currentAngle = 0;
        _parent.localRotation = Quaternion.Euler(0, _currentAngle, 0);
    }
    
}
