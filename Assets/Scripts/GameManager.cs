using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(Instance);
        }

        Instance = this;
    }
}
