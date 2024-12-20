using UnityEngine;


[ExecuteInEditMode]
public class MaterialTiling : MonoBehaviour
{
    private const float scaleFactor = 1.0f;

    private void Update () {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null) {
            Material material = renderer.sharedMaterial;

            if (material != null) {
                Vector3 scale = transform.localScale;
                Vector2 newTiling = new Vector2(scale.x / scaleFactor, scale.z / scaleFactor);
                material.mainTextureScale = newTiling;
            }
            else {
                Debug.LogError("Material not found.");
            }
        }
        else {
            Debug.LogError("Renderer component not found.");
        }
    }
}