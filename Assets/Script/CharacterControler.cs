using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler : MonoBehaviour
{
    public float VelocidadMovimiento = 5.0f;
    public float VelocidadRotacion = 200.0f;
    public Animator anim;
    public float x, y;

    //Correr
    public float velCorrer = 20;

    public bool estoyAgachado;

    public Rigidbody rb;
    public float fuerzaDeSalto = 10f;
    public bool PuedoSaltar;

    public float velocidadInicial;
    public float velocidadAgachado;


    // Start is called before the first frame update
    void Start()
    {
        PuedoSaltar = false;
        anim = GetComponent<Animator>();

        velocidadInicial = VelocidadMovimiento;
        velocidadAgachado = VelocidadMovimiento * 0.5f;
        velCorrer = 5f;

    }

    void FixedUpdate()
    {
        transform.Rotate(0,x*Time.deltaTime * VelocidadRotacion,0);
        transform.Translate(0,0,y*Time.deltaTime * VelocidadMovimiento);
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        x= Input.GetAxis("Horizontal");
        y= Input.GetAxis("Vertical");

        anim.SetFloat("VelX" ,x);
        anim.SetFloat("VelY" ,y);

        //Correr
        if (Input.GetKey(KeyCode.LeftShift)&& !estoyAgachado &&PuedoSaltar)
        {
            
            if (y > 0)
            {
                anim.SetBool("Correr", true);
            }
            else
            {
                anim.SetBool("Correr", false);
            }
            velocidadInicial = velCorrer;
        }
        else
        {
            anim.SetBool("Correr", false);
            
            if (estoyAgachado)
            {
                //Mover
                VelocidadMovimiento = velocidadAgachado;
            }
            else if (PuedoSaltar)
            {
                //Mover
                VelocidadMovimiento = velocidadInicial;
            }
        }

        if (PuedoSaltar)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Salte",true);
                rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            }

            if(Input.GetKey(KeyCode.LeftControl))
            {
              anim.SetBool("Agachado",true);
              //VelocidadMovimiento = velocidadAgachado;
            }
            else
            {
                anim.SetBool("Agachado", false);
                VelocidadMovimiento = velocidadInicial;
            }
            anim.SetBool("TocoSuelo", true);    
        }
       

        else
        {
            EstoyCayendo();
        }
        velocidadInicial = 2;

        
    }
    public void EstoyCayendo()
        {
            anim.SetBool("TocoSuelo", false);
            anim.SetBool("Salte", false);
        }
    
}
