using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectB3_API.Application.Services;
using ProjectB3_API.Domain.Models;
using System;

namespace ProjectB3.Tests
{
    [TestClass]
    public class InvestmentServiceTests
    {
        private InvestmentService _investmentService;

        [TestInitialize]
        public void Setup()
        {
            _investmentService = new InvestmentService();
        }

        [TestMethod]
        public void CalculateInvestment_ShouldReturnCorrectValues()
        {
            // Arrange
            decimal initialValue = 1000m;
            int months = 12;

            // Act
            var investment = _investmentService.CalculateInvestment(initialValue, months);

            // Assert
            Assert.IsTrue(investment.GrossValue > initialValue);
            Assert.IsTrue(investment.NetValue < investment.GrossValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateInvestment_ShouldThrowException_ForInvalidMonths()
        {
            // Act
            _investmentService.CalculateInvestment(1000, 0);
        }

        [TestMethod]
        public void CalculateInvestment_ShouldApplyCorrectTax_ForLessThan6Months()
        {
            // Arrange
            decimal initialValue = 1000m;
            int months = 6;

            // Act
            var investment = _investmentService.CalculateInvestment(initialValue, months);

            // Assert
            decimal expectedTax = 0.225m;
            decimal grossProfit = investment.GrossValue - initialValue;
            decimal expectedNetValue = investment.GrossValue - (grossProfit * expectedTax);

            Assert.AreEqual(expectedNetValue, investment.NetValue);
        }

        [TestMethod]
        public void CalculateInvestment_ShouldApplyCorrectTax_ForMoreThan24Months()
        {
            // Arrange
            decimal initialValue = 1000m;
            int months = 25;

            // Act
            var investment = _investmentService.CalculateInvestment(initialValue, months);

            // Assert
            decimal expectedTax = 0.15m;
            decimal grossProfit = investment.GrossValue - initialValue;
            decimal expectedNetValue = investment.GrossValue - (grossProfit * expectedTax);

            Assert.AreEqual(expectedNetValue, investment.NetValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateInvestment_ShouldThrowException_ForInvalidValues()
        {
            // Act
            _investmentService.CalculateInvestment(0, 12);
        }
    }
}
