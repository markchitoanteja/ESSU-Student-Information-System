using System;
using System.Text.RegularExpressions;

namespace ESSU_Student_Information_System
{
    internal class Validator
    {
        public bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, emailPattern);
        }

        public bool IsValidMobileNumber(string mobileNumber)
        {
            string mobilePattern = @"^09\d{9}$";

            return Regex.IsMatch(mobileNumber, mobilePattern);
        }

        public bool IsValidBirthday(DateTime birthday)
        {
            DateTime today = DateTime.Now;
            DateTime oldestAllowed = today.AddYears(-120);
            
            return birthday < today && birthday > oldestAllowed;
        }

        public bool IsValidStudentNumber(string studentNumber)
        {
            string studentNumberPattern = @"^\d{2}-\d{5}$";
            
            return Regex.IsMatch(studentNumber, studentNumberPattern);
        }
    }
}
