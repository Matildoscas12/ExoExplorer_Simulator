using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int gridSizeX = 10;
    public int gridSizeY = 10;
    public float cellSize = 1f;

    private void OnDrawGizmos()
    {
        DrawGrid();
    }

    private void DrawGrid()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                Vector3 cellPosition = new Vector3(x * cellSize, 0, y * cellSize);
                Gizmos.DrawWireCube(cellPosition, new Vector3(cellSize, 0.1f, cellSize));
            }
        }
    }
}
