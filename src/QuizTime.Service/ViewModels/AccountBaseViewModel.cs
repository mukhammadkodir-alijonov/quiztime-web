﻿namespace QuizTime.Service.ViewModels
{
    public class AccountBaseViewModel
    {
        public long Id { get; set; }

        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string PhoneNumber { get; set; } = String.Empty;

        public string ImagePath { get; set; } = String.Empty;
    }
}
