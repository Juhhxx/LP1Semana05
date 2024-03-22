using System;

namespace JogoDeSexta
{
    public class Level
    {
        int roomNum;
        Toughness diff;
        int enemyCount;
        Enemy[,] roomEnemy;
        public Level(int roomNum, Toughness diff)
        {
            this.roomNum = roomNum;
            this.diff = diff;
            roomEnemy = new Enemy[roomNum,1];
            enemyCount = 0;
        }
        public Toughness GetToughness()
        {
            return diff;
        }
        public int GetNumRooms()
        {
            return roomNum;
        }
        public int GetNumEnemies()
        {
            return enemyCount;
        }
        public void SetEnemyInRoom(int roomIndex, Enemy enemyToPlace)
        {
            roomEnemy[roomIndex,0] = enemyToPlace;
            enemyCount += 1;
        }
        public void PrintEnemies()
        {
            for (int i = 0; i < roomNum; i++)
            {
                if (roomEnemy[i,0] != null)
                {
                    Console.WriteLine($"Room {i}: {roomEnemy[i,0].GetName()}");
                }
            }
        }
    }
}