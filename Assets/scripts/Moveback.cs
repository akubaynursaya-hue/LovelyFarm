using UnityEngine;

public class Moveback : MonoBehaviour
{
    [SerializeField] float speed = 40f;

    
    void Update()
    {
       transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
