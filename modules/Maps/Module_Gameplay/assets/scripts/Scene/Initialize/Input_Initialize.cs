function Module_Gameplay::Input_Initialize(%this)
{

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Gameplay_Input_Controller";

Module_ID_Parent=%this;

};

Window_Spooks_VS_Mounts.addInputListener(%this.Script_Object_Input_Controller);

}
