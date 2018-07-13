using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatrixChecker.Models;

namespace MatrixChecker.Repositories
{
    public class MatrixRepository : IMatrixRepository
    {
        private MatrixDbContext matrixContext;
        private Matrix matrix = new Matrix();

        public MatrixRepository(MatrixDbContext context)
        {
            matrixContext = context;
        }

        public void AddMatrix(string matrixData)
        {
            matrix.Date = DateTime.Now;
            matrix.Numbers = matrixData;
            matrixContext.Matrices.Add(matrix);
            matrixContext.SaveChanges();
        }

        public IEnumerable<Matrix> GetMatrices()
        {
            return matrixContext.Matrices;
        }
    }
}
