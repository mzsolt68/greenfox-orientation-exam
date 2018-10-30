using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatrixChecker.Models;
using MatrixChecker.Repositories;

namespace MatrixChecker.Services
{
    public class MatrixService : IMatrixService
    {
        private MatrixDbContext matrixContext;
        private IMatrixRepository matrixRepository;
        private List<List<int>> matrix;

        public MatrixService(MatrixDbContext context)
        {
            matrixContext = context;
            matrixRepository = new MatrixRepository(matrixContext);
            matrix = new List<List<int>>();
        }

        public string CheckMatrix(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return "No data";
            }
            if(!IsDecomposedToMatrix(input))
            {
                return "Bad data format (not a number in the data)";
            }
            if(!IsASquareMatrix(matrix))
            {
                return "Not a square matrix!";
            }
            if(!IsRowsIncreasing(matrix))
            {
                return "This matrix is not increasing! Please try again!";
            }
            if(!IsColumnsIncreasing(matrix))
            {
                return "This matrix is not increasing! Please try again!";
            }
            matrixRepository.AddMatrix(input);
            return "This matrix is increasing!";
        }

        private bool IsColumnsIncreasing(List<List<int>> matrixToCheck)
        {
            for(int i = 0; i < matrixToCheck[0].Count; i++)
            {
                for(int j = 1; j < matrixToCheck.Count; j++)
                {
                    if(matrixToCheck[j][i] <= matrixToCheck[j -1][i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsRowsIncreasing(List<List<int>> matrixToCheck)
        {
            foreach (var row in matrixToCheck)
            {
                for(int i = 1; i < row.Count; i++)
                {
                    if(row[i] < row[i -1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsDecomposedToMatrix(string inputData)
        {
            string[] rows = inputData.Split("\r\n");
            foreach (string row in rows)
            {
                List<int> oneRow = new List<int>();
                foreach (var item in row.Split(" "))
                {
                    try
                    {
                        oneRow.Add(int.Parse(item));
                    }
                    catch (FormatException)
                    {
                        return false;
                    }
                }
                matrix.Add(oneRow);
            }
            return true;
        }

        private bool IsASquareMatrix(List<List<int>> matrixToCheck)
        {
            if(matrixToCheck.Count < 2)
            {
                return false;
            }
            foreach (var row in matrixToCheck)
            {
                if (row.Count != matrixToCheck.Count)
                    return false;
            }
            return true;
        }

        public IEnumerable<Matrix> GetAllMatrices()
        {
            return matrixRepository.GetMatrices();
        }
    }
}
