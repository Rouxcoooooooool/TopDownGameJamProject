using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int NombreJoueurs;
    public static GameManager Instance;
    public List<GameObject> SpawnPoints = new List<GameObject>();
    public List<GameObject> Players = new List<GameObject>();
    void Awake()
    {
        if (Instance == null){
            Instance = this;
        }
        foreach(GameObject point in GameObject.FindGameObjectsWithTag("Respawn")){
        SpawnPoints.Add(point); 
        }

    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        Players.Clear();
        foreach(GameObject player in GameObject.FindGameObjectsWithTag("Player")){
        Players.Add(player); 
        }
    }
}