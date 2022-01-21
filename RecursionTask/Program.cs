using RecursionTask;
using RecursionTask.Services;

Console.WriteLine("Hello, this program can calculate depth of provided structure!");

var testBranch = new Branch
{
    Branches = new List<Branch>
    {
        new Branch
        {
            Branches = new List<Branch>
            {
                new Branch()         
            }
        },
         new Branch
         {
            Branches = new List<Branch>
            {
                 new Branch(),
                 new Branch
                 {
                     Branches = new List<Branch>
                     {
                         new Branch
                         {
                             Branches = new List<Branch>
                             {
                                 new Branch()
                             }
                         },
                         new Branch()
                     }
                 },
                 new Branch()
            }
         }
     }
};

int answer = CalculationService.GetDepthOfProvidedStructure(testBranch);

Console.WriteLine(answer);
