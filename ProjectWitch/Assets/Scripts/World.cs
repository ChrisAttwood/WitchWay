using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{

    public Dictionary<Vector2Int,Block> Blocks;
    public Block Rock;
    public Block Tree;
    public Block Bad;
    public Block Good;

    public static World instance;


    private void Awake()
    {
        instance = this;
        Blocks = new Dictionary<Vector2Int, Block>();
        int lastSpawnedTree = 0;
        for (int y = -20; y <= 250; y++)
        {
            for (int x = -13; x <= 13; x++)
            {
                lastSpawnedTree++;
                Blocks[new Vector2Int(x, y)] = null;
                if (x == 0 || x <= -10 || x >= 10)
                {
                    AddBlock(new Vector2Int(x, y), Rock);



                }
                else if(y == 250)
                {
                    AddBlock(new Vector2Int(x, y), Bad);
                }
                else
                {
                    if (y > 5)
                    {
                        if (Random.Range(0f, 1f) > 0.9f && lastSpawnedTree>1)
                        {
                            {
                                lastSpawnedTree = 0;
                                AddBlock(new Vector2Int(x, y), Tree);
                            }
                           
                        }
                        else if (Random.Range(0f, 1f) > 0.98f)
                        {
                            AddBlock(new Vector2Int(x, y), Bad);
                        }
                        else if (Random.Range(0f, 1f) > 0.95f)
                        {
                            AddBlock(new Vector2Int(x, y), Good);
                        }
                    }
                }

                
            }

            
        }
    }

    void AddBlock(Vector2Int location,Block block)
    {
        var b = Instantiate(block);
        block.transform.position = new Vector3(location.x,0f,location.y);


        Blocks[location] = b;
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
