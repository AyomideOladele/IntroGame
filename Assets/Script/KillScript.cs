using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindWithTag("GameController").GetComponent<GameController>().LoseGame();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
