function Module_Player_Mount::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Male_Sprite_2.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Health_Bar.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Health_Progress.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Icon_Mine.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Icon_Radiation.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Icon_Recharge.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Icon_Rifle.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Icon_Shield.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Radiation.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Mine.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Projectile.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Explosion.getAssetId());

}
