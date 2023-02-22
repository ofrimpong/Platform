using UnityEngine;

public class LlCxc : MonoBehaviour
{
    // Start is called before the first frame update
    void Upddde()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x,0,0f);
        if (Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody>().AddForce(transform.up);
        }
    }
    void Start(){
        while (true){
            
        }
    }
}
