using UnityEngine;
using UnityEngine.Tilemaps;

public class EndlessPlatformer : MonoBehaviour
{
    public Tilemap tilemap; 
    public TileBase platformTile; 
    public float spawnDistance = 20f; 
    public float tileWidth = 1f; 
    private Transform player;
    private Vector3 lastSpawnPosition;

    void Start()
    {
        player = Camera.main.transform; 
        lastSpawnPosition = player.position;
        SpawnInitialTiles();
    }

    void Update()
    {
        if (player.position.x - lastSpawnPosition.x >= spawnDistance)
        {
            SpawnTile();
            lastSpawnPosition.x += spawnDistance;
        }
    }

    void SpawnInitialTiles()
    {
        for (float x = -10f; x < 10f; x += tileWidth)
        {
            Vector3Int tilePosition = new Vector3Int((int)x, -15, 0);
            tilemap.SetTile(tilePosition, platformTile);
        }
    }

    void SpawnTile()
    {
        Vector3Int tilePosition = new Vector3Int((int)lastSpawnPosition.x, -20, 0);
        tilemap.SetTile(tilePosition, platformTile);
    }
}
