exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Scene_Initialize.cs");
exec("./../Buttons/Buttons.cs");

function Module_Gui_Instructions_Menu::Scene_Load(%this)
{

%this.Ass_Load();

Scene_Spooks_VS_Mounts.clear();

%this.Scene_Current=TamlRead("./../../scenes/Module_Gui_Instructions_Menu.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

if (!isObject(Gui_Instructions_Menu))
{

Spooks_VS_Mounts.add(TamlRead("./../../gui/Gui_Instructions_Menu.gui.taml"));

}

Canvas.pushDialog(Gui_Instructions_Menu);

%this.Variables_Initialize();

%this.Scene_Initialize();

}
