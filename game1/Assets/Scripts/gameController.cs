using UnityEngine;

public class gameController : MonoBehaviour
{
    public Rigidbody rb;
    public float runSpeed = 500f;
    public float strafeSpeed =500f;
    public float jumpForce = 15f;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;
    protected bool strafeForward = false;
    protected bool strafeBack = false;
    protected bool doJump = false;
    void Update()
    {
       if(Input.GetKey("w")){
           strafeForward = true;
       }
       else{
           strafeForward = false;
       }
       if(Input.GetKey("s")){
           strafeBack = true;
       }
       else{
           strafeBack = false;
       }
 
       if(Input.GetKey("a")){
           strafeLeft = true;
       }
       else{
           strafeLeft = false;
       }

       if(Input.GetKey("d")){
           strafeRight = true;
       }
       else{
           strafeRight = false;
       }

       if(Input.GetKeyDown("space")){
           doJump = true;
       }
       else{
           doJump = false;
       }
       if(Input.GetKeyDown("q")){
            strafeLeft = false;
            strafeRight = false;
            strafeForward = false;
            strafeBack = false;
            doJump = false;
       }
    }

    void FixedUpdate()
    {
        if(strafeForward)
        {
            rb.AddForce(0, 0, strafeSpeed * Time.deltaTime, ForceMode.Impulse);
        }
        if(strafeBack)
        {
            rb.AddForce(0, 0, -strafeSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        //rb.AddForce(0, 0, runSpeed * Time.deltaTime);
        if(strafeLeft)
        {
            rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(strafeRight)
        {
            rb.AddForce(strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 
        if(doJump)
        {
            rb.AddForce(0, strafeSpeed * Time.deltaTime, 0, ForceMode.Impulse);
        }
    }
}
