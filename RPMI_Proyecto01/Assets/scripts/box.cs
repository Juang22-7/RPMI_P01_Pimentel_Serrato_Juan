using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
         
    
    }
    //Función que se ejecuta cuando un objeto colisiona con otro
    private void OnCollisionEnter(Collision collision)
    {
        print("CHOQUE");
        if (collision.gameObject.CompareTag("Player")) 
        {
         //DestroyGameobject
         Destroy(gameObject);
             

        }
        
    
    }


    
        
    }

