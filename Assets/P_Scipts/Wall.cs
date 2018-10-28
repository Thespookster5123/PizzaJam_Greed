﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public Sprite damageSprite;
    public int hp = 2;
    SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
	}


    public void DamageWall(int loss)
    {
        spriteRenderer.sprite = damageSprite;
        hp -= loss;
        if (hp <= 0)
        {
            gameObject.SetActive(false);
        }
    }


}
