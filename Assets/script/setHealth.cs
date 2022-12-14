using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setHealth : MonoBehaviour
{
    public Player player;
    void Start()
    {
        Player player = GetComponentInParent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 actual = transform.localPosition;
        Vector3 scaling = new Vector3(player.health/100, 1, 1);
        Vector3 pos = new Vector3(scaling.x, actual.y, actual.z);
        transform.localScale = scaling;

    }
}
