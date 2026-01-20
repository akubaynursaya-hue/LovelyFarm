using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            ScoreUI.Score++;
            ScoreUI.Instance.UpdateScoreText();

            if (ScoreUI.Score >= 10)
            {
                UImanager.Instance.WinGame();
            }

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
