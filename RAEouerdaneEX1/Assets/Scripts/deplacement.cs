using UnityEngine;

public class deplacement : MonoBehaviour
{
    public float speed = 0.01f; // Vitesse de déplacement
    
    public float limitHaut = 10f; 
    public float limiteBas = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed, 0); 
        if (transform.position.y > limitHaut || transform.position.y < limiteBas)        {

            // float nouvellePositionX = transform.position.x; 
            // float nouvellePositionY = limiteBas;
            // transform.position = new Vector2(nouvellePositionX, nouvellePositionY);
            speed = speed * -1;
    
        }
    }
}
