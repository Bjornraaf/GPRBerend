﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    [SerializeField] public GameObject deathWindow;
    protected int Health = 100;
    [SerializeField] Text hitText;

    void Update()
    {
        if (Health == 0)
        {
            Destroy(gameObject);
            deathWindow.SetActive(true);
            Debug.Log("Dead");
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown("space"))
        {
            Hit();
        }

    }

    //void OnCollisionEnter2D(Collision2D collision)
    //{
       //if (collision.gameObject.tag == "Enemy")
       //{
       //    Hit();
       //}

       //if (collision.gameObject.tag == "Wall")
       // {
       //   Hit();
       // }
    //}

    void Hit()
    {
        Health-=10;
        Debug.Log(Health);
        hitText.text = "HP:" + " " + Health.ToString();
    }
}
