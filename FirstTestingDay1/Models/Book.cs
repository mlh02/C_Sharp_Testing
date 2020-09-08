using System;
using System.ComponentModel.DataAnnotations;

namespace FirstTestingDay1.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int Rating { get; set; }

        public bool SameWordBackwards(string str)
        {
            string reversedWord = str.ToLower().ToCharArray().ToString();

            if (reversedWord != str)
            {
                return false;
            }
            return true;
        }
        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
