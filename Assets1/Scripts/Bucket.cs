using UnityEngine;

public class Bucket : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ScoreManager.instance.IncreaseScore();
        }
    }
}
