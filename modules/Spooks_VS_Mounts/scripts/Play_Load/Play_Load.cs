function Spooks_VS_Mounts::Play_Load(%this)
{

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Spooks_VS_Mounts_Input_Controller";

};

Window_Spooks_VS_Mounts.addInputListener(%this.Script_Object_Input_Controller);

/*Load splashes*/

ModuleDatabase.LoadExplicit("Splashes");

Splashes.Scene_Load();

}
