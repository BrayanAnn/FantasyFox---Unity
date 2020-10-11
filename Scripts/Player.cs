using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string Name;
    public int Cherry=3;
    public int Gem=3;
    public bool Fly;

    public Text TextCherry;
    public Text TextGem;

    public float Time;
    public float Distance;
    public float Speed=3;


    // Start is called before the first frame update
    void Start()
    {   
        TextCherry.text = Cherry.ToString();
        TextGem.text = Gem.ToString();
    }

    // Update is called once per frame
    void Update()
    {       
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();    
        float Direction = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(Direction*Speed,rigidbody.velocity.y);


        if(Direction<0||Direction>0)
        {
            GetComponent<Animator>().SetBool("Run", true);
        }else{
            GetComponent<Animator>().SetBool("Run", false);
        }

        if(Direction<0)
        {   
            GetComponent<SpriteRenderer>().flipX = true;

        }else if(Direction>0)
        {
            GetComponent<SpriteRenderer>().flipX = false;

        }

        if(Input.GetKeyDown(KeyCode.W))
        {   
            if(Fly==false){
                Jumping();
            }
        }

    }

    void Jumping()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0,300)); 
    }

    void OnCollisionEnter2D(Collision2D collision2D){
        Debug.Log("Colidindo");
        Fly=false;
    }

    void OnCollisionExit2D(Collision2D collision2D){
        Debug.Log("Não Colidindo");
        Fly=true;
    }

       
       
  

}
