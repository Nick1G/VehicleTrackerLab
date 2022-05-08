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
    }
}