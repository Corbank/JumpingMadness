using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton pattern
    public static GameManager Instance { get; private set; }

    [Header("Game Objects")]
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform playerSpawnPoint;
    [SerializeField] private Transform[] enemySpawnPoints;
    
    private void Awake()
    {
        // Singleton pattern setup
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        InitializeGame();
    }
    
    private void InitializeGame()
    {
        // Spawn player
        if (playerPrefab != null && playerSpawnPoint != null)
        {
            Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity);
        }
        
        // Spawn enemies
        if (enemyPrefab != null && enemySpawnPoints.Length > 0)
        {
            foreach (var spawnPoint in enemySpawnPoints)
            {
                Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            }
        }
    }

    public void RestartGame()
    {
        // Add restart logic here
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex
        );
    }
}
