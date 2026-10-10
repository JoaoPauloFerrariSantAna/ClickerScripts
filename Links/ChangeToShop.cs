using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToShop : MonoBehaviour
{
    public void ChangeIntoShop()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
