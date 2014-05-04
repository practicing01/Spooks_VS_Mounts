function Class_Roamer::Move(%this)
{

if (getRandom(0,1))//Move
{

%Vector_2D_World_Position=%this.Position;

%Vector_2D_Pick_Point=%this.Position;

%Vector_2D_Pick_Point.X+=%this.Module_ID_Parent.Vector_2D_Floor_Size.X;

%String_Right_Pick_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Pick_Point,bit(26),"","collision");

%Vector_2D_Pick_Point.X-=%this.Module_ID_Parent.Vector_2D_Floor_Size.X;

%Vector_2D_Pick_Point.Y+=%this.Module_ID_Parent.Vector_2D_Floor_Size.Y;

%String_Up_Pick_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Pick_Point,bit(26),"","collision");

if (!getWordCount(%String_Right_Pick_List)&&!getWordCount(%String_Up_Pick_List))
{

%Char_Random_Direction=getRandom(0,3);

if (%Char_Random_Direction==0)//Up
{

%Vector_2D_World_Position.Y+=%this.Module_ID_Parent.Vector_2D_Floor_Size.Y;

%this.Animation="Module_Gameplay:Animation_Roamer_Up";

%this.Char_Direction=0;

}
else if (%Char_Random_Direction==1)//Down
{

%Vector_2D_World_Position.Y-=%this.Module_ID_Parent.Vector_2D_Floor_Size.Y;

%this.Animation="Module_Gameplay:Animation_Roamer_Down";

%this.Char_Direction=1;

}
else if (%Char_Random_Direction==2)//Left
{

%Vector_2D_World_Position.X-=%this.Module_ID_Parent.Vector_2D_Floor_Size.X;

%this.Animation="Module_Gameplay:Animation_Roamer_Left";

%this.Char_Direction=2;

}
else if (%Char_Random_Direction==3)//Right
{

%Vector_2D_World_Position.X+=%this.Module_ID_Parent.Vector_2D_Floor_Size.X;

%this.Animation="Module_Gameplay:Animation_Roamer_Right";

%this.Char_Direction=3;

}

}
else if (!getWordCount(%String_Right_Pick_List))
{

%Char_Random_Direction=getRandom(0,1);

if (%Char_Random_Direction==0)//Left
{

%Vector_2D_World_Position.X-=%this.Module_ID_Parent.Vector_2D_Floor_Size.X;

%this.Animation="Module_Gameplay:Animation_Roamer_Left";

%this.Char_Direction=2;

}
else if (%Char_Random_Direction==1)//Right
{

%Vector_2D_World_Position.X+=%this.Module_ID_Parent.Vector_2D_Floor_Size.X;

%this.Animation="Module_Gameplay:Animation_Roamer_Right";

%this.Char_Direction=3;

}

}
else
{

%Char_Random_Direction=getRandom(0,1);

if (%Char_Random_Direction==0)//Up
{

%Vector_2D_World_Position.Y+=%this.Module_ID_Parent.Vector_2D_Floor_Size.Y;

%this.Animation="Module_Gameplay:Animation_Roamer_Up";

%this.Char_Direction=0;

}
else if (%Char_Random_Direction==1)//Down
{

%Vector_2D_World_Position.Y-=%this.Module_ID_Parent.Vector_2D_Floor_Size.Y;

%this.Animation="Module_Gameplay:Animation_Roamer_Down";

%this.Char_Direction=1;

}

}

if (%Vector_2D_World_Position.X>%this.Module_ID_Parent.Vector_2D_World_Limits.X||%Vector_2D_World_Position.X<0
||%Vector_2D_World_Position.Y>%this.Module_ID_Parent.Vector_2D_World_Limits.Y||%Vector_2D_World_Position.Y<0)
{

%this.Schedule_Move=schedule(1000,0,"Class_Roamer::Move",%this);

return;

}

%this.moveTo(%Vector_2D_World_Position,10,true,true);

}
else//Shoot
{

%Sprite_Projectile=new Sprite()
{

Position=%this.Position;
Size=%this.Module_ID_Parent.Vector_2D_Projectile_Size;
Animation="Module_Gameplay:Animation_Flame";
class="Class_Flame";
SceneLayer=14;

SceneGroup=25;

Module_ID_Parent=%this.Module_ID_Parent;

Collision_Shape_Index=-1;

CollisionCallback="true";

};

if (%this.Char_Direction==0)
{

%Sprite_Projectile.Angle=90;

}
else if (%this.Char_Direction==1)
{

%Sprite_Projectile.Angle=-90;

}
else if (%this.Char_Direction==2)
{

%Sprite_Projectile.Angle=180;

}

%Sprite_Projectile.setCollisionGroups(0,25,26,30);

%Sprite_Projectile.Collision_Shape_Index=%Sprite_Projectile.createPolygonBoxCollisionShape(%Sprite_Projectile.Size);

%Sprite_Projectile.setCollisionShapeIsSensor(%Sprite_Projectile.Collision_Shape_Index,true);

Scene_Spooks_VS_Mounts.add(%Sprite_Projectile);

%Sprite_Projectile.setLinearVelocityPolar(%Sprite_Projectile.Angle,10);

}

%this.Schedule_Move=schedule(1000,0,"Class_Roamer::Move",%this);

}
