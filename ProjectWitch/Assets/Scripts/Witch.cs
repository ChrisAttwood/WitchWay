using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    float Xvelocity;
    float Yvelocity;
    Vector3Int target;
    Vector3Int current;
    Vector3Int direction;
    bool readyToMove;

    // Start is called before the first frame update
    void Awake()
    {
        target = new Vector3Int((int)transform.position.x, (int)transform.position.y, (int)transform.position.z);
        current = target;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.01f);

        if (Vector3.Distance(transform.position, target) == 0f)
        {
            readyToMove = true;
        }

    }


    public void Move(float Horizontal, float Vertical)
    {
        if (!readyToMove) return;

        current = target;

        readyToMove = false;

        if (Mathf.Abs(Vertical) > Mathf.Abs(Horizontal) && Mathf.Abs(Vertical) >= Yvelocity)
        {
            if (Vertical < 0)
            {
                target.z -= 1;
            }

            if (Vertical > 0)
            {
                target.z += 1;
            }
        }
        if (Mathf.Abs(Horizontal) > Mathf.Abs(Vertical) && Mathf.Abs(Horizontal) >= Xvelocity)
        {

            if (Horizontal < 0)
            {
                target.x -= 1;
            }

            if (Horizontal > 0)
            {
                target.x += 1;
            }
        }

        Yvelocity = Mathf.Abs(Vertical);
        Xvelocity = Mathf.Abs(Horizontal);
        direction = target - current;


        if (!World.instance.Blocks.ContainsKey(new Vector2Int(target.x, target.z)) || (World.instance.Blocks[new Vector2Int(target.x, target.z)] != null  &&  !World.instance.Blocks[new Vector2Int(target.x, target.z)].IsPassable) || Vector3.Distance(transform.position, target) > 1f)
        {
            target = current;


        }


    }

}
