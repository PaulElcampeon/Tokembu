﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField]
    private string givenColour;

    public string colour { get; set; }
    public bool isSocketed { get; set; }
    public bool isGoingIntoSocket { get; set; }
    public float speed;
    private bool shouldDissapear;

    void Start()
    {
        colour = givenColour;
    }

    private void Update()
    {
        if (shouldDissapear) Minify();
    }

    public void Socketed()
    {
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        isSocketed = true;
    }

    public void Dissapear()
    {
        shouldDissapear = true;

        Invoke("Disable", 2f); 
    }

    private void Minify()
    {
        gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x * 0.8f, gameObject.transform.localScale.y * 0.8f);
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
