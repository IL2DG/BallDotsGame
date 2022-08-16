using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public GameObject point;
    public LineRenderer lr;
    public GameObject win;
    [SerializeField]private List<Transform> points;

    private void Start() {
        points.Add(player.transform);
    }

    private void Update() {
        if(!GameObject.Find("Coin")){
            win.SetActive(true);
        }
        
        if(Input.GetMouseButtonDown(0)){
            GameObject pointGO = Instantiate(point, Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward, Quaternion.identity);
            points.Add(pointGO.transform);
            lr.positionCount = points.Count;
        }
        if(points.Count > 1 && points[1] == null){
            points.RemoveAt(1);
        }
        for(int i = 0; i < points.Count; i++){
            lr.SetPosition(i, points[i].position);
        }

        if(points.Count > 1){
            player.transform.position = Vector3.Lerp(player.transform.position, points[1].position, speed * 0.001f);
        }
        
    }


}
