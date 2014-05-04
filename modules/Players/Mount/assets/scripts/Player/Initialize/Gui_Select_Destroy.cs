function Module_Player_Mount::Gui_Select_Destroy(%this)
{

if (%this.GuiSpriteCtrl_Mount!=0)
{

%this.GuiSpriteCtrl_Mount.deleteObjects();

%this.GuiSpriteCtrl_Mount.delete();

%this.GuiSpriteCtrl_Mount=0;

}

}
