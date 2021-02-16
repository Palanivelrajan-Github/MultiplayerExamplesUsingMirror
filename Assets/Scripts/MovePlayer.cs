using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] [Range(1.0f, 100.0f)] public float speed;

    // Start is called before the first frame update

    private void Start()
    {
        speed = 10.0f;
    }

    // Update is called once per frame
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal") * speed;
        var vertical = Input.GetAxis("Vertical") * speed;
        transform.Translate(horizontal, 0.0f, vertical);
    }
}
