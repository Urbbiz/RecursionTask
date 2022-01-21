namespace RecursionTask.Services
{
    public static class CalculationService
    {
        public static int GetDepthOfProvidedStructure(Branch branch)
        {
            if (branch == null)
            {
                return 0;
            }
            else if (branch.Branches == null || !branch.Branches.Any())
            {
                return 1;
            }
            else
            {
                return 1 + branch.Branches.Select(b => GetDepthOfProvidedStructure(b)).Max();
            }      
        }
    }
}
