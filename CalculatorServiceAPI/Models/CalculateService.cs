using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorServiceAPI.Models
{
    public class CalculateService : ICalculateService
    {
        CalculatorSoapClient calculatorSoapChannel;
        public CalculateService()
        {
            calculatorSoapChannel = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);
        }
        public async Task<int> AddAsync(int intA, int intB)
        {
            return await calculatorSoapChannel.AddAsync(intA, intB);
        }

        public async Task<int> DivideAsync(int intA, int intB)
        {
            return await calculatorSoapChannel.DivideAsync(intA, intB);
        }

        public async Task<int> MultiplyAsync(int intA, int intB)
        {
            return await calculatorSoapChannel.MultiplyAsync(intA, intB);
        }

        public async Task<int> SubtractAsync(int intA, int intB)
        {
            return await calculatorSoapChannel.SubtractAsync(intA, intB);
        }
    }
}
