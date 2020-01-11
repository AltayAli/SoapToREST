using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorServiceAPI.Models
{
    public interface ICalculateService
    {
        Task<int> AddAsync(int intA, int intB);
        Task<int> SubtractAsync(int intA, int intB);
        Task<int> MultiplyAsync(int intA, int intB);
        Task<int> DivideAsync(int intA, int intB);
    }
}
