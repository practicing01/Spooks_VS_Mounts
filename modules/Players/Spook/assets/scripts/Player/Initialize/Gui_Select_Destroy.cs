function Module_Player_Spook::Gui_Select_Destroy(%this)
{

if (%this.GuiSpriteCtrl_Spook!=0)
{

%this.GuiSpriteCtrl_Spook.deleteObjects();

%this.GuiSpriteCtrl_Spook.delete();

%this.GuiSpriteCtrl_Spook=0;

}

}
