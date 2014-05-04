function Module_Player_Spook::Gui_Gameplay_Initialize(%this)
{

//Health bar.

%this.GuiSpriteCtrl_Health_Bar=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="128 24";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 0","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Spook:Image_Health_Bar";

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

Image="Module_Player_Spook:Image_Health_Progress";

Module_ID_Parent=%this;

Vector_2D_Size="120 12";

};

%this.GuiSpriteCtrl_Health_Bar.addGuiControl(%this.GuiSpriteCtrl_Health_Bar.GuiSpriteCtrl_Health_Progress);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Health_Bar);

/********************************************************************************************************************/

//Stealth icon.

%this.GuiSpriteCtrl_Icon_Stealth=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 416","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Spook:Image_Icon_Stealth";

Module_ID_Parent=%this;

GuiButtonCtrl_Icon_Stealth=0;

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

String_Skill="Stealth";

};

%this.GuiSpriteCtrl_Icon_Stealth.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Icon_Stealth);

/********************************************************************************************************************/

//Bolt icon.

%this.GuiSpriteCtrl_Icon_Bolt=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("552 416","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Spook:Image_Icon_Bolt";

Module_ID_Parent=%this;

GuiButtonCtrl_Icon_Bolt=0;

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

String_Skill="Bolt";

};

%this.GuiSpriteCtrl_Icon_Bolt.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Icon_Bolt);

/********************************************************************************************************************/

//Charge icon.

%this.GuiSpriteCtrl_Icon_Charge=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("736 416","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Spook:Image_Icon_Charge";

Module_ID_Parent=%this;

GuiButtonCtrl_Icon_Charge=0;

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

String_Skill="Charge";

};

%this.GuiSpriteCtrl_Icon_Charge.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Icon_Charge);

/********************************************************************************************************************/

//Melee icon.

%this.GuiSpriteCtrl_Icon_Melee=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("184 416","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Spook:Image_Icon_Melee";

Module_ID_Parent=%this;

GuiButtonCtrl_Icon_Melee=0;

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

String_Skill="Melee";

};

%this.GuiSpriteCtrl_Icon_Melee.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Icon_Melee);

/********************************************************************************************************************/

//Shuriken icon.

%this.GuiSpriteCtrl_Icon_Shuriken=new GuiSpriteCtrl()
{

HorizSizing="relative";

VertSizing="relative";

Extent="64 64";

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("368 416","800 480",Spooks_VS_Mounts.Resolution);

Profile="GuiDefaultProfile";

Image="Module_Player_Spook:Image_Icon_Shuriken";

Module_ID_Parent=%this;

GuiButtonCtrl_Icon_Shuriken=0;

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

String_Skill="Shuriken";

};

%this.GuiSpriteCtrl_Icon_Shuriken.addGuiControl(%GuiButtonCtrl);

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.GuiSpriteCtrl_Icon_Shuriken);

/********************************************************************************************************************/

}
