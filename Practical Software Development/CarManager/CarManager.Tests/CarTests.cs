namespace CarManager.Tests
{
    public class Tests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            car = new Car("Vw", "Golf", 2, 100);
        }

        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            Assert.AreEqual("Vw", car.Make);
            Assert.AreEqual("Golf", car.Model);
            Assert.AreEqual(2, car.FuelConsumption);
            Assert.AreEqual(0, car.FuelAmount);
            Assert.AreEqual(100, car.FuelCapacity);
        }

        [Test]
        public void ModelShouldThrowArgExWhenNameIsNull()
        {
            Assert.Throws<ArgumentException>(() => new Car("Vw", null, 2, 100));
        }

        [Test]
        public void MakeShouldThrowArgExWhenNameIsNull()
        {
            Assert.Throws<ArgumentException>(() => new Car(null, "Golf", 2, 100));
        }

        [Test]
        public void FuelConsumptionShouldThrowArgExWhenIsBellowZero()
        {
            Assert.Throws<ArgumentException>(() => new Car("Vw", "Golf", -2, 100));
        }

        [Test]
        public void FuelConsumptionShouldThrowArgExWhenIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Car("Vw", "Golf", 0, 100));
        }

        [Test]
        public void FuelCapacityShouldThrowArgExWhenIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Car("Vw", "Golf", 2, 0));
        }

        [Test]
        public void FuelCapacityShouldThrowArgExWhenIsBellowZero()
        {
            Assert.Throws<ArgumentException>(() => new Car("Vw", "Golf", 2, -100));
        }

        [Test]
        [TestCase("Vw", "Golf", 2, 100)]
        public void ValidateAllProperties(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            var car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(0, car.FuelAmount);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
        }

        [Test]
        public void ShouldRefuelNormally()
        {
            car.Refuel(50);
            Assert.AreEqual(50, car.FuelAmount);
        }

        [Test]
        public void ShouldRefuelUntillTotalFuelCapacity()
        {
            car.Refuel(150);
            Assert.AreEqual(100, car.FuelAmount);
        }

        [Test]
        public void ShouldRefuelThrowArgExWhenInputAmountIsBelloZero()
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(-10));
        }

        [Test]
        public void ShouldDriveNormally()
        {
            car.Drive(200);
            Assert.AreEqual(96, Math.Round(car.FuelAmount, 2));
        }

        [Test]
        public void DriveShouldThrowInvalidOperationExceptionWhenFuelAmountIsNotEnough()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(6000));
        }
    }
}