function Module_Gui_Main_Menu::create(%this)
{

exec("./assets/scripts/Scene/Scene_Load.cs");

exec("./assets/scripts/Scene/Scene_Unload.cs");

}

function Module_Gui_Main_Menu::destroy(%this)
{

%this.Scene_Unload();

if (isObject(%this.Scene_Current))
{

%this.Scene_Current.delete();

}

Scene_Create_Spooks_VS_Mounts();

}
