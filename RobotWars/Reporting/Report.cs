using System;
using RobotWars.Navigation;

namespace RobotWars.Reporting
{
    public class  Report: IReport
    {
        public void ReportPositionAndPanalties(IPosition position)
        {
            Console.WriteLine("Current X Coordinate is : " + position.GetXCoordinate());
            Console.WriteLine("Current Y Coordinate is : " + position.GetYCoordinate());
            Console.WriteLine("Current Direction is : " + position.GetCurrentDirection());
            Console.WriteLine("Current Panalties is : " + position.GetPanalties());
        }
    }
}
