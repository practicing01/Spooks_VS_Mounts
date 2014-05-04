function Module_Player_Mount::Gui_Select_Initialize(%this)
{

%this.GuiSpriteCtrl_Mount=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

//Extent="32 48";

Extent="64 96";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("400 240","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Animation="Module_Player_Mount:Animation_Male_Sprite_2_Run_Down";

Module_ID_Parent=%this;

};

%this.GuiSpriteCtrl_Mount.Position.Y-=%this.GuiSpriteCtrl_Mount.Extent.Y*0.5;

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_GuiButtonCtrl_Character_Button";

HorizSizing="relative";

VertSizing="relative";

//Extent="32 48";

Extent="64 96";

Position="0 0";

Profile="GuiTransparentProfile";

Module_ID_Parent=%this;

Char_Type=1;//Mount

};

%this.GuiSpriteCtrl_Mount.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Mount);

}
