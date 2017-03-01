using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars;
using RobotWars.Navigation;
using RobotWars.Reporting;

namespace RobotWarsTest
{
    [TestClass]
    public class RobotTest
    {

        private Robot _robot;
        private IPositionController _positionController;
        private IReport _report;
        private IPosition _initialPosition;
        private IPosition _actualPosition;
        private IPosition _expectedPosition;

        [TestMethod]
        public void TestScenario1()
        {
            const string commands = "MLMRMMMRMMRR";
            _expectedPosition = new Position(4, 1, Direction.North);
            _initialPosition = new Position(0,2, Direction.East);
            _positionController = new PositionController(_initialPosition);
            _report = new Report();
            _robot = new Robot(_positionController, _report);
            _actualPosition = _robot.ExecuteCommands(commands);
            PerformCheck();

        }

        [TestMethod]
        public void TestScenario2()
        {
            const string commands = "LMLLMMLMMMRMM";
            _expectedPosition = new Position(0, 1, Direction.West, 1);
            _initialPosition = new Position(4, 4, Direction.South);
            _positionController = new PositionController(_initialPosition);
            _report = new Report();
            _robot = new Robot(_positionController, _report);
            _actualPosition = _robot.ExecuteCommands(commands);
            PerformCheck();

        }

        [TestMethod]
        public void TestScenario3()
        {
            const string commands = "MLMLMLMRMRMRMRM";
            _expectedPosition = new Position(2, 2, Direction.North);
            _initialPosition = new Position(2, 2, Direction.West);
            _positionController = new PositionController(_initialPosition);
            _report = new Report();
            _robot = new Robot(_positionController, _report);
            _actualPosition = _robot.ExecuteCommands(commands);
            PerformCheck();

        }

        [TestMethod]
        public void TestScenario4()
        {
            const string commands = "MMLMMLMMMMM";
            _expectedPosition = new Position(0, 0, Direction.South, 3);
            _initialPosition = new Position(1, 3, Direction.North);
            _positionController = new PositionController(_initialPosition);
            _report = new Report();
            _robot = new Robot(_positionController, _report);
            _actualPosition = _robot.ExecuteCommands(commands);
            PerformCheck();
        }

        private void PerformCheck()
        {
            Assert.AreEqual(_expectedPosition.GetXCoordinate(), _actualPosition.GetXCoordinate());
            Assert.AreEqual(_expectedPosition.GetYCoordinate(), _actualPosition.GetYCoordinate());
            Assert.AreEqual(_expectedPosition.GetCurrentDirection(), _actualPosition.GetCurrentDirection());
            Assert.AreEqual(_expectedPosition.GetPanalties(), _actualPosition.GetPanalties());     
        }
    }
}
