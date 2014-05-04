function Module_Player_Spook::create(%this)
{

exec("./assets/scripts/Player/Player_Load.cs");

exec("./assets/scripts/Player/Player_Unload.cs");

}

function Module_Player_Spook::destroy(%this)
{

%this.Player_Unload();

}
