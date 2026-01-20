using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    private Camera cam;
    private bool isOrthographic = false;

    // Orthographic settings
    public Vector3 orthoPosition = new Vector3(0.2332048f, 22.42354f, -5.049781f);
    public Vector3 orthoRotation = new Vector3(90f, 0f, 0f);

    // Perspective settings
    public Vector3 perspPosition = new Vector3(-0.2332048f, 12.7f, -29.3f);
    public Vector3 perspRotation = new Vector3(36.203f, 0f, 0f);

    private void Start()
    {
        cam = GetComponent<Camera>();
        SetPerspective(); // Start in perspective (optional)
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (isOrthographic)
                SetPerspective();
            else
                SetOrthographic();
        }
    }

    private void SetOrthographic()
    {
        cam.orthographic = true;
        transform.position = orthoPosition;
        transform.rotation = Quaternion.Euler(orthoRotation);
        isOrthographic = true;
    }

    private void SetPerspective()
    {
        cam.orthographic = false;
        transform.position = perspPosition;
        transform.rotation = Quaternion.Euler(perspRotation);
        isOrthographic = false;
    }
}
