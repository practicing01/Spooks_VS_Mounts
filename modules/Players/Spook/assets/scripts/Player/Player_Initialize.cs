function Module_Player_Spook::Player_Initialize(%this)
{

exec("./Classes/Classes.cs");

exec("./Skills/Skills.cs");

exec("./Initialize/Initialize.cs");

%this.Gui_Select_Initialize();

}
