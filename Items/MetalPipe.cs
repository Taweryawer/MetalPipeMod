using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using MetalPipeMod.Projectiles;

namespace MetalPipeMod.Items
{
	public class MetalPipe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("METAL PIPE");
			Tooltip.SetDefault("dedicated to all the heavy metal fans");
		}

		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 10;
			Item.width = 80;
			Item.height = 80;
			Item.useTime = 60;
            Item.shootSpeed = 12f;
            Item.useAnimation = 60;
            Item.useStyle = ItemUseStyleID.Swing;
			Item.noUseGraphic = true;
            Item.knockBack = 20f;
			Item.value = 1;
			Item.rare = ItemRarityID.Master;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<MetalPipeProjectile>();
            Item.noMelee = true;
        }

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup(RecipeGroupID.IronBar, 5);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}