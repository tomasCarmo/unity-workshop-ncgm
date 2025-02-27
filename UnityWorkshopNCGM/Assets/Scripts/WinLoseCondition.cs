using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseCondition : MonoBehaviour
{
    public GameObject _player;
    private bool _hasWon = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject == _player){
            _hasWon = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_hasWon){
            Debug.Log("You have won!");
            SceneManager.LoadScene("UIEnd");
        }
    }
}
