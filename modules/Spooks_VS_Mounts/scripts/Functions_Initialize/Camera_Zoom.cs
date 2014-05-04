function Class_Spooks_VS_Mounts_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Spooks_VS_Mounts.setCameraZoom(Window_Spooks_VS_Mounts.getCameraZoom()+$pref::Spooks_VS_Mounts::cameraMouseZoomRate);

}

function Class_Spooks_VS_Mounts_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Spooks_VS_Mounts.setCameraZoom(Window_Spooks_VS_Mounts.getCameraZoom()-$pref::Spooks_VS_Mounts::cameraMouseZoomRate);

}
