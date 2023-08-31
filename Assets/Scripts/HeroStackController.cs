using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();
    public GameObject lastBlockObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseBlockStack(GameObject block)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        block.transform.position = new Vector3(
            lastBlockObject.transform.position.x,
            lastBlockObject.transform.position.y - 2f,
            lastBlockObject.transform.position.z);
        block.transform.SetParent(transform);
        blockList.Add(block);
        UpdateLastBlockObject();
    }
    public void DecreaseBlock(GameObject gameObject)
    {
        gameObject.transform.parent = null;
        blockList.Remove(gameObject);
        UpdateLastBlockObject();
    }
    private void UpdateLastBlockObject()
    {
        lastBlockObject = blockList[blockList.Count - 1];
    }
}
