using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Graphic))]
public class HideOnBack : MonoBehaviour
{
    private Graphic renderer;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Graphic>();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Vector3.Angle((transform.position - camera.transform.position), transform.forward);
        Debug.Log("Angle: " + angle);

        renderer.enabled = angle < 80;
    }
}