﻿namespace Company_Expense_Tracker.Entities;

public class User : BaseEntity
{
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public Role Role { get; set; } 
}