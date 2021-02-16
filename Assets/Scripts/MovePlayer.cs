using Mirror;
using UnityEngine;

public class MovePlayer : NetworkBehaviour
{
    [SerializeField] [Range(1.0f, 100.0f)] public float speed;

    // Start is called before the first frame update

    private void Start()
    {
        speed = 5.0f;
    }


    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        if (isLocalPlayer)
        {
            var horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            var vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.Translate(horizontal, 0.0f, vertical);
        }
    }
}