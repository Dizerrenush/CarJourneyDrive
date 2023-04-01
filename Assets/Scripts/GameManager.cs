using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance;

   public GameObject Player;
    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GetInCar()
    {
        Player.GetComponent<PlayerController>().enabled= false;
        Player.GetComponent<CharacterController>().enabled= false;
    }
    public void GetOutCar()
    {
        Player.GetComponent<PlayerController>().enabled = true;
        Player.GetComponent<CharacterController>().enabled = true;
    }
}
