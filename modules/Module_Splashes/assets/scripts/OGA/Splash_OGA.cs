function Splashes::Splash_OGA(%this)
{

Scene_Spooks_VS_Mounts.clear();

alxPlay("Splashes:Audio_Splash_OGA");

%Sprite_Splash_OGA=new Sprite()
{

Position="0 0";

Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Splash_OGA);

Image="Splashes:Image_Splash_OGA";

Animation="Splashes:Animation_Splash_OGA";

BodyType="static";

};

Scene_Spooks_VS_Mounts.add(%Sprite_Splash_OGA);

schedule(4000,0,"Splashes::Splash_Logo_Torque",%this);

}
