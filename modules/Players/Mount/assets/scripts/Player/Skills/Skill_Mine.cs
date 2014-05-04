function Module_Player_Mount::Skill_Mine(%this,%Sprite_Player)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickCircle(%Sprite_Player.Position,%Sprite_Player.Size.Y,bit(25),"","collision");

if (getWordCount(%String_Object_List)){return;}

%Sprite_Mine=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Mine_Effect_Size;
Animation="Module_Player_Spook:Animation_Melee";
class="Class_Melee";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Mine);

if (%Sprite_Player.Bool_Shielded)
{

%Sprite_Player.Bool_Shielded=false;

%Sprite_Player.setBlendColor(1,1,1,1);

}

if (%Sprite_Player.Bool_Recharging)
{

%Sprite_Player.Bool_Recharging=false;

cancel(%Sprite_Player.Schedule_Recharge);

}

%Sprite_Mine=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Mine_Size;
Image="Module_Player_Mount:Image_Mine";
class="Class_Mine";
CollisionCallback="true";

SceneLayer=17;

SceneGroup=25;

Module_ID_Parent=%this;

DefaultDensity=0;

DefaultRestitution=0;

Collision_Shape_Index=-1;

Sprite_Parent=%Sprite_Player;

};

%Sprite_Mine.setCollisionGroups(0,25,26,30);

%Sprite_Mine.Collision_Shape_Index=%Sprite_Mine.createPolygonBoxCollisionShape(%Sprite_Mine.Size);

%Sprite_Mine.setCollisionShapeIsSensor(%Sprite_Mine.Collision_Shape_Index,true);

Scene_Spooks_VS_Mounts.add(%Sprite_Mine);

}
