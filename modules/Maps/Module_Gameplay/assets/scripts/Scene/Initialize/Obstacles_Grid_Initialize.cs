function Module_Gameplay::Obstacles_Grid_Initialize(%this)
{

%Int_X_Total=%this.Vector_2D_World_Limits.X/%this.Vector_2D_Floor_Size.X;

%Int_Y_Total=%this.Vector_2D_World_Limits.Y/%this.Vector_2D_Floor_Size.Y;

%Int_X_Counter=0;

%Int_Y_Counter=0;

%SimSet_World_Tile_To_Remove=new SimSet();

/******************************************************************************/

for (%y=0;%y<%this.Vector_2D_World_Limits.Y;%y+=%this.Vector_2D_Floor_Size.Y*2)
{

%Int_X_Counter=0;

for (%x=0;%x<%this.Vector_2D_World_Limits.X;%x+=%this.Vector_2D_Floor_Size.X*2)
{

%Sprite_Obstacle=new Sprite()
{

Position="0 0";
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Crate);
Image="Module_Gameplay:Image_Crate";
class="Class_Crate";
SceneLayer=15;

SceneGroup=26;//Obstacles.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

BodyType="static";

};

%ScriptObject_World_Tile_Slot=%this.SimSet_World_Tile_Slots.getObject((%Int_Y_Counter*%Int_X_Total)+%Int_X_Counter);

%SimSet_World_Tile_To_Remove.add(%ScriptObject_World_Tile_Slot);

%Sprite_Obstacle.Position=%ScriptObject_World_Tile_Slot.Vector_2D_Position;

%Sprite_Obstacle.setCollisionGroups(0,25,26,30);

%Sprite_Obstacle.Collision_Shape_Index=%Sprite_Obstacle.createPolygonBoxCollisionShape(%Sprite_Obstacle.Size);

Scene_Spooks_VS_Mounts.add(%Sprite_Obstacle);

%Int_X_Counter+=2;

}

%Int_Y_Counter+=2;

}

for (%x=0;%x<%SimSet_World_Tile_To_Remove.getCount();%x++)
{

%ScriptObject_World_Tile_To_Remove=%SimSet_World_Tile_To_Remove.getObject(%x);

%this.SimSet_World_Tile_Slots.remove(%ScriptObject_World_Tile_To_Remove);

}

%SimSet_World_Tile_To_Remove.deleteObjects();

%SimSet_World_Tile_To_Remove.delete();

/******************************************************************************/

}
