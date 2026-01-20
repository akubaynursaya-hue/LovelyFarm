using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horizontalInput;
    [SerializeField] float speed = 10f;
    [SerializeField] float xRange = 10f;

    [SerializeField] GameObject[] foodPrefabs;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -xRange, xRange);
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, foodPrefabs.Length);
            Instantiate(foodPrefabs[index], transform.position, foodPrefabs[index].transform.rotation);
        }
    }
}

