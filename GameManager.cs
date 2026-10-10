using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int increment = 1;
    public int currentAmountOfPoints = 0;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        
        Destroy(gameObject);
    }
}