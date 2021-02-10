using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzAPI.Models;

namespace FizzBuzzAPI.FizzBuzzData
{
    public class SqlFizzBuzzData : IFizzBuzzData
    {
        private DatabaseContext _fizzBuzzDbContext;

        public SqlFizzBuzzData(DatabaseContext fizzBuzzDbContext)
        {
            _fizzBuzzDbContext = fizzBuzzDbContext;
        }
        public void AddFizzBuzzData()
        {
            FizzBuzz fizzBuzzList;
            for (int i= 1;i <=100; i++)
            {
                string fizzBuzzData = "";
                fizzBuzzList = new FizzBuzz();

                if(i % 3 == 0)
                {
                    fizzBuzzData += "Fizz"; 
                }

                if( i % 5 == 0)
                {
                    fizzBuzzData += "Buzz";
                }

                if(fizzBuzzData == "")
                {
                    fizzBuzzData = Convert.ToString(i);
                }


                fizzBuzzList.fizzBuzzData = fizzBuzzData;
                _fizzBuzzDbContext.FizzBuzz.Add(fizzBuzzList);
                _fizzBuzzDbContext.SaveChanges();
            }
        }

        public List<FizzBuzz> GetFizzBuzzData()
        {
            return _fizzBuzzDbContext.FizzBuzz.ToList();
        }
    }
}
