using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _sensetivity;

    private GameManager _gameManager;
    private float _oldMousePositionX;
    private float _borderX = 2.8f;

    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (_gameManager.isGameActive)
        {
            Move();
        }
    }

    private void Move()
    {
        transform.position += transform.forward * Time.deltaTime * _speed;

        float deltaX = Input.mousePosition.x - _oldMousePositionX;
        _oldMousePositionX = Input.mousePosition.x;

        if (deltaX < 0 && transform.position.x > -_borderX)
        {
            transform.Translate(new Vector3(-_sensetivity, 0, 0) * Time.deltaTime * _speed);
        }

        if (deltaX > 0 && transform.position.x < _borderX)
        {
            transform.Translate(new Vector3(_sensetivity, 0, 0) * Time.deltaTime * _speed);
        }
    }

}
