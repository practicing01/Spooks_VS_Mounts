function Module_Player_Mount::Player_Unload(%this)
{

if (isObject(%this.GuiSpriteCtrl_Mount))
{

%this.GuiSpriteCtrl_Mount.deleteObjects();

%this.GuiSpriteCtrl_Mount.delete();

}

if (isObject(%this.GuiSpriteCtrl_Health_Bar))
{

%this.GuiSpriteCtrl_Health_Bar.deleteObjects();

%this.GuiSpriteCtrl_Health_Bar.delete();

}

if (isObject(%this.GuiSpriteCtrl_Icon_Recharge))
{

%this.GuiSpriteCtrl_Icon_Recharge.deleteObjects();

%this.GuiSpriteCtrl_Icon_Recharge.delete();

}

if (isObject(%this.GuiSpriteCtrl_Icon_Radiation))
{

%this.GuiSpriteCtrl_Icon_Radiation.deleteObjects();

%this.GuiSpriteCtrl_Icon_Radiation.delete();

}

if (isObject(%this.GuiSpriteCtrl_Icon_Mine))
{

%this.GuiSpriteCtrl_Icon_Mine.deleteObjects();

%this.GuiSpriteCtrl_Icon_Mine.delete();

}

if (isObject(%this.GuiSpriteCtrl_Icon_Shield))
{

%this.GuiSpriteCtrl_Icon_Shield.deleteObjects();

%this.GuiSpriteCtrl_Icon_Shield.delete();

}

if (isObject(%this.GuiSpriteCtrl_Icon_Rifle))
{

%this.GuiSpriteCtrl_Icon_Rifle.deleteObjects();

%this.GuiSpriteCtrl_Icon_Rifle.delete();

}

%this.Ass_Unload();

}
