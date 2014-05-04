/*Pause menu needs to be remade into its own module.*/

if (!isObject(Gui_Pause_Menu))
{

Spooks_VS_Mounts.add(TamlRead("./Gui_Pause_Menu.gui.taml"));

}

exec("./Buttons/Go_Main_Menu.cs");

function Spooks_VS_Mounts::Toggle_Pause_Menu(%this)
{

if ($Bool_Is_Playing)
{

if (!Gui_Pause_Menu.isAwake())
{

Canvas.pushDialog(Gui_Pause_Menu);

}
else
{

Canvas.popDialog(Gui_Pause_Menu);

}

}

}

GlobalActionMap.bindCmd(keyboard,"escape","Spooks_VS_Mounts.Toggle_Pause_Menu();","");
