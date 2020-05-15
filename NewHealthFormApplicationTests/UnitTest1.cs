using NewHealthFormApplication;
using Xunit;

namespace NewHealthFormApplicationTests
{
    public class DataStructureTests
    {
        [Fact]
        public void AddEmployee_NameSophie_ReturnsNameSophie()
        {
            var healthDataHolder = new HealthDataHolder();
            healthDataHolder.AddEmployee("123456789", "Sophie", "36.5", false, false);
            Assert.Equal("Sophie", healthDataHolder.DataHolder["123456789"].Name);
        }

        [Fact]
        public void EditEmployee_Temperature38_ReturnsTemperature38()
        {
            var healthDataHolder = new HealthDataHolder();
            healthDataHolder.AddEmployee("123456789", "Sophie", "36.5", false, false);
            healthDataHolder.EditEmployee(healthDataHolder.DataHolder, "123456789", "Sophie", "38", true, false);
            Assert.Equal("38", healthDataHolder.DataHolder["123456789"].Temperature);
        }

        [Fact]
        public void DeleteEmployee_ExistedGinNumber_ReturnsTrue()
        {
            var healthDataHolder = new HealthDataHolder();
            healthDataHolder.AddEmployee("123456789", "Sophie", "36.5", false, false);
            Assert.True(healthDataHolder.DeleteEmployee("123456789"));
        }

        [Fact]
        public void DeleteEmployee_UnexistedGinNumber_ReturnsFalse()
        {
            var healthDataHolder = new HealthDataHolder();
            healthDataHolder.AddEmployee("123456789", "Sophie", "36.5", false, false);
            Assert.True(!healthDataHolder.DeleteEmployee("111111"));
        }

        [Fact]
        public void DeleteEmployee_CheckSuccess()
        {
            var healthDataHolder = new HealthDataHolder();
            healthDataHolder.AddEmployee("123456789", "Sophie", "36.5", false, false);
            healthDataHolder.DeleteEmployee("123456789");
            Assert.False(healthDataHolder.DataHolder.ContainsKey("123456789"));
        }
        
        [Fact]
        public void ContainsKey_InputParameterExistedGinNumber_ReturnsTrue()
        {
            var healthDataHolder = new HealthDataHolder();
            healthDataHolder.AddEmployee("123456789", "Sophie", "36.5", false, false);
            Assert.True(healthDataHolder.ContainsKey("123456789"));
        }
    }
}
