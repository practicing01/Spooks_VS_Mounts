function Module_Gameplay::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Flame.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Explosion.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Floor_Tile.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Floor_Tile_0.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Floor_Tile_1.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Crate.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Computer.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Roamer.getAssetId());

}
