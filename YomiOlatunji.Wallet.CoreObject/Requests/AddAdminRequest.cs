﻿namespace YomiOlatunji.Wallet.CoreObject.Requests
{
    public class AddAdminRequest
    {
        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Role { get; set; } = null!;
    }
}