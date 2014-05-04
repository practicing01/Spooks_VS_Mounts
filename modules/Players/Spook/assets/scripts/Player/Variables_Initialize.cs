function Module_Player_Spook::Variables_Initialize(%this)
{

%this.GuiSpriteCtrl_Spook=0;

%this.GuiSpriteCtrl_Health_Bar=0;

%this.GuiSpriteCtrl_Icon_Stealth=0;

%this.Vector_2D_Stealth_Effect_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Stealth);

%this.Vector_2D_Melee_Effect_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Melee);

%this.Vector_2D_Charge_Effect_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Charge);

%this.Vector_2D_Bolt_Effect_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Bolt);

%this.Vector_2D_Shuriken_Effect_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Effect_Shuriken);

%this.Vector_2D_Shuriken_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Shuriken);

}
