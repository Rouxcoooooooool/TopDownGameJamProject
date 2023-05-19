using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyFieldOfViewHuman : MonoBehaviour
{
    private List<GameObject> Players = new List<GameObject>();
    [SerializeField] float RadiusDetection;

        void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = new Color(0.3f, 0.4f, 0.6f, 0.3f);
        Gizmos.DrawSphere(transform.position, RadiusDetection);
                foreach(GameObject player in Players){
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + (player.transform.position-transform.position)*RadiusDetection);
                }
    }
    // Start is called before the first frame update
    void Start()
    {
        Players = GameManager.Instance.Players;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject player in Players){
            if ((player.transform.position-transform.position).magnitude<RadiusDetection){
                RaycastHit2D hit = Physics2D.Raycast(transform.position, (player.transform.position-transform.position).normalized);
                if (hit.collider != null && hit.collider.transform.parent != null){
                    if(hit.collider.transform.parent.gameObject.tag == "Player"){
                        print("Juif");
                    }
                }
                
            }
        }
    }
}
