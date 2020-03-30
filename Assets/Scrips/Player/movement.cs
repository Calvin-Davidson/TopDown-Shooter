using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    Transform camTrans;
    CharacterController _CharacterController;
    // Start is called before the first frame update
    void Start()
    {
        camTrans = GameObject.Find("PlayerCam").GetComponent<Transform>();
        _CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        if (movement != Vector3.zero)
        {
            movement.Normalize();
            //            transform.Translate(movement * Time.deltaTime * speed);
            _CharacterController.Move(movement * Time.deltaTime * speed); 
            
            Vector3 campos = this.transform.position;
            campos.y = 15f;
            camTrans.position = campos;
        }
    }
}