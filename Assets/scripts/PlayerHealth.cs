using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;

    public void DecreaseHealth()
    {
        health--;

        Debug.Log("Жизни: " + health);

        if (health <= 0)
        {
            UImanager.Instance.LoseGame();
        }
    }
}
