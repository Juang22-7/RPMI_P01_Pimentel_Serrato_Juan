using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);

            print("Game over");

            


        }
    }   


}
