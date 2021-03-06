﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent dyingEvent;
    public UnityEvent deathEvent;
    public UnityEvent clearEvent;
    public bool isDying;
    public GameObject player;

    public void Cleared()
    {
        isDying = true;
        clearEvent.Invoke();
    }

    public void Dying()
    {
        isDying = true;
        dyingEvent.Invoke();
    }

    public void Death()
    {
        deathEvent.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static GameManager Get()
    {
        return GameObject.FindObjectOfType<GameManager>();
    }
}
