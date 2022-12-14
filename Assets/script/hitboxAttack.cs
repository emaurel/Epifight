using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitboxAttack : MonoBehaviour
{
    public float delay;

    public Player player;

    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
