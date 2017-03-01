using System;
using System.Collections.Generic;
using RobotWars.Navigation;
using RobotWars.Reporting;

namespace RobotWars
{
    public class Robot
    {
        private readonly IPositionController _positionController;
        private readonly IReport _report;
        private IDictionary<char, Func<IPosition>> _commandRunner;

        public Robot(IPositionController positionController, IReport report)
        {
            _positionController = positionController;
            _report = report;
            InitializeCommandFunctionDictionary();
        }

        public IPosition ExecuteCommands(string commands)
        {
            IPosition position = null;
            var commandArray = commands.ToCharArray();
            foreach (var command in commandArray)
            {
                position = _commandRunner[command]();
                 _report.ReportPositionAndPanalties(position);
            }
            return position;
        }

        private void InitializeCommandFunctionDictionary()
        {
            _commandRunner = new Dictionary<char, Func<IPosition>>
            {
                    { 'M' , _positionController.Move },
                    { 'R' , _positionController.TurnRight },
                    { 'L' , _positionController.TurnLeft },
           
            };
        }
    }
}
