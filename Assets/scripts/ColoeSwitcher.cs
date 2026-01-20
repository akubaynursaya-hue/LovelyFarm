using UnityEngine;

public class MaterialSwitcher : MonoBehaviour
{
    [SerializeField] Material[] materials;
    int currentIndex = 0;
    [SerializeField] Renderer targetRenderer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            currentIndex = (currentIndex + 1) % materials.Length;
            targetRenderer.material = materials[currentIndex];
        }
    }
}

