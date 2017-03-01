using RobotWars.Navigation;

namespace RobotWars.Reporting
{
    public interface IReport
    {
        void ReportPositionAndPanalties(IPosition actionResult);
    }
}
