using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Transform Player;
    private float _rotationOffset;

    // Update is called once per frame
    void Update()
    {
        float mouseHInput = Input.GetAxis("Mouse X");
        _rotationOffset = _rotationOffset + mouseHInput * Time.deltaTime * 180;
        transform.rotation = Quaternion.Euler(0, Player.rotation.eulerAngles.y + _rotationOffset, 0);
        transform.position = Player.transform.position;
    }
}
