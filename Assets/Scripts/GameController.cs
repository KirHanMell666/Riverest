using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public MatsController matsController;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
