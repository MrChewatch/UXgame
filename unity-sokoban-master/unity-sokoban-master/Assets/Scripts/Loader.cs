using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject gameManager;
    public int lv;

    void Awake()
    {
        if (GameManager.instance == null)
        {
            GameObject manager = Instantiate(gameManager);
            manager.GetComponent<GameManager>().level = lv;
        }
    }
}