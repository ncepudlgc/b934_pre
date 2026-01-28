using HellPlus.Content.Items.Placeable;
using HellPlus.Content.Rarities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellPlus.Content.Items.Weapons
{
	public class Magmaul : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.autoReuse = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 200;
			Item.knockBack = 8f;

			Item.rare = ModContent.RarityType<HellRarity>();
			Item.UseSound = SoundID.Item1;
			ItemID.Sets.IsLavaImmuneRegardlessOfRarity[Item.type] = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddIngredient(ModContent.ItemType<MagmiumBar>(), 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}
