using RecursionTask;
using RecursionTask.Services;
using System.Collections.Generic;

Console.WriteLine("Hello, this program can calculate depth of provided structure!");


var testBranch = new Branch
{
    Branches = new List<Branch>
    {
        new Branch
        {
            Branches = new List<Branch>
            {
                new Branch
                 {
                     Branches = new List<Branch>
                     {

                     }
                 }

            }
        },
         new Branch
         {
            Branches = new List<Branch>
            {
                 new Branch
                 {
                     Branches = new List<Branch>
                     {

                     }
                 },
                 new Branch
                 {
                     Branches = new List<Branch>
                     {
                         new Branch
                         {
                             Branches = new List<Branch>
                             {
                                 new Branch
                                 {
                                     Branches = new List<Branch>
                                     {

                                     }
                                 }

                             }
                         },
                         new Branch
                         {
                             Branches = new List<Branch>
                             {

                             }
                         }

                     }
                 },
                 new Branch
                 {
                     Branches = new List<Branch>
                     {

                     }
                 }
            }
         }
     }
};

//List<Branch> Branches = new List<Branch>();



int answer = CalculationService.GetDepthOfProvidedStructure(testBranch);

Console.WriteLine(answer);
