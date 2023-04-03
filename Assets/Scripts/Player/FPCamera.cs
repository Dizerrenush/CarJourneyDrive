using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class FPCamera : NetworkBehaviour
{
    public Transform Player;
    public float RotationSpeed;


    private float XAngle;

    public LayerMask Interact;


    void Update()
    {
        float mxIn = Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime;
        float myIn = Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime;

        XAngle -= myIn;
        XAngle = Mathf.Clamp(XAngle,-90,90);

        Player.Rotate(new Vector3(0,mxIn,0));
        transform.rotation = Quaternion.Euler(XAngle,Player.rotation.eulerAngles.y, Player.rotation.eulerAngles.z);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Use();
        }
    }
    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.red);
    }

    public void Use()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2f, Interact))
        {
            Debug.Log(hit.collider.gameObject.name);
            hit.collider.gameObject.GetComponent<IInteractable>().OnUse();
           
        }
    }
}
