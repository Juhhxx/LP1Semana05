namespace JogoDeSexta
{
    public class Level
    {
        int roomNum;
        int diff;
        static int enemyCount;
        Enemy[,] roomEnemy;
        public Level(int roomNum, int diff)
        {
            this.roomNum = roomNum;
            this.diff = diff;
            roomEnemy = new Enemy[roomNum,1];
        }
        static Level()
        {
            enemyCount = 0;
        }
        public int GetToughness()
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
    }
}