using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Player : MonoBehaviour
{ 
    public Action OnDeath;
    public UnityEvent Win;
    GameOver gameover;

    void Start()
    {
        gameover = FindAnyObjectByType<GameOver>();
        gameover.loop += Winner;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnDeath?.Invoke();
    }

    void Winner()
    {
        Win?.Invoke();
    }
}
