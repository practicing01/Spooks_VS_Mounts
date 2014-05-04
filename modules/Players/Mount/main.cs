function Module_Player_Mount::create(%this)
{

exec("./assets/scripts/Player/Player_Load.cs");

exec("./assets/scripts/Player/Player_Unload.cs");

}

function Module_Player_Mount::destroy(%this)
{

%this.Player_Unload();

}
