using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{

    public Dictionary<Vector2Int,Block> Blocks;
    public Block Block;

    public static World instance;


    private void Awake()
    {
        instance = this;
        Blocks = new Dictionary<Vector2Int, Block>();
        for(int x = -10; x <= 10; x++)
        {
            for (int y = -20; y < 250; y++)
            {
                Blocks[new Vector2Int(x, y)] = null;
                if (x == 0 || x == -10 || x == 10)
                {
                    AddBlock(new Vector2Int(x, y));

                   

                }else if (Random.Range(0f, 1f) > 0.9f)
                {
                    AddBlock(new Vector2Int(x, y));
                }
            }

            
        }
    }

    void AddBlock(Vector2Int location)
    {
        var block = Instantiate(Block);
        block.transform.position = new Vector3(location.x,0f,location.y);


        Blocks[location] = block;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
