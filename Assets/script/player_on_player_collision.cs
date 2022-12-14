using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_on_player_collision : MonoBehaviour
{
    private Player self;
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Player>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        hitboxAttack attack = collision.gameObject.GetComponent<hitboxAttack>();
        if (attack && self.inDelay == 0 && attack.player != self)
        {
            self.isHit = true;
            self.inDelay = attack.delay;
            self.animator.Play("get_hit");
            self.damageTaken = attack.damage;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
