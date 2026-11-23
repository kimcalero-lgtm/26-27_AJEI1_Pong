using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class BallMov : MonoBehaviour
{
    public float speed;
    Vector3 dir;
    public puntuacion puntuacion; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
       
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {



        Debug.Log("Y se marchooo" + collision.gameObject.tag);

        if (collision.gameObject.tag == "wall")
        {
            dir.y = dir.y * -1;
        }
        if (collision.gameObject.tag == "pala")
        {
            dir.x = dir.x * -1;
        }
        if (collision.gameObject.tag == "goal")
        {
            transform.position = new Vector3(0, 0);
            Spawn();
            if (collision.gameObject.name == "porteria a")
            {
                Debug.Log("El jugador B ha marcado goal");

                puntuacion.puntuacionB = puntuacion.puntuacionB + 1;
            }
            if (collision.gameObject.name == "porteria b")
            {
                Debug.Log("El jugador A ha marcado goal");

                puntuacion.puntuacionA = puntuacion.puntuacionA + 1;
            }
        }
    }
    void Spawn()
    {
        Debug.Log("traka");
        dir = new Vector3(
         Random.Range(-1f, 1f),
         Random.Range(-1f, 1f)
         );

        if (dir.x > 0)
        {
            dir.x = 1;
        }
        else
        {
            dir.x = -1;
        }

        dir.Normalize();
    }
}