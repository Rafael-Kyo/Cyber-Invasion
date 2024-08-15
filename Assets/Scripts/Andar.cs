using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float moveH;
    public int velocidade;
    public int forcaPulo;
    public Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    public bool isJumping = false;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate() 
    {
        //Andar
        moveH = Input.GetAxis("Horizontal");
        
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0,0);
    }

    void Update()
    {
        //Animação Andar
        if(Input.GetKey(KeyCode.D) && moveH > 0)
        {
            sprite.flipX = true;
            
        }
        
        if(Input.GetKey(KeyCode.A) && moveH < 0)
        {
            sprite.flipX = false;
        }
        
        if(moveH == 0)
        {
            
        }
        

        //Pular
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * forcaPulo,ForceMode2D.Impulse);
  
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Chão"))
        {
            isJumping = false;
        }
        
    }
}
