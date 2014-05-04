function Module_Gameplay::Computer_Objective_Initialize(%this)
{

%ScriptObject_World_Tile_Slot=%this.SimSet_World_Tile_Slots.getObject(getRandom(0,%this.SimSet_World_Tile_Slots.getCount()-1));

%Sprite_Computer=new Sprite()
{

Position="0 0";
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Computer);
Image="Module_Gameplay:Image_Computer";
class="Class_Computer";
SceneLayer=15;

SceneGroup=30;

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

BodyType="static";

GuiSpriteCtrl_Computer_Progress_Bar=0;

Int_Progress=0;

Schedule_Progress=0;

};

%Sprite_Computer.setCollisionGroups(0,25,26,30);

%Sprite_Computer.Collision_Shape_Index=%Sprite_Computer.createPolygonBoxCollisionShape(%Sprite_Computer.Size.X*2 SPC %Sprite_Computer.Size.Y*2);

%Sprite_Computer.setCollisionShapeIsSensor(%Sprite_Computer.Collision_Shape_Index,true);

Scene_Spooks_VS_Mounts.add(%Sprite_Computer);

%Sprite_Computer.Position=%ScriptObject_World_Tile_Slot.Vector_2D_Position;

%this.SimSet_World_Tile_Slots.remove(%ScriptObject_World_Tile_Slot);

%ScriptObject_World_Tile_Slot.delete();

%this.Sprite_Computer_Objective=%Sprite_Computer;

/********************************************************************************************************************/

//Progress bar.

%Sprite_Computer.GuiSpriteCtrl_Computer_Progress_Bar=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 12";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 0","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Spook:Image_Health_Bar";

Module_ID_Parent=%this;

GuiSpriteCtrl_Computer_Progress=0;

};

%Sprite_Computer.GuiSpriteCtrl_Computer_Progress_Bar.GuiSpriteCtrl_Computer_Progress=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

MinExtent="0 0";

Extent="0 6";

Position="2 3";

Profile="GuiDefaultProfile";

Image="Module_Gameplay:Image_Health_Progress";

Module_ID_Parent=%this;

Vector_2D_Size="60 6";

};

%Sprite_Computer.GuiSpriteCtrl_Computer_Progress_Bar.addGuiControl(%Sprite_Computer.GuiSpriteCtrl_Computer_Progress_Bar.GuiSpriteCtrl_Computer_Progress);

%Sprite_Computer.attachGui(%Sprite_Computer.GuiSpriteCtrl_Computer_Progress_Bar,Window_Spooks_VS_Mounts,false,"0" SPC -(%Sprite_Computer.Size.Y+%Sprite_Computer.GuiSpriteCtrl_Computer_Progress_Bar.Extent.Y)*2);

/********************************************************************************************************************/

}
