using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TpPrueba : MonoBehaviour
{
    // Start is called before the first frame update
    public int x,y, z;
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        player.position = new Vector3(x,y,z);

        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("Nivel1", 2);
            SceneManager.LoadScene("Lobby");

        }

    }

    
}
