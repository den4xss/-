using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Transform spawnPoint; // точка появления игрока
    public string sceneName; // название сцены для перехода

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // если игрок попал в зону ловушки
        {
            SceneManager.LoadScene(sceneName); // загружаем новую сцену
            other.transform.position = spawnPoint.position; // отправляем игрока на точку появления
        }
    }
}