function Module_Player_Mount::Skill_Radiation(%this,%Sprite_Player)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Sprite_Player.Position,bit(25),"","collision");

if (getWordCount(%String_Object_List)){return;}

%Sprite_Radiation=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Radiation_Effect_Size;
Animation="Module_Player_Spook:Animation_Charge";
class="Class_Charge";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Radiation);

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

%Sprite_Radiation_Mine=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Radiation_Size;
Image="Module_Player_Mount:Image_Radiation";
class="Class_Radiation_Mine";
CollisionCallback="true";

SceneLayer=17;

SceneGroup=25;

Module_ID_Parent=%this;

DefaultDensity=0;

DefaultRestitution=0;

Collision_Shape_Index=-1;

Sprite_Parent=%Sprite_Player;

Schedule_Radiation=0;

Sprite_Target=0;

LifeTime=60;

};

%Sprite_Radiation_Mine.setCollisionGroups(0,25,26,30);

%Sprite_Radiation_Mine.Collision_Shape_Index=%Sprite_Radiation_Mine.createPolygonBoxCollisionShape(%Sprite_Radiation_Mine.Size.X*6 SPC %Sprite_Radiation_Mine.Size.Y*6);

%Sprite_Radiation_Mine.setCollisionShapeIsSensor(%Sprite_Radiation_Mine.Collision_Shape_Index,true);

Scene_Spooks_VS_Mounts.add(%Sprite_Radiation_Mine);

}
