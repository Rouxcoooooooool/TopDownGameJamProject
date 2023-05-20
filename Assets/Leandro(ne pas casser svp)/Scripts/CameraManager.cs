using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] float Dezoom;
    [SerializeField] CinemachineVirtualCamera vcam;
     private List<GameObject> Players = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	void Update()
	{
        Players = GameManager.Instance.Players;
		if(Players.Count == 0)
			return;
		
		Vector3 sum = Vector3.zero;
		foreach(GameObject player in Players){
			sum += player.transform.position;			
		}
		Vector3 barycenter = sum / Players.Count;
		barycenter.z = 0;
		
		transform.position = barycenter;
        float farthestFromBary = (barycenter -Players[0].transform.position).magnitude;
        foreach(GameObject player in Players){
            if((barycenter-player.transform.position).magnitude>farthestFromBary){
                farthestFromBary = (barycenter-player.transform.position).magnitude;
            }
        }
        vcam.m_Lens.OrthographicSize = farthestFromBary*Dezoom+3;
	}
}
