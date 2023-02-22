using UnityEngine;

public class LlCcc : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody>().AddForce(transform.up* 500);
        }
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x,0,0f);
        
        
    }
}
