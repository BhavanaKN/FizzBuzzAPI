using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzAPI.Models;

namespace FizzBuzzAPI.FizzBuzzData
{
    public interface IFizzBuzzData
    {
        List<FizzBuzz> GetFizzBuzzData();

        void AddFizzBuzzData();
    }
}
