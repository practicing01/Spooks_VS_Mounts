function Module_Gameplay::World_Limits_Initialize(%this)
{

/*****************************************************************/

//Top wall.

%SceneObject_Wall=new SceneObject()
{

Position=%this.Vector_2D_World_Limits.X*0.5 SPC %this.Vector_2D_World_Limits.Y+%this.Vector_2D_Floor_Size.Y*0.5;
Size=%this.Vector_2D_World_Limits.X SPC %this.Vector_2D_Floor_Size.Y;
class="Class_Wall";
SceneLayer=30;

SceneGroup=30;//Walls.

BodyType="static";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.setCollisionGroups(0,25,26);

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

Scene_Spooks_VS_Mounts.add(%SceneObject_Wall);

/*****************************************************************/

//Bottom wall.

%SceneObject_Wall=new SceneObject()
{

Position=%this.Vector_2D_World_Limits.X*0.5 SPC 0-%this.Vector_2D_Floor_Size.Y*0.5;
Size=%this.Vector_2D_World_Limits.X SPC %this.Vector_2D_Floor_Size.Y;
class="Class_Wall";
SceneLayer=30;

SceneGroup=30;//Walls.

BodyType="static";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.setCollisionGroups(0,25,26);

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

Scene_Spooks_VS_Mounts.add(%SceneObject_Wall);

/*****************************************************************/

//Left wall.

%SceneObject_Wall=new SceneObject()
{

Position=0-%this.Vector_2D_Floor_Size.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;
Size=%this.Vector_2D_Floor_Size.X SPC %this.Vector_2D_World_Limits.Y;
class="Class_Wall";
SceneLayer=30;

SceneGroup=30;//Walls.

BodyType="static";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.setCollisionGroups(0,25,26);

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

Scene_Spooks_VS_Mounts.add(%SceneObject_Wall);

/*****************************************************************/

//Right wall.

%SceneObject_Wall=new SceneObject()
{

Position=%this.Vector_2D_World_Limits.X+%this.Vector_2D_Floor_Size.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;
Size=%this.Vector_2D_Floor_Size.X SPC %this.Vector_2D_World_Limits.Y;
class="Class_Wall";
SceneLayer=30;

SceneGroup=30;//Walls.

BodyType="static";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%SceneObject_Wall.setCollisionGroups(0,25,26);

%SceneObject_Wall.Collision_Shape_Index=%SceneObject_Wall.createPolygonBoxCollisionShape(%SceneObject_Wall.Size);

Scene_Spooks_VS_Mounts.add(%SceneObject_Wall);

/*****************************************************************/

}
