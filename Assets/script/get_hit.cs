using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Slider = UnityEngine.UI.Slider;

public class get_hit : MonoBehaviour
{
    private Player _player;
    void Start()
    {
        _player = GetComponent<Player>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (_player.isHit)
        {
            if (_player.health > 0)
                _player.health -= _player.damageTaken;
            _player.isHit = false;
            _player.damageTaken = 0;
        }
    }
}
