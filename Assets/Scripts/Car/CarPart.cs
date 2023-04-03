using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public enum PartType
{
    LeftDoor,
    RightDoor
}
public interface IInteractable
{
    public void OnUse();
}

public abstract class CarPart : NetworkBehaviour, IInteractable
{
    [SerializeField] protected Transform _parent;

   public abstract void PartInteraction();

    private void Awake()
    {
        if(transform.parent !=null) _parent = transform.parent;
    }
    public void OnUse()
    {
        OpenDoorServerRPC();
    }
    [ServerRpc(RequireOwnership = false)]
    public void OpenDoorServerRPC()
    {
        OpenDoorClientRPC();
    }
    [ClientRpc]
    public void OpenDoorClientRPC()
    {
        PartInteraction();
    }
}


