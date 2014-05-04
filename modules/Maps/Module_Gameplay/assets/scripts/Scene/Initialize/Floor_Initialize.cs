function Module_Gameplay::Floor_Initialize(%this)
{

%SimSet_String_Floor_Tiles=new SimSet();

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Floor_Tile";

};

%SimSet_String_Floor_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Floor_Tile_0";

};

%SimSet_String_Floor_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Gameplay:Image_Floor_Tile_1";

};

%SimSet_String_Floor_Tiles.add(%ScriptObject_String_Floor_Tile);

/**********************************************************************************/

%CompositeSprite_Floor=new CompositeSprite()
{

SceneLayer=30;
BodyType="static";

};

%CompositeSprite_Floor.SetBatchLayout("off");
%CompositeSprite_Floor.SetBatchSortMode("z");
%CompositeSprite_Floor.SetBatchIsolated(true);

%Vector_2D_World_Limits_Half_Offset=
%this.Vector_2D_World_Limits.X*0.5
SPC
%this.Vector_2D_World_Limits.Y*0.5;

for (%y=0;%y<%this.Vector_2D_World_Limits.Y;%y+=%this.Vector_2D_Floor_Size.Y)
{

for (%x=0;%x<%this.Vector_2D_World_Limits.X;%x+=%this.Vector_2D_Floor_Size.X)
{

%ScriptObject_String_Floor_Tile=%SimSet_String_Floor_Tiles.getObject(getRandom(0,%SimSet_String_Floor_Tiles.getCount()-1));

%Vector_2D_Position=
(%x-%Vector_2D_Grid_Half_Offset.X)+(%this.Vector_2D_Floor_Size.X*0.5)
SPC
(%y-%Vector_2D_Grid_Half_Offset.Y)+(%this.Vector_2D_Floor_Size.Y*0.5);

%CompositeSprite_Floor.addSprite();

%CompositeSprite_Floor.setSpriteLocalPosition(%Vector_2D_Position);

%CompositeSprite_Floor.setSpriteSize(%this.Vector_2D_Floor_Size);

%CompositeSprite_Floor.setSpriteImage(%ScriptObject_String_Floor_Tile.String_Name);

}

}

Scene_Spooks_VS_Mounts.add(%CompositeSprite_Floor);

%SimSet_String_Floor_Tiles.deleteObjects();

%SimSet_String_Floor_Tiles.delete();

}
