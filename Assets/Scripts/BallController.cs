using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    public Text countText;
    public float speed;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "count:" + count.ToString();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PICKUP"))
        {
            other.gameObject.SetActive(false);
            count++;
            countText.text = "count:" + count.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
