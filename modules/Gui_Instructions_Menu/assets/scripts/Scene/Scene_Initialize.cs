function Module_Gui_Instructions_Menu::Scene_Initialize(%this)
{

%Text="You are biological experiments,";
%Text=%Text NL "use your powers to survive.";
%Text=%Text NL "Hack the terminals to score 5 points.";
%Text=%Text NL "Eradicate the enemy to score 1 point.";
%Text=%Text NL "Drones are in annihilation mode.";
%Text=%Text NL "Credits for code and graphics to their respective authors.";
%Text=%Text NL "Thank you for playing. ~ practicing01";

%this.Gui_Text_ML=new GuiMLTextCtrl()
{
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Text=%Text; 
Extent=Spooks_VS_Mounts.Resolution;
isContainer="1";
Profile="Gui_Profile_Modalless_Text";
hovertime="1000";
MaxLength="512";
};

Gui_Instructions_Menu.addGuiControl(%this.Gui_Text_ML);

}
