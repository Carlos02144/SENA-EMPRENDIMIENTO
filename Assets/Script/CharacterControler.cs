using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterControler : MonoBehaviour
{
    public float VelocidadMovimiento = 5.0f;
    public float VelocidadRotacion = 200.0f;
    public float movimientoX,movimientoY,speedY,speedX;
    public Animator anim;
    public float x, y;
    private Transform camara;
    public bool OnPause;
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
        camara = transform.Find("Camera");

        PuedoSaltar = false;
        anim = GetComponent<Animator>();

        velocidadInicial = VelocidadMovimiento;
        velocidadAgachado = VelocidadMovimiento * 0.5f;
        velCorrer = 5f;

    }

    void FixedUpdate()
    {
        
        transform.Translate(0,0,y*Time.deltaTime * VelocidadMovimiento);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameState == GameState.Pause) OnPause = true; else OnPause = false;
        if (!OnPause)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");

            movimientoX = Input.GetAxis("Mouse X");
            movimientoY = Input.GetAxis("Mouse Y");

            anim.SetFloat("VelX", x);
            anim.SetFloat("VelY", y);
            //Rotar personaje
            if (movimientoX != 0) transform.Rotate(Vector3.up * movimientoX * Time.deltaTime * speedX);
            //Mirar Arribar
            if (movimientoY != 0)
            {
                float angles = (camara.eulerAngles.x - movimientoY * speedY + 360) % 360;
                if (angles > 180) { angles -= 360; }
                angles = Math.Clamp(angles, -80, 80);
                camara.localEulerAngles = Vector3.right * angles;
            }
            //Correr
            if (Input.GetKey(KeyCode.LeftShift) && !estoyAgachado && PuedoSaltar)
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
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    anim.SetBool("Salte", true);
                    rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
                }

                if (Input.GetKey(KeyCode.LeftControl))
                {
                    anim.SetBool("Agachado", true);
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
    }
    public void EstoyCayendo()
        {
            anim.SetBool("TocoSuelo", false);
            anim.SetBool("Salte", false);
        }
    
}
