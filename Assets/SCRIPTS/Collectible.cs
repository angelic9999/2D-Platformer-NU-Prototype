using UnityEngine;

public class Collectible : MonoBehaviour
{
   
   public void OnTriggerEnter2D(Collider2D other)
   {
    if (other.gameObject.CompareTag("Player"))
    {
        Destroy(gameObject);
    }
   }
    
}
