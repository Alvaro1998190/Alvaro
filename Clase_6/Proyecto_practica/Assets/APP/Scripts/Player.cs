using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// CODIGO PARA MOVER AL PERSONAJE EN VECTOR 3

public class Player : MonoBehaviour
{


    public float speed = 1f;

    public Animator animator;

    private SpriteRenderer spriteRenderer;

    private Rigidbody2D rigidbody2;

    // Start is called before the first frame update
    void Start()
    {

        rigidbody2 = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Input.GetAxis("Horizontal"));

        float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime;


        if (h != 0)
            animator.SetBool("Walk", true);
        else
            animator.SetBool("Walk", false);


        // Es otra forma de nombrar al sprite de que se mueve o no
        // animator.SetBool("walk", (h != 0));




        // CODIGO PARA VOLTEAR EL SPRITE SHEET AL EJE -X DEL X
        if (h > 0)
            spriteRenderer.flipX = false;

        else if (h < 0)
            spriteRenderer.flipX = true;

        //if (h < 0)
        // spriteRenderer.flipX = true;




        //translate siempre requiere un Vector3
        transform.Translate(Vector3.right * h * speed);



        if (Input.GetKeyDown(KeyCode.Space)) 
        rigidbody2.AddForce(Vector2.up * 2, ForceMode2D.Impulse);



    }

 

        

         }





