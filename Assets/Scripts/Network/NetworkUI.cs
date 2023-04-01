using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine;
using UnityEngine.UI;

public class NetworkUI : MonoBehaviour
{
    [SerializeField] private Button _hostBtn;
    [SerializeField] private Button _clientBtn;
    [SerializeField] private TMP_InputField _ipInput;

    [SerializeField] private UnityTransport _transport;

    private void Awake()
    {
        _hostBtn.onClick.AddListener(() => {
            NetworkManager.Singleton.StartHost();        
        });

        _clientBtn.onClick.AddListener(() => {
            NetworkManager.Singleton.StartClient();
        });
        
    }
    public void SetIP(string IP)
    {
        _transport.ConnectionData.Address = IP;
    }

}
