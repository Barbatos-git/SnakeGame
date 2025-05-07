using UnityEngine;

public class MapBoundsManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Head"))
        {
            SnakeGameManager.Instance.OnPlayerDied();
        }
    }
}
