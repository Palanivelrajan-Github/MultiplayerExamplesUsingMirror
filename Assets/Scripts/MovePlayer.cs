using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] [Range(1.0f, 100.0f)] public float speed;

    // Start is called before the first frame update

    private void Start()
    {
        speed = 5.0f;
    }

    // Update is called once per frame
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        var vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontal, 0.0f, vertical);
    }
}