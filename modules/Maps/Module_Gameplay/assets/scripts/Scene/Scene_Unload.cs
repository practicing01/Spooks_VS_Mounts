function Module_Gameplay::Scene_Unload(%this)
{

if (isObject(%this.Gui_Text_Score))
{

%this.Gui_Text_Score.delete();

}

cancel(%this.Schedule_Visibility_Ray);

%this.SimSet_World_Tile_Slots.deleteObjects();

%this.SimSet_World_Tile_Slots.delete();

Module_Player_Spook.Player_Unload();

Module_Player_Mount.Player_Unload();

cancel(%this.Schedule_AI);

if (isObject(%this.Script_Object_Input_Controller))
{

Window_Spooks_VS_Mounts.removeInputListener(%this.Script_Object_Input_Controller);

}

%this.Bool_Is_Playing=false;

Canvas.popDialog(Gui_Gameplay);

%this.Ass_Unload();

}
