using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;       // your player
    public Vector3 offset = new Vector3(0, 3, -6);
    public float followSpeed = 10f;
    public float rotationSpeed = 5f;

    void LateUpdate()
    {
        if (!target) return;

        // target position and rotation
        Vector3 desiredPos = target.position + target.rotation * offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, followSpeed * Time.deltaTime);

        // make camera face same direction as target
        Quaternion desiredRot = Quaternion.Lerp(transform.rotation, target.rotation, rotationSpeed * Time.deltaTime);
        transform.rotation = desiredRot;
    }
}
