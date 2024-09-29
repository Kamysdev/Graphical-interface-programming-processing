using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clicker_game.Data;

namespace Clicker_game.User
{
    public class CPlayer
    {
        private int lvl;

        private BigNumber gold;

        private BigNumber damage;

        private double damageModifier;

        private BigNumber upgradeCost;

        private double upgradeCostModifier;

        public CPlayer(BigNumber gold, BigNumber damage,
            double damageModifier, BigNumber upgradeCost, double upgradeCostModifier)
        {
            this.gold = gold;
            this.damage = damage;
            this.damageModifier = damageModifier;
            this.upgradeCost = upgradeCost;
            this.upgradeCostModifier = upgradeCostModifier;
        }

        public BigNumber GetGold() { return gold; }

        public BigNumber GetDamage() { return damage; }

        public double GetDamageModifier() { return damageModifier; }

        public bool GainGold(BigNumber gold)
        {
            this.gold.Add(gold);
            return true;
        }
    }
}
