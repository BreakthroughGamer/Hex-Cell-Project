using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCell : MonoBehaviour
{
    public HexCoordinates coordinates;

    public Color color;

    [SerializeField]
    HexCell[] neighbours;

    public HexCell GetNeigbour(HexDirection direction)
    {
        return neighbours[(int)direction];
    }

    public HexCell SetNeighbour(HexDirection direction, HexCell cell)
    {
        neighbours[(int)direction] = cell;
        cell.neighbours[(int)direction.Opposite()] = this;
    }

}
