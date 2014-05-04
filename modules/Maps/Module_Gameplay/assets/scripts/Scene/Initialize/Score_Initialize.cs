function Module_Gameplay::Score_Update(%this)
{

%this.Gui_Text_Score.setText("Spooks:" SPC %this.Int_Spook_Score SPC "Mounts:" SPC %this.Int_Mount_Score);

}

function Module_Gameplay::Score_Initialize(%this)
{

%this.Gui_Text_Score=new GuiMLTextCtrl()
{

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("275 0","800 480",Spooks_VS_Mounts.Resolution);
HorizSizing="relative";
VertSizing="relative";
Text="Spooks: 0 Mounts: 0"; 
Extent="250 100";
isContainer="1";
Profile="Gui_Profile_Modalless_Text";
hovertime="1000";
MaxLength="512";

};

Gui_Spooks_VS_Mounts_Overlay.addGuiControl(%this.Gui_Text_Score);

}
