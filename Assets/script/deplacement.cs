using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{

    private Player player;
        private Vector3 move;
    
        [SerializeField] private float speed = 3f;
        [SerializeField] private float rotationSpeed = 100f;
    
        [SerializeField] private float jumpHeight = 3f;
        [SerializeField] private float gravity = -9.81f;
    
        private float jumpVelocity = 0f;
        // Start is called before the first frame update
        void Start()
        {
            player = GetComponent<Player>();
        }
    
        // Update is called once per frame
        void Update()
        {
            bool grounded = player.controller.isGrounded;
            /*if (grounded && Input.GetKeyDown("space"))
            {
                jumpVelocity += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
            }*/
    
            player.controller.Move(new Vector3(0, 0, 0) * Time.deltaTime);
            
            //move
            float horizontalMove = Input.GetAxis("Horizontal");
            if (horizontalMove != 0)
            {
                move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            }
            else
            {
                move = move = new Vector3(0, 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                player.isWalking = true;
            }
            else
            {
                player.isWalking = false;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                player.isWalkingBack = true;
            }
            else
            {
                player.isWalkingBack = false;
            }

            if (Input.GetKey(KeyCode.DownArrow))
                player.isCrouching = true;
            else
                player.isCrouching = false;

            //move = transform.TransformDirection(move);
            if (!player.inAnimation) {
                if (move.x < 0)
                    player.controller.Move(4*speed/5 * Time.deltaTime * move);
                else
                    player.controller.Move(speed * Time.deltaTime * move);
            }

        }
}
