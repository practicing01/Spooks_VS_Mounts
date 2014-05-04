function Module_Player_Spook::Skill_Melee(%this,%Sprite_Player)
{

%Sprite_Melee=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Melee_Effect_Size;
Animation="Module_Player_Spook:Animation_Melee";
class="Class_Melee";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Melee);

%String_Objects=Scene_Spooks_VS_Mounts.pickCircle(%Sprite_Player.Position,%Sprite_Player.Size.Y*1.5,bit(0),"","collision");

for (%x=0;%x<getWordCount(%String_Objects);%x++)
{

%Sprite_Target=getWord(%String_Objects,%x);

if ((%Sprite_Player!=%Sprite_Target)&&%Sprite_Target.Bool_Spotted)
{

%Sprite_Target.Update_Health(10,-1);

if (%Sprite_Player.Bool_Stealthed)
{

%Sprite_Player.Bool_Stealthed=false;

%Sprite_Player.setBlendColor(1,1,1,1);

}

}

}

}
