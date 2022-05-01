using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        if (collision.transform.tag == "Player")
        {
            GameObject Player = GameObject.Find("Player");
            PlayerController playerController = Player.GetComponent<PlayerController>();
           playerController.coins++;
            
         //  Debug.Log(playerController.coins++);
        }
    }
}
