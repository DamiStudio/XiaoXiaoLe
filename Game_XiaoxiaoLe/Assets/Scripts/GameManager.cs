using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    //单例
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            return _instance;
        }

        set
        {
            _instance = value;
        }
    }

    public GameObject gridObj;
    public int xColumn;
    public int yRow;

    public GameObject  sweetPrefab;


    private void Awake()
    {
        Instance = this;
    }


    // Use this for initialization
    void Start () {
        
        for (int i = 0; i < xColumn; i++)
        {
            for (int j = 0; j < yRow; j++)
            {
                GameObject newGridObj = Instantiate(gridObj, CorrectPostion(i,j), Quaternion.identity);
                newGridObj.transform.SetParent(this.transform);
               
            }
        }
        for (int i = 0; i < xColumn; i++)
        {
            for (int j = 0; j < yRow; j++)
            {
                GameObject newSweetObj = Instantiate(sweetPrefab, CorrectPostion(i, j), Quaternion.identity);
                newSweetObj.transform.SetParent(this.transform);
              
            }
        }

    }
	
    public Vector3 CorrectPostion(int x,int y)
    {
        return new Vector3(this.transform.position.x - xColumn + x, this.transform.position.y - yRow + y,0);
    }
	
}
