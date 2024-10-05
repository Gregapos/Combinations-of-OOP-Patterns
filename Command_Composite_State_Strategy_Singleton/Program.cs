class Program
{
    static void Main(string[] args)
    {
        ControlCenter.GetInstance().SetStrategy(new AlertPoliceStrategy());

        var camera1 = new Camera("camera1");
        var camera2 = new Camera("camera2");
        var camera3 = new Camera("camera3");

        var sensor1 = new MotionSensor("sensor1");

        var mainZone = new SecurityComponentZone("Main Zone");
        var zone1 = new SecurityComponentZone("Zone1");

        zone1.AddChild(camera1).AddChild(sensor1);
        mainZone.AddChild(camera2).AddChild(zone1);

        ControlCenter.GetInstance().ExecuteCommand(new UnlockCommand(mainZone));
        ControlCenter.GetInstance().ExecuteCommand(new LockCommand(zone1));

        camera1.Detect();
        camera2.Detect();

        ControlCenter.GetInstance().SetStrategy(new SirenStrategy());
        sensor1.Detect();
    }
}
