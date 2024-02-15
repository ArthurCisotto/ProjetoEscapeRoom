using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public List<GameObject> brokenPieces;
    public float timeToBreak = 2;
    private float timeElapsed = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject piece in brokenPieces)
        {
            piece.SetActive(false);
        }
        
    }

    public void Break()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > timeToBreak)
        {
            foreach (GameObject piece in brokenPieces)
            {
                piece.SetActive(true);
                piece.transform.parent = null;
            }
            gameObject.SetActive(false);        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
