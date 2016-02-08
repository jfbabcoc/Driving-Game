using UnityEngine;
using System.Collections;

public class Newbehaviour : MonoBehaviour {

    public float carSpeed;
    private Rigidbody2D rB;
    public float turnRadius;
    
	// Use this for initialization
	void Start () {
        rB = GetComponent<Rigidbody2D> ();
        
	}
	
	// Update is called once per frame
	public void MoveForward () {
	
        rB.velocity += new Vector2(transform.up.x * carSpeed * Time.deltaTime, transform.up.x * carSpeed * Time.deltaTime);
        
	}
    
    public void Turn (bool left) {
     
        float angle = -turnRadius;
        if(left == true)
            angle = turnRadius;
        
        transform.Rotate(0f, 0f, angle);
            
    }
    
    void Update() {
        
        MoveForward ();
        
        Turn (true);
    }
}
