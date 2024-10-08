﻿using Microsoft.AspNetCore.Identity;
using Shop.Data.Entities;
using Shop.Models;

namespace Shop.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

		Task<User> AddUserAsync(AddUserViewModel model);
		Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

    }


}
