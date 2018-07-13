using MatrixChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixChecker.Services
{
    public interface IMatrixService
    {
        string CheckMatrix(string input);
        IEnumerable<Matrix> GetAllMatrices();
    }
}
