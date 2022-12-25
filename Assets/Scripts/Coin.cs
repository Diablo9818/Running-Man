using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _pointValue;
    [SerializeField] private int _rotationY = 360;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        Rotate();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.UpdateScore(_pointValue);
    }

    private void Rotate()
    {
        transform.Rotate(0, _rotationY * Time.deltaTime, 0);
    }
}
