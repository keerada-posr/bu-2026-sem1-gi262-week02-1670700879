using System;
using UnityEngine;

namespace Workshop.Student
{
    public class MapGenerator : MonoBehaviour
    {
        public int columns = 10;
        public int rows = 10;

        public GameObject[] floorTiles;
        public GameObject[] wallTiles;
        public GameObject[] foodTiles;

        public string[,] saveItemMap = new string[3, 3] {
            { " ", "Soda", " "},
            { " ", " ", " "},
            { " ", " ", "Food"},
        };

        // 1. declare Players variable

        // 7. declare Exit variable 


        public void Start()
        {
            // 1. random player at the position <0, 0> map

            // 2. create obstacles

            // 3. create floor
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    int r = UnityEngine.Random.Range(0, floorTiles.Length);
                    GameObject tile = Instantiate(floorTiles[r], new Vector2(x, y), Quaternion.identity);
                    tile.name = "Floor " + x + "_" + y;
                }
            }

            // 4. create walls
            for (int y = -1; y < rows+1; y++)
            {
                for (int x = -1; x < columns+1; y++)
                {
                    if (x == -1 || y == -1 || x == rows || y == columns)
                    {
                        int r = UnityEngine.Random.Range(0, wallTiles.Length);
                        GameObject tile = Instantiate(wallTiles[r], new Vector2(x, y), Quaternion.identity);
                        tile.name = "wall " + x + "_" + y;
                    }
                }
            }

            // 5. random foods

            // 6. generate item along with the saveItemMap

            // 7. place exit

        }
    }

}