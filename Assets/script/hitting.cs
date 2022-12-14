using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitting : MonoBehaviour
{
    private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_player.animator.GetCurrentAnimatorStateInfo(0).IsName("punch"))
            _player.isPunching = false;
        _player.isPunching |= _player.animator.GetCurrentAnimatorStateInfo(0).IsName("punch");
        if (_player.isPunching)
        {
            _player.animator.SetBool("is_punching", false);
        }

        if (Input.GetKeyDown("w"))
        {
            _player.animator.SetBool("is_punching", true);
        }
    }
}
