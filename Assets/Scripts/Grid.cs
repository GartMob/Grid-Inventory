using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    [SerializeField] private float xSize = 1f;
    [SerializeField] private float ySize = 1f;
    [SerializeField] private float zSize = 0f;

    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;

        int xCount = Mathf.RoundToInt(position.x / xSize);
        int yCount = Mathf.RoundToInt(position.y / ySize);
        int zCount = Mathf.RoundToInt(position.z / zSize);

        Vector3 result = new Vector3(
            (float)xCount * xSize,
            (float)yCount * ySize,
            (float)zCount * zSize);

        result += transform.position;

        return result;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        for (float x = 0; x < 40; x += xSize)
        {
            for(float y = 0; y < 40; y += ySize)
            {
                var point = GetNearestPointOnGrid(new Vector3(x, y, 0f));
                Gizmos.DrawSphere(point, 0.1f);
            }
        }
    }
}
