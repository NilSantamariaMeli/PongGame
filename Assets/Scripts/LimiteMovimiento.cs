using UnityEngine;

public class LimiteMovimiento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float limitMax; 
    public float limitMin;

    // Update is called once per frame 4 -4 
    void Update()
    {
        if (transform.position.y > limitMax)
        {

            transform.position = new Vector3(transform.position.x, limitMax);

        }
        else if(transform.position.y < limitMin)
        {
            transform.position = new Vector3(transform.position.x, limitMin);
        }
    }
}
