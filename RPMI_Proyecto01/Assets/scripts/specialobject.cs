using UnityEngine;

public class specialobject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
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
