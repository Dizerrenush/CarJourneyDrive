using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrivarSeat : MonoBehaviour, IInteractable
{
    private bool _isFree = true;

    public CarController Car;

    // Update is called once per frame
 
    public void OnUse()
    {
        GameManager.Instance.GetInCar();
        Car.enabled = true;
        GameManager.Instance.Player.transform.position = transform.position;
        GameManager.Instance.Player.transform.SetParent(transform);
    }
}
