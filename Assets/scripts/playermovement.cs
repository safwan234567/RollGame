using UnityEngine;

public class playermovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardforce = 1400f;
    public float sidewaysforce = 700f;
	
	// This is marked as "fixed"update because we use it
    // to mess with physics
	void FixedUpdate ()
    {
            //add a forward force
          rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if( Input.GetKey("d") )

        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (Input.GetKey("a"))

        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }



    }
}
