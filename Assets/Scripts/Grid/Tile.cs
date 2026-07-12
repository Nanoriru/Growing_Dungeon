using UnityEngine;

public class Tile : MonoBehaviour
{
    [Header("Tile Information")]
    public int X;
    public int Y;

    public TileType Type = TileType.Floor;

    public bool IsWalkable = true;

    public void SetColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }
}