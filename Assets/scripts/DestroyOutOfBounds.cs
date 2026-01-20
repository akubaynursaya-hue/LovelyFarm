using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    [SerializeField] private PlayerHealth playerHealth;

    private void Start()
    {
        if (playerHealth == null)
        {
            playerHealth = FindObjectOfType<PlayerHealth>();
            if (playerHealth == null)
            {
                Debug.LogError("PlayerHealth component not found in the scene!");
            }
        }
    }

    void Update()
    {
        if (transform.position.z > topBound)
        {
            if (CompareTag("Animal") && playerHealth != null)
            {
                playerHealth.DecreaseHealth();
            }
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            if (CompareTag("Animal") && playerHealth != null)
            {
                playerHealth.DecreaseHealth();
            }

            Destroy(gameObject);
        }
    }
}