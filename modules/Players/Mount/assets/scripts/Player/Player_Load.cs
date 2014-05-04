exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Player_Initialize.cs");

function Module_Player_Mount::Player_Load(%this)
{

%this.Ass_Load();

%this.Variables_Initialize();

%this.Player_Initialize();

}
