using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Vehicle vh = new Vehicle("R2E 7AY", false);

            vt.AddVehicle(vh);
            var expectedVehicle = vh;
            var actualVehicle = vt.VehicleList[1];

            Assert.AreSame(expectedVehicle, actualVehicle);
        }

        [TestMethod]
        public void AddVehicleMethod_IfSlotsUnavailable_ThrowsException()
        {
            VehicleTracker vt = new VehicleTracker(0, "Boingus blvd");
            Vehicle vh = new Vehicle("T7Y YY9", true);

            Assert.ThrowsException<IndexOutOfRangeException> (() => vt.AddVehicle(vh));
        }

        //public void RemoveVehicleMethod_IfValidData_RemovesVehicle()
        //{
        //    VehicleTracker vt = new VehicleTracker(3, "Spoink road");
        //    Vehicle vh = new Vehicle("KXN 787", false);
        //    Vehicle vh2 = new Vehicle("")
        //}
    }
}