using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed =5f;


    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(moveX * speed * Time.deltaTime, moveY * speed * Time.deltaTime, 0);
        
    }
}
