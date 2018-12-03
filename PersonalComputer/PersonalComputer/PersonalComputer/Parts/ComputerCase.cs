namespace PersonalComputer
{
    class ComputerCase : ComputerComponent
    {
        public ComputerCase(string modelName, Manufacturer manufacturer, int serialNumber)
            :base(modelName, manufacturer, serialNumber)
        {
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }

        public override string ToString()
        {
            return "Корпус";
        }
    }
}