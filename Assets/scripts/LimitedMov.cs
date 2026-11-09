using UnityEngine;

public class LimitedMov : MonoBehaviour
{
    public float limiteMax = 4;
    public float limiteMin = -4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (transform.position.y > limiteMax)
        {
            Debug.Log("TE PASASTEEEE");
            Vector3 newpos =  transform.position;
            newpos.y = limiteMax; 
            transform.position = newpos;
        }
        if (transform.position.y < limiteMin)
        {
            Vector3 newpos = transform.position;
            newpos.y = limiteMin;
            transform.position = newpos;
        }
    }

   
}
