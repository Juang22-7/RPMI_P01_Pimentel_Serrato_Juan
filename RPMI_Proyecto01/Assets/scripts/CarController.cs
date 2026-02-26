//Librerías que se usan en el script 
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEditor.Experimental.GraphView;
public class CarController : MonoBehaviour
{
    //Inicio de la clase CarController
    public int specialScore;
    public int score;
    public int special;
    public float speed;
    public float retroceso;
    public float curva;
    public float turbo;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI specialText;
    public TextMeshProUGUI GAMEOVERText;
    public TextMeshProUGUI WINText;
    // Función se ejecuta el primer frame que el script está activo
    //Esta función solo se ejecuta una vez
    void Start()
    {//Inicio de la función "Start".
        print("Score=0");
        //Desactiva el componente del texto
        scoreText.enabled = false;
        specialText.enabled = false;
        
        
    }//Fin de la función "Start".

    //Función que se ejecuta todos los frames que el script está activo
    void Update()
    {//Inicio de la función "Update". 

        //Cuando la tecla w es pulsada el coche se moverá hacia adelante, cuando se pulsa la D, el coche gira hacia la derecha y cuando se le da a la A hacia izquierda, y en el espacio se activará un turbo
        if (Input.GetKey(KeyCode.W))
        {



            transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);

            if (Input.GetKey(KeyCode.D))




                transform.Translate(0, 0, -curva * Time.deltaTime, Space.World);




            if (Input.GetKey(KeyCode.A))



                transform.Translate(0, 0, curva * Time.deltaTime, Space.World);


            if (Input.GetKey(KeyCode.Space))


                transform.Translate((turbo * Time.deltaTime) * 2, 0, 0, Space.World);





        }




        //Cuando se pulsa la tecla s la variable hace que el coche retroceda
        if (Input.GetKey(KeyCode.S))
        {



            transform.Translate(-retroceso * Time.deltaTime, 0, 0, Space.World);








        }


        if (Input.GetKey(KeyCode.Escape))

        {
            Application.Quit();



        }




    }//Fin de la función "Update".
    private void OnCollisionEnter(Collision collision)
    {
        print("CHOQUE");
        if (collision.gameObject.CompareTag("Collectable"))
        {

            score = score + 10;
            print("ahora tu puntuación es: " + score);
            scoreText.text = score.ToString();
            if (score > 0)
                scoreText.enabled = true;
            else
            {

                scoreText.enabled = false;
            }






        }

        if (collision.gameObject.CompareTag("cono"))
        {
            score = score - 10;
            scoreText.text = score.ToString();
            print("ahora tu puntuación es: " + score);



        }

        if (collision.gameObject.CompareTag("special"))
        {

            special = special + specialScore;
            specialText.text = special.ToString();
            print("ahora tu puntuación es: " + special);

            specialText.enabled = true;




        }

        if (collision.gameObject.CompareTag("Fence"))
        {

            GAMEOVERText.enabled = true;

        }
        else
        {


            GAMEOVERText.enabled = false;


        }

        if (collision.gameObject.CompareTag("win"))
        {

            WINText.enabled = true;
        }
        else
        {



            WINText.enabled = false;
        }


    


        }
        
        
           



        }




        
    
   


    





//Fin de la clase CarController