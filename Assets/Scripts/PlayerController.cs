using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int vida = 100;
    public bool isOnGround = false;
    public float leftSpeed = 0f;
    public float rightSpeed = 0f;
    public float jumpForce = 0f;
    public AudioSource sndFail;
    public int coins = 0;
    public Text txtCoins;
    public GameObject CanvasWinner;
    public AudioSource sndCoin;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {  
        movimientoJugador();
        updateHud();
    }

    void updateHud()
    {
        txtCoins.text = coins + "";
    }

    void movimientoJugador()
    {
        
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(leftSpeed * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
           
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(rightSpeed * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            
        }

        if (Input.GetKeyDown("up") && isOnGround)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            gameObject.GetComponent<Animator>().SetBool("isOnGround", false);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Goal")
        {
            CanvasWinner.SetActive(true);
        }

        if (collision.transform.tag == "Ground")
        {
            isOnGround = true;
            gameObject.GetComponent<Animator>().SetBool("isOnGround", true);
        }
       
        if (collision.transform.tag == "Obstacle")
        {
            gameObject.transform.position = new Vector3(-0.0399999991f, 2.8900001f, 0f);
            sndFail.Play();
        }

        if (collision.transform.tag == "Coin")
        {

            sndCoin.Play();
        }



    }



}
