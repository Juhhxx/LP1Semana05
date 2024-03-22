using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        static private int powerPickedup;
        
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }
        static Enemy()
        {
            powerPickedup = 0;
        }
        public string GetName()
        {
            return name;
        }
        public float GetHealth()
        {
            return health;
        }
        public float GetShield()
        {
            return shield;
        }
        public float GetPowerPickUp()
        {
            return powerPickedup;
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
        public void SetName(string name)
        {
            string newName = "";

            if (name.Length >= 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    newName += name[i];
                }
            }
            else
            {
                newName = name;
            }

            this.name = newName;
        }
        public void PickupPowerUp(PowerUp powerToUpdate,float n)
        {
            if (powerToUpdate == PowerUp.Health)
            {
                this.health += n;
                this.health = MathF.Floor(100);
            }
            else if (powerToUpdate == PowerUp.Shield)
            {
                this.shield += n;
                this.shield = MathF.Floor(100);
            }
            powerPickedup += 1;
        }
    }
}