using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget; // точка, куда нужно телепортироваться

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // если игрок касается объекта, на котором находится скрипт
        {
            other.gameObject.transform.position = teleportTarget.position; // телепортируем игрока к указанной точке
        }
    }
}
