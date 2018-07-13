using MatrixChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixChecker.Repositories
{
    public interface IMatrixRepository
    {
        IEnumerable<Matrix> GetMatrices();
        void AddMatrix(string matrixData);
    }
}
