using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteVroumVroum : MonoBehaviour
{
    [SerializeField] Transform[] Points;
    [SerializeField] GameObject prefabVROUMVBROUM;
    [SerializeField] int TauxApparitionVroum;
    public System.Random random = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int index = random.Next(100/TauxApparitionVroum);
        if(index == 1){
            index = random.Next(2);
            if(index==0){
            var vroum = Instantiate(prefabVROUMVBROUM, Points[0].position, Quaternion.identity);
            vroum.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(Points[1].position);
            }
            else{
            var vroum = Instantiate(prefabVROUMVBROUM, Points[2].position, Quaternion.identity);
            vroum.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(Points[3].position);
            }
            
        }
    }
}
