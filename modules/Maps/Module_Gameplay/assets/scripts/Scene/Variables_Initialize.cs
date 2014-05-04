function Module_Gameplay::Variables_Initialize(%this)
{

%this.Bool_Is_Playing=true;

%this.Script_Object_Input_Controller=0;

%this.Vector_2D_Camera_Size=Window_Spooks_VS_Mounts.getCameraSize();

%this.Vector_2D_Background_Grid_Size="2 2";

%this.Vector_2D_World_Limits=
%this.Vector_2D_Background_Grid_Size.X*%this.Vector_2D_Camera_Size.X
SPC
%this.Vector_2D_Background_Grid_Size.Y*%this.Vector_2D_Camera_Size.Y;

%this.Vector_2D_Floor_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Floor_Tile);

%this.SimSet_World_Tile_Slots=new SimSet();

for (%y=0;%y<%this.Vector_2D_World_Limits.Y;%y+=%this.Vector_2D_Floor_Size.Y)
{

for (%x=0;%x<%this.Vector_2D_World_Limits.X;%x+=%this.Vector_2D_Floor_Size.X)
{

%ScriptObject_Tile_Slot=new ScriptObject()
{

Vector_2D_Position=
(%x-%Vector_2D_Grid_Half_Offset.X)+(%this.Vector_2D_Floor_Size.X*0.5)
SPC
(%y-%Vector_2D_Grid_Half_Offset.Y)+(%this.Vector_2D_Floor_Size.Y*0.5);

};

%this.SimSet_World_Tile_Slots.add(%ScriptObject_Tile_Slot);

}

}

%this.Schedule_Visibility_Ray=0;

%this.Float_Visibility_Ray_Distance=(Vector2Distance("0 0",Window_Spooks_VS_Mounts.getCameraSize()))/2;

%this.Main_Menu_Schedule=0;

%this.Module_ID_Player=0;

%this.Sprite_Player=0;

%this.Module_ID_AI=0;

%this.Sprite_AI=0;

%this.Float_AI_Speed=10;

%this.Schedule_AI=0;

%this.Vector_2D_Projectile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Flame);

%this.Float_Projectile_Speed=11;

%this.Vector_2D_Explosion_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Explosion);

%this.Sprite_Computer_Objective=0;

%this.Int_Spook_Score=0;

%this.Int_Mount_Score=0;

/*************************************************************************************/

}
