namespace JogoDeSexta
{
    public class Level
    {
        int roomNum;
        int diff;
        Enemy[,] roomEnemy;
        public Level(int roomNum, int diff)
        {
            this.roomNum = roomNum;
            this.diff = diff;
            roomEnemy = new Enemy[roomNum,1];
        }
        
    }
}