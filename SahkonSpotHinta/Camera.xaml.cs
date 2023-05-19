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
            //jos on probleemaa samsungien yms muiden kans niin kannattaa kokeilla ensin StopCameraAsync
            // await cameraView.StopCameraAsync();
            await cameraView.StartCameraAsync();


        });
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        myImage.Source = cameraView.GetSnapShot();
    }
}