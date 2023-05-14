using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpForce = 15f; // сила прыжка

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // применяем силу прыжка к игроку
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
