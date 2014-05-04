function Module_Player_Spook::Player_Unload(%this)
{

if (isObject(%this.GuiSpriteCtrl_Spook))
{

%this.GuiSpriteCtrl_Spook.deleteObjects();

%this.GuiSpriteCtrl_Spook.delete();

}

if (isObject(%this.GuiSpriteCtrl_Health_Bar))
{

%this.GuiSpriteCtrl_Health_Bar.deleteObjects();

%this.GuiSpriteCtrl_Health_Bar.delete();

}

if (isObject(%this.GuiSpriteCtrl_Icon_Stealth))
{

%this.GuiSpriteCtrl_Icon_Stealth.deleteObjects();

%this.GuiSpriteCtrl_Icon_Stealth.delete();

}

if (isObject(%this.GuiSpriteCtrl_Icon_Bolt))
{

%this.GuiSpriteCtrl_Icon_Bolt.deleteObjects();

%this.GuiSpriteCtrl_Icon_Bolt.delete();

}

if (isObject(%this.GuiSpriteCtrl_Icon_Charge))
{

%this.GuiSpriteCtrl_Icon_Charge.deleteObjects();

%this.GuiSpriteCtrl_Icon_Charge.delete();

}

if (isObject(%this.GuiSpriteCtrl_Icon_Melee))
{

%this.GuiSpriteCtrl_Icon_Melee.deleteObjects();

%this.GuiSpriteCtrl_Icon_Melee.delete();

}

if (isObject(%this.GuiSpriteCtrl_Icon_Shuriken))
{

%this.GuiSpriteCtrl_Icon_Shuriken.deleteObjects();

%this.GuiSpriteCtrl_Icon_Shuriken.delete();

}

%this.Ass_Unload();

}
