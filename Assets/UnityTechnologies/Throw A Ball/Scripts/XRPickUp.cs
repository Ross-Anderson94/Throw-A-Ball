using UnityEngine;
using UnityEngine.UI;

public class XRPickUp : MonoBehaviour {
    
    // Public variables
    public float speed; 
    public Text countText;
    public Text winText;

    // Private variables
    private Rigidbody rb;
    private int count;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate ()
    {

    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 4) 
        {
            winText.text = "You Win!";
        }
    }
}
