using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    public float WalkSpeed;

    [SerializeField] Camera _cum;
    private CharacterController _playerController;


    void Start()
    {
        _cum = GetComponentInChildren<Camera>();
        if (!IsOwner) 
        { 
            _cum.enabled = false;
            return;
        }


        _playerController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    
    void Update()
    {
        if (!IsOwner) return;
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        Vector3 dir = transform.forward*vInput + transform.right * hInput;
        _playerController.Move(dir * WalkSpeed*Time.deltaTime);
      
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
         
    }
}
