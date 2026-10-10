using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToMainScene : MonoBehaviour
{
    public void ChangeIntoMainScene()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
