﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{

    private Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Left()
    {
        anim.SetTrigger("Left");
    }

    public void Right()
    {
        anim.SetTrigger("Right");
    }

    public void Up()
    {
        anim.SetTrigger("Up");
    }

    public void Down()
    {
        anim.SetTrigger("Down");
    }
}
