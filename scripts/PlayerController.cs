using UnityEngine;

public class PlayerController : MonoBehaviour
{
      private Vector2 moveDirection;
      private Vector2 lookDirection;
      [SerializeField] private float cameraTurnSpeed; 
      private Animator anim;
      private Rigidbody rb;
      void Awake()
      {
            rb = GetComponent<Rigidbody>();
            anim = GetComponent<Animator>();
      }
      void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
      void Movment()
      {
           moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
           anim.SetFloat("X", moveDirection.x);
           anim.SetFloat("Y", moveDirection.y);
      }
      void Update()
      {
            Movment();
      }
}
