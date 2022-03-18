using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public List<Block> block_PF;
    List<Block> blocks = new List<Block>();
    int blockDestuction;
    public int cols;
    public int filas;

    public void Awake()
    {
        cols = 11;
        filas = 10;

        var block_SIze = block_PF[0].GetComponent<BoxCollider2D>().size;
        var inicio = new Vector3(block_SIze.x * -(cols / 2), -1, 0);
        float padding = 0.06f;
        block_SIze += new Vector2(padding, padding);

        for(int fila =0; fila < filas; fila++)
        {
            for(int col=0; col < cols; col++)
            {
                int color = fila / 2;
                var bloque = Instantiate(block_PF[color]);
                bloque.transform.SetParent(transform);
                bloque.transform.position = new Vector3(col * block_SIze.x, fila * block_SIze.y, 0) + inicio;
                blocks.Add(bloque);     
            }
        }
    }

    public void BloquesFinish()
    {
        blockDestuction++;
        if (blockDestuction == blocks.Count)
        {
            FindObjectOfType<Pad>().Reset();
            FindObjectOfType<Ball>().Reset();
            Reset();
        }
    }

    public void Reset()
    {
        foreach(var bloque in blocks)
        {
            bloque.Reset();
        }
    }
}
