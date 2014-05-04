function Module_Player_Mount::Skill_Rifle(%this,%Sprite_Player)
{

if (%Sprite_Player==Module_Gameplay.Sprite_Player)
{

%Sprite_Target=Module_Gameplay.Sprite_AI;

}
else
{

%Sprite_Target=Module_Gameplay.Sprite_Player;

}

if (%Sprite_Target.Bool_Spotted&&!%Sprite_Target.Bool_Stealthed)//Need the stealth check because there's a bug somewhere, maybe with schedule timing.
{

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

%Sprite_Effect_Shuriken=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Rifle_Effect_Size;
Animation="Module_Player_Spook:Animation_Effect_Shuriken";
class="Class_Effect_Shuriken";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Effect_Shuriken);

%Sprite_Projectile=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Projectile_Size;
Image="Module_Player_Mount:Image_Projectile";
class="Class_Projectile";
CollisionCallback="true";

SceneLayer=15;

SceneGroup=25;

Module_ID_Parent=%this;

DefaultDensity=0;

DefaultRestitution=0;

Collision_Shape_Index=-1;

Sprite_Parent=%Sprite_Player;

};

%Sprite_Projectile.setCollisionGroups(0,25,26,30);

%Sprite_Projectile.Collision_Shape_Index=%Sprite_Projectile.createPolygonBoxCollisionShape(%Sprite_Projectile.Size);

%Sprite_Projectile.setCollisionShapeIsSensor(%Sprite_Projectile.Collision_Shape_Index,true);

Scene_Spooks_VS_Mounts.add(%Sprite_Projectile);

%Sprite_Projectile.Angle=Vector2AngleToPoint(%Sprite_Player.Position,%Sprite_Target.Position);

%Sprite_Projectile.moveTo(%Sprite_Target.Position,100,false,false);

}

}
