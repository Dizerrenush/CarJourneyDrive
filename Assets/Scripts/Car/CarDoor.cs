using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable 
{
    public void OnUse();
}

public class CarDoor : MonoBehaviour, IInteractable
{
    private float _currentAngle = 0;

    public float LRDoor;

    // Update is called once per frame
  
    public void OnUse()
    {
        if (_currentAngle == 0) _currentAngle = 60*LRDoor;
        else _currentAngle = 0;
        transform.rotation = Quaternion.Euler(0, _currentAngle, 0);
    }
}
