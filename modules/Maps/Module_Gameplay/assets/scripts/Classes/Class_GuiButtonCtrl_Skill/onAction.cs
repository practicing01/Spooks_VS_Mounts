function Class_GuiButtonCtrl_Skill::onAction(%this)
{

if (%this.String_Skill$="Stealth")
{

%this.Module_ID_Parent.Skill_Stealth(Module_Gameplay.Sprite_Player);

}
else if (%this.String_Skill$="Bolt")
{

%this.Module_ID_Parent.Skill_Bolt(Module_Gameplay.Sprite_Player);

}
else if (%this.String_Skill$="Charge")
{

%this.Module_ID_Parent.Skill_Charge(Module_Gameplay.Sprite_Player);

}
else if (%this.String_Skill$="Melee")
{

%this.Module_ID_Parent.Skill_Melee(Module_Gameplay.Sprite_Player);

}
else if (%this.String_Skill$="Shuriken")
{

%this.Module_ID_Parent.Skill_Shuriken(Module_Gameplay.Sprite_Player);

}
else if (%this.String_Skill$="Shield")
{

%this.Module_ID_Parent.Skill_Shield(Module_Gameplay.Sprite_Player);

}
else if (%this.String_Skill$="Recharge")
{

%this.Module_ID_Parent.Skill_Recharge(Module_Gameplay.Sprite_Player);

}
else if (%this.String_Skill$="Mine")
{

%this.Module_ID_Parent.Skill_Mine(Module_Gameplay.Sprite_Player);

}
else if (%this.String_Skill$="Radiation")
{

%this.Module_ID_Parent.Skill_Radiation(Module_Gameplay.Sprite_Player);

}
else if (%this.String_Skill$="Rifle")
{

%this.Module_ID_Parent.Skill_Rifle(Module_Gameplay.Sprite_Player);

}

}
