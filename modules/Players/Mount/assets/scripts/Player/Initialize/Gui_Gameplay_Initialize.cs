function Module_Player_Mount::Gui_Gameplay_Initialize(%this)
{

//Health bar.

%this.GuiSpriteCtrl_Health_Bar=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="128 24";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 0","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Mount:Image_Health_Bar";

Module_ID_Parent=%this;

GuiSpriteCtrl_Health_Progress=0;

};

%this.GuiSpriteCtrl_Health_Bar.GuiSpriteCtrl_Health_Progress=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="120 12";

Position="4 6";

Profile="GuiDefaultProfile";

Image="Module_Player_Mount:Image_Health_Progress";

Module_ID_Parent=%this;

Vector_2D_Size="120 12";

};

%this.GuiSpriteCtrl_Health_Bar.addGuiControl(%this.GuiSpriteCtrl_Health_Bar.GuiSpriteCtrl_Health_Progress);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Health_Bar);

/********************************************************************************************************************/

//Recharge icon.

%this.GuiSpriteCtrl_Icon_Recharge=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("184 416","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Mount:Image_Icon_Recharge";

Module_ID_Parent=%this;

GuiButtonCtrl_Icon_Recharge=0;

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_GuiButtonCtrl_Skill";

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position="0 0";

Profile="GuiTransparentProfile";

Module_ID_Parent=%this;

String_Skill="Recharge";

};

%this.GuiSpriteCtrl_Icon_Recharge.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Icon_Recharge);

/********************************************************************************************************************/

//Radiation icon.

%this.GuiSpriteCtrl_Icon_Radiation=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("552 416","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Mount:Image_Icon_Radiation";

Module_ID_Parent=%this;

GuiButtonCtrl_Icon_Radiation=0;

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_GuiButtonCtrl_Skill";

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position="0 0";

Profile="GuiTransparentProfile";

Module_ID_Parent=%this;

String_Skill="Radiation";

};

%this.GuiSpriteCtrl_Icon_Radiation.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Icon_Radiation);

/********************************************************************************************************************/

//Mine icon.

%this.GuiSpriteCtrl_Icon_Mine=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("736 416","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Mount:Image_Icon_Mine";

Module_ID_Parent=%this;

GuiButtonCtrl_Icon_Mine=0;

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_GuiButtonCtrl_Skill";

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position="0 0";

Profile="GuiTransparentProfile";

Module_ID_Parent=%this;

String_Skill="Mine";

};

%this.GuiSpriteCtrl_Icon_Mine.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Icon_Mine);

/********************************************************************************************************************/

//Shield icon.

%this.GuiSpriteCtrl_Icon_Shield=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 416","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Mount:Image_Icon_Shield";

Module_ID_Parent=%this;

GuiButtonCtrl_Icon_Shield=0;

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_GuiButtonCtrl_Skill";

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position="0 0";

Profile="GuiTransparentProfile";

Module_ID_Parent=%this;

String_Skill="Shield";

};

%this.GuiSpriteCtrl_Icon_Shield.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Icon_Shield);

/********************************************************************************************************************/

//Rifle icon.

%this.GuiSpriteCtrl_Icon_Rifle=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("368 416","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Mount:Image_Icon_Rifle";

Module_ID_Parent=%this;

GuiButtonCtrl_Icon_Rifle=0;

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_GuiButtonCtrl_Skill";

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position="0 0";

Profile="GuiTransparentProfile";

Module_ID_Parent=%this;

String_Skill="Rifle";

};

%this.GuiSpriteCtrl_Icon_Rifle.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Icon_Rifle);

/********************************************************************************************************************/

}
