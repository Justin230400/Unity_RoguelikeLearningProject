using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private float time = 0.1f;
    [SerializeField] private bool isPlayerTrun = true;

    public bool IsPlayerTrun { get => isPlayerTrun; }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }

    private void Start()
    {
        Instantiate(Resources.Load<GameObject>("Player")).name = "Player";
    }

    public void EndTurn()
    {
        isPlayerTrun = false;
        StartCoroutine(WaitForTurn());
    }

    private IEnumerator WaitForTurn()
    {
        yield return new WaitForSeconds(time);
        isPlayerTrun=true;
    }
}
