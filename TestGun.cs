using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TestMod.Content.Projectiles;

namespace TestMod.Content.Items.Weapons
{
    public class TestGun:ModItem
    {
        public override void SetDefaults()
        {   
            Item.SetWeaponValues(11, 1f);
            Item.noMelee = true;
            Item.width = 54;
            Item.height = 22;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.damage = 1440;
            Item.DefaultToRangedWeapon(ProjectileID.PurificationPowder, AmmoID.Bullet, 5, 16f, true);
            Item.useTime = 1;
            Item.useAnimation = 1;
            Item.shoot = ModContent.ProjectileType<TestProjectile>();
            Item.autoReuse = true;
            Item.knockBack = 4;
            
            

           


        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock, 25)
                .AddTile(TileID.WorkBenches)
                .Register();                
        }
        // following method gives this gun a 38% chance to not consume ammo
        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            return Main.rand.NextFloat() >= 0.38f;
        }


    }
    
}

