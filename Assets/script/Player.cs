using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Player : MonoBehaviour
{
    public bool isPunching = false;

    public bool isWalking = false;

    public bool isHit = false;

    public bool isAlive = true;

    public bool isJumping = false;

    public bool isBlocking = false;

    public bool isCrouching = false;

    public bool inAnimation = false;
    public bool isWalkingBack = false;

    public float health = 100f;

    public float inDelay = 0;

    public float damageTaken = 0;
    
    public Animator animator;
    public CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void isInAnimation()
    {
        if (!this.isPunching || this.isHit || !this.isAlive || this.isCrouching)
            this.inAnimation = false;
        this.inAnimation |= this.isPunching;
        this.inAnimation |= this.isHit;
        this.inAnimation |= !this.isAlive;
        this.inAnimation |= this.isCrouching;
    }
    // Update is called once per frame
    void Update()
    {
        if (this.health <= 0)
            this.isAlive = false;

        isInAnimation();
        if (this.isWalking)
            this.animator.SetBool("isRunning", true);
        else
            this.animator.SetBool("isRunning", false);
        
        if (this.isWalkingBack)
            this.animator.SetBool("isSteppingBack", true);
        else
            this.animator.SetBool("isSteppingBack", false);

        if (this.isCrouching)
            this.animator.SetBool("isCrouching", true);
        else
            this.animator.SetBool("isCrouching", false);
        this.animator.SetBool("isAlive", this.isAlive);

        if (this.inDelay != 0)
        {
            this.inDelay -= 3 * Time.deltaTime;
            print(this.inDelay);
            if (this.inDelay <= 0)
            {
                this.isHit = false;
                this.inDelay = 0f;
            }
                
        }
    }
}
