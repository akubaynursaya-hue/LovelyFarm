using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float minSpeed = 2f;
    [SerializeField] float maxSpeed = 20f;

    private float speed;

    void Start()
    {
       
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
