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

        [TestMethod]
        public void RemoveVehicleWithSlotNumber_IfValidNumber_RemovesVehicle()
        {
            VehicleTracker vt = new VehicleTracker(3, "Spoink road");
            Vehicle vh = new Vehicle("KXN 787", false);
            Vehicle vh2 = new Vehicle("Y78 99A", true);
            vt.AddVehicle(vh);
            vt.AddVehicle(vh2);

            bool removed = vt.RemoveVehicle(1);

            Assert.IsTrue(removed);
            Assert.IsNull(vt.VehicleList[1]);
        }

        [TestMethod]
        public void RemoveVehicleWithLicence_IfFound_RemovesVehicle()
        {
            VehicleTracker vt = new VehicleTracker(3, "Spoink road");
            Vehicle vh = new Vehicle("KXN 787", false);
            Vehicle vh2 = new Vehicle("Y78 99A", true);
            vt.AddVehicle(vh);
            vt.AddVehicle(vh2);

            vt.RemoveVehicle(vh2.Licence);

            Assert.IsNull(vt.VehicleList[2]);
        }

        [TestMethod]
        public void RemoveVehicleWithSlotNumber_IfInvalidNumber_ThrowsException()
        {
            VehicleTracker vt = new VehicleTracker(3, "Spoink road");
            Vehicle vh = new Vehicle("KXN 787", false);
            Vehicle vh2 = new Vehicle("Y78 99A", true);
            vt.AddVehicle(vh);
            vt.AddVehicle(vh2);

            bool removed = vt.RemoveVehicle(7);
            bool removed2 = vt.RemoveVehicle(-6);

            Assert.IsFalse(removed);
            Assert.IsFalse(removed2);
            Assert.ThrowsException<Exception>(() => vt.RemoveVehicle(3));
        }

        [TestMethod]
        public void RemoveVehicleWithLicence_IfInvalidLicence_ThrowsException()
        {
            VehicleTracker vt = new VehicleTracker(3, "Spoink road");
            Vehicle vh = new Vehicle("KXN 787", false);
            Vehicle vh2 = new Vehicle("Y78 99A", true);
            vt.AddVehicle(vh);
            vt.AddVehicle(vh2);

            string wrongLicence = "1Y1 Y1Y";

            Assert.ThrowsException<NullReferenceException>(() => vt.RemoveVehicle(wrongLicence));
        }
    }
}