function Module_Player_Spook::Skill_Shuriken(%this,%Sprite_Player)
{

if (%Sprite_Player==Module_Gameplay.Sprite_Player)
{

%Sprite_Target=Module_Gameplay.Sprite_AI;

}
else
{

%Sprite_Target=Module_Gameplay.Sprite_Player;

}

if (%Sprite_Target.Bool_Spotted)
{

if (%Sprite_Player.Bool_Stealthed)
{

%Sprite_Player.Bool_Stealthed=false;

%Sprite_Player.setBlendColor(1,1,1,1);

}

%Sprite_Effect_Shuriken=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Shuriken_Effect_Size;
Animation="Module_Player_Spook:Animation_Effect_Shuriken";
class="Class_Effect_Shuriken";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Effect_Shuriken);

%Sprite_Shuriken=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Shuriken_Size;
Image="Module_Player_Spook:Image_Shuriken";
class="Class_Shuriken";
CollisionCallback="true";

SceneLayer=15;

SceneGroup=25;

Module_ID_Parent=%this;

DefaultDensity=0;

DefaultRestitution=0;

AngularVelocity=1080;

Collision_Shape_Index=-1;

Sprite_Parent=%Sprite_Player;

};

%Sprite_Shuriken.setCollisionGroups(0,25,26,30);

%Sprite_Shuriken.Collision_Shape_Index=%Sprite_Shuriken.createPolygonBoxCollisionShape(%Sprite_Shuriken.Size);

%Sprite_Shuriken.setCollisionShapeIsSensor(%Sprite_Shuriken.Collision_Shape_Index,true);

Scene_Spooks_VS_Mounts.add(%Sprite_Shuriken);

%Sprite_Shuriken.moveTo(%Sprite_Target.Position,100,false,false);

}

}
