using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;



public class CorridorFirstDungeonGenerator : SimpleRandomWalkDungeonGenerator
{
    [SerializeField]
    private int corridorLength = 14, corridorCount = 5;
    [SerializeField]
    [Range(0.1f,1)]
    private float roomPercent = 0.8f;

    //Key는 방의 중앙, Value들은 방의 타일의 위치
    private Dictionary<Vector2Int, HashSet<Vector2Int>> roomsDictionary = new Dictionary<Vector2Int, HashSet<Vector2Int>>();

    private HashSet<Vector2Int> floorPositions, corridorPositions;

    protected override void RunProceduralGeneration()
    {
        CorridorFirstGeneration();
        
    }

    private void CorridorFirstGeneration()
    {
        floorPositions = new HashSet<Vector2Int>();
        HashSet<Vector2Int> potentialRoomPositions = new HashSet<Vector2Int>();
        corridorPositions = new HashSet<Vector2Int>();

        CreateCorridors(floorPositions, potentialRoomPositions, corridorPositions);

        HashSet<Vector2Int> roomPositions = CreateRooms(potentialRoomPositions);

        List<Vector2Int> deadEnds = FindAllDeadEnds(floorPositions);

        CreateRoomsAtDeadEnd(deadEnds, roomPositions);

        floorPositions.UnionWith(roomPositions);

        tilemapVisualizer.PaintFloorTiles(floorPositions);
        
        //
        tilemapVisualizer.PaintCorridor(corridorPositions);
        //
        WallGenerator.CreateWalls(floorPositions, tilemapVisualizer);
    
    }

    private void CreateRoomsAtDeadEnd(List<Vector2Int> deadEnds, HashSet<Vector2Int> roomFloors)
    {
        foreach (var position in deadEnds)
        {
            if(roomFloors.Contains(position) == false)
            {
                var room = RunRandomWalk(randomWalkParameters, position);
                roomFloors.UnionWith(room);
            }
        }
    }

    private List<Vector2Int> FindAllDeadEnds(HashSet<Vector2Int> floorPositions)
    {
        List<Vector2Int> deadEnds = new List<Vector2Int>();
        foreach (var position in floorPositions)
        {
            int neighboursCount = 0;
            foreach (var direction in Direction2D.cardinalDirectionsList)
            {
                if(floorPositions.Contains(position + direction))
                    neighboursCount++;
                
            }
            if (neighboursCount == 1)
                deadEnds.Add(position);
        }
        return deadEnds;
    }

    private HashSet<Vector2Int> CreateRooms(HashSet<Vector2Int> potentialRoomPositions)
    {
        HashSet<Vector2Int> roomPositions = new HashSet<Vector2Int>();
        int roomToCreateCount = Mathf.RoundToInt(potentialRoomPositions.Count*roomPercent);

        List<Vector2Int> roomsToCreate = potentialRoomPositions.OrderBy(x => Guid.NewGuid()).Take(roomToCreateCount).ToList();
        ClearRoomData();
        foreach (var roomPosition in roomsToCreate)
        {
            var roomFloor = RunRandomWalk(randomWalkParameters, roomPosition);

            SaveRoomData(roomPosition, roomFloor);
            roomPositions.UnionWith(roomFloor);
        }
        return roomPositions;
    }

    private void ClearRoomData()
    {
        roomsDictionary.Clear();
        // roomColors.Clear();
    }

    private void SaveRoomData(Vector2Int roomPosition, HashSet<Vector2Int> roomFloor)
    {
        roomsDictionary[roomPosition] = roomFloor;
        // foreach (var entry in roomsDictionary)
        // {
        //     Vector2Int key = entry.Key;
        //     HashSet<Vector2Int> values = entry.Value;
        //     Debug.Log(key);

        //     foreach (Vector2Int value in values)
        //     {
        //         Debug.Log("Key : " + key + " Value: " + value);
        //     }
        // }
        // roomColors.Add(UnityEngine.Random.ColorHSV());
    }

    private void CreateCorridors(HashSet<Vector2Int> floorPositions, HashSet<Vector2Int> potentialRoomPositions, HashSet<Vector2Int> corridorPositions)
    {
        var currentPosition = startPosition;
        potentialRoomPositions.Add(currentPosition);
        for (int i = 0; i < corridorCount; i++)
        {
            var corridor = ProceduralGenerationAlgorithms.RandomWalkCorridor(currentPosition, corridorLength);
            currentPosition = corridor[corridor.Count - 1];
            potentialRoomPositions.Add(currentPosition);
            floorPositions.UnionWith(corridor);
            
        }
        corridorPositions = new HashSet<Vector2Int>(floorPositions);
        
    }
}
