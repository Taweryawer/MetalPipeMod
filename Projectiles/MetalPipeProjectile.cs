using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;

namespace MetalPipeMod.Projectiles
{
    internal class MetalPipeProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Metal Pipe");
        }

        public override void SetDefaults()
        {
            Projectile.width = 30;
            Projectile.height = 20;
            Projectile.aiStyle = ProjAIStyleID.Boomerang;
            Projectile.friendly = true;
            Projectile.damage = 10;
            Projectile.DamageType = DamageClass.Ranged;
            AIType = ProjectileID.EnchantedBoomerang;
            DrawOffsetX = -7;
            DrawOriginOffsetX = -7;
            DrawOriginOffsetY = -37;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            SoundEngine.PlaySound(new SoundStyle($"{nameof(MetalPipeMod)}/Sounds/MetalPipe"), Projectile.Center);
        }
    }
}
