using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleTrackerLab.Models;

namespace VehicleTrackerLabTests
{
    [TestClass]
    public class VehicleTrackerTests
    {
        [TestMethod]
        public void VehicleTrackerClass_OnInitialize_HasEmptySlots()
        {
            // Arrange
            VehicleTracker vt = new VehicleTracker(3, "Bagool street");
            int expectedSlots = 3;
            int actualSlots = vt.VehicleList.Count;

            // Assert
            Assert.AreEqual(expectedSlots, actualSlots);
        }

        [TestMethod]
        public void AddVehicleMethod_IfSlotsAvailable_AddsNewVehicle()
        {
            VehicleTracker vt = new VehicleTracker(1, "Bingo drive");
            Vehicle vehicle = new Vehicle("R2E 7AY", false);

            vt.AddVehicle(vehicle);
            var expectedVehicle = vehicle;
            var actualVehicle = vt.VehicleList[1];

            Assert.AreSame(expectedVehicle, actualVehicle);
        }
    }
}