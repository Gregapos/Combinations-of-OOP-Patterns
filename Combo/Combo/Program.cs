class Program
{
    static void Main(string[] args)
    {
        var center = ControlCenter.GetInstance();
        center.setStrategy(new AlertPoliceStrategy());

        var camera1 = new Camera("camera1");
        var camera2 = new Camera("camera2");
        var camera3 = new Camera("camera3");

        var sensor1 = new MotionSensor("sensor1");

        var mainZone = new SecurityComponentZone("Main Zone");
        var zone1 = new SecurityComponentZone("Zone1");

        zone1.AddChild(camera1).AddChild(sensor1);
        mainZone.AddChild(camera2).AddChild(zone1);

        center.ExecuteCommand(new UnlockCommand(mainZone));

        center.ExecuteCommand(new LockCommand(zone1));
        camera1.Detect();
        camera2.Detect();
    }
}
