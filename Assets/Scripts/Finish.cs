using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private GameManager _gameManager;
 
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _animator.SetTrigger("FinishTrigger");
        _gameManager.StartCoroutine("FinishLevel");
    }
}
