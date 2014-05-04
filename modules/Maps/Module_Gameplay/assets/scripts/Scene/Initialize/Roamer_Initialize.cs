function Module_Gameplay::Roamer_Initialize(%this)
{

//Roamers clear mines and remove stealth.

for (%x=0;%x<20;%x++)
{

%ScriptObject_World_Tile_Slot=%this.SimSet_World_Tile_Slots.getObject(getRandom(0,%this.SimSet_World_Tile_Slots.getCount()-1));

%Sprite_Roamer=new Sprite()
{

Position="0 0";
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Roamer);
Animation="Module_Gameplay:Animation_Roamer_Down";
class="Class_Roamer";
SceneLayer=14;

SceneGroup=25;

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Schedule_Move=0;

Char_Direction=1;

};

%Sprite_Roamer.setCollisionGroups(0,25,26,30);

%Sprite_Roamer.Collision_Shape_Index=%Sprite_Roamer.createPolygonBoxCollisionShape(%Sprite_Roamer.Size);

%Sprite_Roamer.setCollisionShapeIsSensor(%Sprite_Roamer.Collision_Shape_Index,true);

Scene_Spooks_VS_Mounts.add(%Sprite_Roamer);

%Sprite_Roamer.Position=%ScriptObject_World_Tile_Slot.Vector_2D_Position;

%Sprite_Roamer.Schedule_Move=schedule(1000,0,"Class_Roamer::Move",%Sprite_Roamer);

}

}
