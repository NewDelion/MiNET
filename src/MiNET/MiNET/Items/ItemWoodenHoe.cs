﻿using MiNET.Entities;
using MiNET.Utils;
using MiNET.Worlds;
using MiNET.Blocks;

namespace MiNET.Items
{
    class ItemWoodenHoe : Item
    {
        public ItemWoodenHoe(short metadata)
            : base(290, metadata)
        {
            ItemMaterial = ItemMaterial.Wood;
            ItemType = ItemType.Hoe;
            FuelEfficiency = 10;
        }

        public override void UseItem(Level world, Player player, BlockCoordinates blockCoordinates, BlockFace face, Vector3 faceCoords)
        {
            Block tile = world.GetBlock(blockCoordinates);
            if (tile.Id == 2 || tile.Id == 3)
            {
                FarmLand farm = new FarmLand();
                farm.Coordinates = blockCoordinates;
                farm.Metadata = 0;
                world.SetBlock(farm);
            }
        }
    }
}
