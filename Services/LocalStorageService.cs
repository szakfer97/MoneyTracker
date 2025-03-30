using Blazored.LocalStorage;
using MoneyTracker.Models;

namespace MoneyTracker.Services
{
    public class LocalStorageService
    {
        private readonly ILocalStorageService _localStorage;
        private const string BUDGET_KEY = "user_budget";

        public LocalStorageService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task SaveUserBudgetAsync(UserBudget budget)
        {
            await _localStorage.SetItemAsync(BUDGET_KEY, budget);
        }

        public async Task<UserBudget> GetUserBudgetAsync()
        {
            try
            {
                var budget = await _localStorage.GetItemAsync<UserBudget>(BUDGET_KEY);
                return budget ?? new UserBudget();
            }
            catch
            {
                return new UserBudget();
            }
        }

        public async Task ClearUserBudgetAsync()
        {
            await _localStorage.RemoveItemAsync(BUDGET_KEY);
        }
    }
}