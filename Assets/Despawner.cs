using UnityEngine;

public class Despawner : MonoBehaviour
{
    public ScoreText scoreText;
    
    private void OnTriggerEnter(Collider other)
    {
        scoreText.AddScore(other.transform.position.x);
        
        Destroy(other.gameObject);
    }
}
