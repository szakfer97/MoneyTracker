namespace MoneyTracker.Models
{
    public class UserBudget
    {
        public decimal MonthlyIncome { get; set; }
        public decimal GroceriesExpense { get; set; }
        public decimal InsuranceExpense { get; set; }
        public decimal CarExpense { get; set; }
        public decimal HousingExpense { get; set; }
        public decimal MiscellaneousExpense { get; set; }

        public decimal TotalExpenses => GroceriesExpense + InsuranceExpense + CarExpense + HousingExpense + MiscellaneousExpense;

        public decimal RemainingIncome => MonthlyIncome - TotalExpenses;

        public decimal GroceriesPercentage => MonthlyIncome > 0 ? Math.Round(GroceriesExpense / MonthlyIncome * 100, 2) : 0;
        public decimal InsurancePercentage => MonthlyIncome > 0 ? Math.Round(InsuranceExpense / MonthlyIncome * 100, 2) : 0;
        public decimal CarPercentage => MonthlyIncome > 0 ? Math.Round(CarExpense / MonthlyIncome * 100, 2) : 0;
        public decimal HousingPercentage => MonthlyIncome > 0 ? Math.Round(HousingExpense / MonthlyIncome * 100, 2) : 0;
        public decimal MiscellaneousPercentage => MonthlyIncome > 0 ? Math.Round(MiscellaneousExpense / MonthlyIncome * 100, 2) : 0;

        public decimal TotalPercentage => MonthlyIncome > 0 ? Math.Round(TotalExpenses / MonthlyIncome * 100, 2) : 0;
    }
}