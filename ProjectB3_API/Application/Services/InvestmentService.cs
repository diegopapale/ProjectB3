using ProjectB3_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectB3_API.Application.Services
{
    public class InvestmentService
    {
        private const decimal TB = 1.08m;
        private const decimal CDI = 0.009m;

        public InvestmentResult CalculateInvestment(decimal initialValue, int months)
        {
            if (months < 1)
                throw new ArgumentException("O prazo deve ser maior que 1 mês.");

            if (initialValue <= 0)
                throw new ArgumentException("O valor deve ser maior que 0 zero.");

            decimal grossValue = initialValue;

            for (int i = 0; i < months; i++)
            {
                grossValue *= (1 + (CDI * TB));
            }

            decimal taxPercentage = GetTaxPercentage(months);
            decimal taxAmount = (grossValue - initialValue) * taxPercentage;

            return new InvestmentResult
            {
                GrossValue = grossValue,
                NetValue = grossValue - taxAmount
            };
        }

        private decimal GetTaxPercentage(int months)
        {
            if (months <= 6) return 0.225m;
            if (months <= 12) return 0.20m;
            if (months <= 24) return 0.175m;
            return 0.15m;
        }
    }
}