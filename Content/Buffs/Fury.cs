using HellPlus.Content.Items.Accessories;
using System.Numerics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace HellPlus.Content.Buffs
{
    public class Fury : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
           // player.GetModPlayer<FuryPlayer>().spawnRateMultiplier = 30f;
        }
    }

    /*public class FuryPlayer : ModPlayer
    {
        public float spawnRateMultiplier = 1f;

        public override void ResetEffects()
        {
            spawnRateMultiplier = 1f; // Reset multiplier when the buff is not active
        }
        public override void UpdateBiomeVisuals()
        {
            // Multiply the spawn rates when the buff is active
            if (spawnRateMultiplier > 1f)
            {
                // Triple the spawn rate and maximum spawn limit
                player.ZoneRateModifier *= spawnRateMultiplier;
                player.MaxSpawnLimit = (int)(player.MaxSpawnLimit * spawnRateMultiplier);
            }
        }
    }*/
}