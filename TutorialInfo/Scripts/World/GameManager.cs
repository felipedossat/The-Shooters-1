using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
  public static GameManager Instance { get; private set; }

    public int gunAmmo = 10;

    public int health = 100; 
    
    
    
    
    private void Awake()
    {

        Instance = this; 
    }


    private void LoseHealth(int healtToReduce)
    {
        health -= healtToReduce; 

    }





}
