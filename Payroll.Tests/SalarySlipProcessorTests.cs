using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Payroll.Tests
{
     public class SalarySlipProcessorTests
    {
        [Fact]
        public void CalculateBasicSalary_ForEmployeeWageAndWorkingDays_ReturnsBasicSalary()
        {
            // Arrange

            var employee = new Employee { Wage = 500m, WorkingDays = 20 };

            // Act

            var salarySlipProcessor = new SalarySlipProcessor(null);

            var actual = salarySlipProcessor.CalculateBasicSalary(employee);

            var expected = 10000m;

            // Assert

            Assert.Equal(actual, expected);
        }
        [Fact]
        public void CalculateBasicSalary_EmployeeIsNull_ThrowArgumentNullException()
        {
            // Arrange

            Employee employee = null;

            // Act

            var salarySlipProcessor = new SalarySlipProcessor(null);

            Func<Employee, decimal> func = (e) => salarySlipProcessor.CalculateBasicSalary(employee);

            // Assert 

            Assert.Throws<ArgumentNullException>(() => func(employee));

        }

        [Fact]
        public void CalculateTransportationAllowece_ForEmployeeWorkInOffice_ReturnTransportationAllowece()
        {
            //Arrange
            var emp = new Employee() { WorkPlatform = WorkPlatform.Office };

            // Act
            var salarySlipProcessor = new SalarySlipProcessor(null);

            var actual = salarySlipProcessor.CalculateTransportationAllowece(emp);

            var expected = Constants.TransportationAllowanceAmount;

            // Assert

            Assert.Equal(actual, expected);

        }
        [Fact]
        public void CalculateTransportationAllowece_ForEmployeeWorkInRemote_ReturnTransportationAllowece()
        {
            //Arrange
            var emp = new Employee() { WorkPlatform = WorkPlatform.Remote };

            // Act
            var salarySlipProcessor = new SalarySlipProcessor(null);

            var actual = salarySlipProcessor.CalculateTransportationAllowece(emp);

            var expected = 0;

            // Assert

            Assert.Equal(actual, expected);

        }

        [Fact]
        public void CalculateTransportationAllowece_ForEmployeeWorkInHybrid_ReturnTransportationAllowece()
        {
            //Arrange
            var emp = new Employee() { WorkPlatform = WorkPlatform.Hybrid };

            // Act
            var salarySlipProcessor = new SalarySlipProcessor(null);

            var actual = salarySlipProcessor.CalculateTransportationAllowece(emp);

            var expected = Constants.TransportationAllowanceAmount /2;

            // Assert

            Assert.Equal(actual, expected);

        }

        [Fact]
        public void CalculateTransportationAllowece_EmployeeIsNull_ThrowArgumentNullException()
        {
            // Arrange

            Employee employee = null;

            // Act

            var salarySlipProcessor = new SalarySlipProcessor(null);

            Func<Employee, decimal> func = (e) => salarySlipProcessor.CalculateTransportationAllowece(employee);

            // Assert 

            Assert.Throws<ArgumentNullException>(() => func(employee));

        }



    }
}
