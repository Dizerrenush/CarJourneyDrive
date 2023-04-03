using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;



public class CarPartHandler : NetworkBehaviour, IInteractable
{
   // [SerializeField]private CarPart _part;
    [SerializeField] private PartType _type;

    private void Awake()
    {
        switch (_type)
        {
            case PartType.LeftDoor:
             //   _part = new NetCarDoor(transform, 1);
                break;
            case PartType.RightDoor:
              //  _part = new NetCarDoor(transform, -1);
                break;
            default:
                break;
        }

       
    }
    public void OnUse()
    {
        OpenDoorServerRPC();
    }
    [ServerRpc(RequireOwnership =false)]
    public void OpenDoorServerRPC()
    {
        OpenDoorClientRPC();
    }
    [ClientRpc]
    public void OpenDoorClientRPC()
    {
       // _part.PartAction();
    }
}

/*public abstract class CarPart
{
    protected Transform _parent;

    public CarPart(Transform parent)
    {
        _parent = parent;
    }

    public abstract void PartAction();
}
[Serializable]
public class NetCarDoor : CarPart
{
    private float _currentAngle;
    [SerializeField] private float LRDoor;

    public NetCarDoor(Transform parent, int door) : base(parent)
    {
        _currentAngle= 0;
        LRDoor = door;
    }
    
    public override void PartAction()
    {
        if (_currentAngle == 0) _currentAngle = 60 * LRDoor;
        else _currentAngle = 0;
        _parent.localRotation = Quaternion.Euler(0, _currentAngle, 0);
        
    }
}*/


