function Module_Gameplay::Character_Select_Initialize(%this)
{

ModuleDatabase.LoadExplicit("Module_Player_Spook");

Module_Player_Spook.Player_Load();

ModuleDatabase.LoadExplicit("Module_Player_Mount");

Module_Player_Mount.Player_Load();

}
