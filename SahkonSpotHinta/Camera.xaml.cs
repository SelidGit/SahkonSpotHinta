namespace SahkonSpotHinta;

public partial class Camera : ContentPage
{
	public Camera()
	{
		InitializeComponent();
	}
    private void cameraView_CamerasLoaded(object sender, EventArgs e)
    {
        cameraView.Camera = cameraView.Cameras.First();
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await cameraView.StartCameraAsync();


        });
    }
}