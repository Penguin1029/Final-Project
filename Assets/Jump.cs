using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D;
    public float jumpforce = 10;
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpforce);

        }
        _groundCheck = Physics2D.OverlapCapsule(point: feetCollider.position,
          size: new Vector2(CapsuleHeight, CapsuleRadius),
          CapsuleDirection2D.Vertical, angle: 0, groundMask);


      




    }
}
