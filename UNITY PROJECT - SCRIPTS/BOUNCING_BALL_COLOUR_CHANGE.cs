public class BOUNCING_BALL_COLOUR_CHANGE : MonoBehaviour
{
    private Rigidbody rb;
    private Renderer renderer;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();
        rb.AddForce(new Vector3(0, 5f, 0), ForceMode.Impulse); // Add an initial upward force
    }

    private void OnCollisionEnter(Collision collision)
    {
        ChangeColor(); // Change color when the ball collides with any other object
    }

    private void ChangeColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        renderer.material.color = randomColor;
    }
}