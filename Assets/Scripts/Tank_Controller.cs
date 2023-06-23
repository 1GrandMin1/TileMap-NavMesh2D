using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Controller : MonoBehaviour
{ 
    [SerializeField] private float _speedCharacter;
    //[SerializeField] private Animator _animationPlayer;
    private Vector2 _directionCharacter;
    private Rigidbody2D _rbCharacter;
    private int _healthCharacter = 3;

    private void Start()
    {
        _rbCharacter = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _directionCharacter.x = Input.GetAxisRaw("Horizontal");
        _directionCharacter.y = Input.GetAxisRaw("Vertical");
        //_animationPlayer.SetFloat("Horizontal", _directionCharacter.x);
        //_animationPlayer.SetFloat("Vertical", _directionCharacter.y);
        //_animationPlayer.SetFloat("Speed", _directionCharacter.sqrMagnitude);

    }
    private void FixedUpdate()
    {
        _rbCharacter.MovePosition(_rbCharacter.position + _directionCharacter * _speedCharacter * Time.fixedDeltaTime);
    }
    public void TakeDamage(int damage)
    {
        _healthCharacter -= damage;

        if (_healthCharacter <= 0)
        {
            Destroy(gameObject);
        }
    }

}

