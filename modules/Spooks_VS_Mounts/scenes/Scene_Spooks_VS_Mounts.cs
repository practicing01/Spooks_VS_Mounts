function Window_Create_Spooks_VS_Mounts()
{

if (!isObject(Window_Spooks_VS_Mounts))
{

new SceneWindow(Window_Spooks_VS_Mounts);   

Window_Spooks_VS_Mounts.Profile=Gui_Profile_Window_Spooks_VS_Mounts;

Canvas.setContent(Window_Spooks_VS_Mounts);                     

}

Window_Spooks_VS_Mounts.stopCameraMove();
Window_Spooks_VS_Mounts.dismount();
Window_Spooks_VS_Mounts.setViewLimitOff();
Window_Spooks_VS_Mounts.setRenderGroups(Spooks_VS_Mounts.All_Bits);
Window_Spooks_VS_Mounts.setRenderLayers(Spooks_VS_Mounts.All_Bits);
Window_Spooks_VS_Mounts.setObjectInputEventGroupFilter(Spooks_VS_Mounts.All_Bits);
Window_Spooks_VS_Mounts.setObjectInputEventLayerFilter(Spooks_VS_Mounts.All_Bits);
Window_Spooks_VS_Mounts.setLockMouse(true);
Window_Spooks_VS_Mounts.setCameraPosition(0,0);
Window_Spooks_VS_Mounts.setCameraZoom(1);
Window_Spooks_VS_Mounts.setCameraAngle(0);

Spooks_VS_Mounts.Resolution=getRes();
%Y_Times_100=100*Spooks_VS_Mounts.Resolution.Y;
%Cam_Y=%Y_Times_100/Spooks_VS_Mounts.Resolution.X;

Window_Spooks_VS_Mounts.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Spooks_VS_Mounts_Overlay))
{

new GuiControl(Gui_Spooks_VS_Mounts_Overlay)
{

Position="0 0";
Extent=Spooks_VS_Mounts.Resolution;
Profile=gui_profile_modalless;

};   

Window_Spooks_VS_Mounts.addGuiControl(Gui_Spooks_VS_Mounts_Overlay);

Gui_Spooks_VS_Mounts_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Spooks_VS_Mounts()
{
    
if (isObject(Window_Spooks_VS_Mounts))
{

Window_Spooks_VS_Mounts.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Spooks_VS_Mounts()
{

if (isObject(Scene_Spooks_VS_Mounts))
{

Scene_Spooks_VS_Mounts.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Spooks_VS_Mounts))
{

error("Cannot set Spooks_VS_Mounts Scene to Window as the Scene is invalid.");
return;

}
    
Window_Spooks_VS_Mounts.setScene(Scene_Spooks_VS_Mounts);

Window_Spooks_VS_Mounts.stopCameraMove();
Window_Spooks_VS_Mounts.dismount();
Window_Spooks_VS_Mounts.setViewLimitOff();
Window_Spooks_VS_Mounts.setRenderGroups(Spooks_VS_Mounts.All_Bits);
Window_Spooks_VS_Mounts.setRenderLayers(Spooks_VS_Mounts.All_Bits);
Window_Spooks_VS_Mounts.setObjectInputEventGroupFilter(Spooks_VS_Mounts.All_Bits);
Window_Spooks_VS_Mounts.setObjectInputEventLayerFilter(Spooks_VS_Mounts.All_Bits);
Window_Spooks_VS_Mounts.setLockMouse(true);
Window_Spooks_VS_Mounts.setCameraPosition(0,0);
Window_Spooks_VS_Mounts.setCameraZoom(1);
Window_Spooks_VS_Mounts.setCameraAngle(0);

Spooks_VS_Mounts.Resolution=getRes();
%Y_Times_100=100*Spooks_VS_Mounts.Resolution.Y;
%Cam_Y=%Y_Times_100/Spooks_VS_Mounts.Resolution.X;

Window_Spooks_VS_Mounts.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Spooks_VS_Mounts()
{

Scene_Destroy_Spooks_VS_Mounts();

new Scene(Scene_Spooks_VS_Mounts);

if (!isObject(Window_Spooks_VS_Mounts))
{

error("Spooks_VS_Mounts: Created scene but no window available.");
return;

}

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Spooks_VS_Mounts to use an invalid Scene.");
return;

}
   
Scene_Destroy_Spooks_VS_Mounts();

%Scene.setName("Scene_Spooks_VS_Mounts");

//%Scene.class="Class_Scene_Spooks_VS_Mounts";

Scene_Set_To_Window();

//%Scene.setDebugOn("joints");
//%Scene.setDebugOn("metrics");
//%Scene.setDebugOn("fps");
//%Scene.setDebugOn("wireframe");
//%Scene.setDebugOn("aabb");
//%Scene.setDebugOn("oobb");
//%Scene.setDebugOn("sleep");
//%Scene.setDebugOn("collision");
//%Scene.setDebugOn("position");
//%Scene.setDebugOn("sort");
//%Scene.setDebugOn("controllers");

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Spooks_VS_Mounts::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/
