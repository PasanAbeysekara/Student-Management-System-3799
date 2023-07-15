using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.MVVM.Models
{
	public class Student
	{
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public char Gender { get; set; }
		public string Image { get; set; }
		public string ImageURL
		{
			get
			{
				return $"/Images/{Image}";
			}
		}

		public string DateOfBirth { get; set; }
		public string Email { get; set; }
		public double GPA { get; set; }
		public bool IsSelected { get; set; }

		public Student(string firstName, string lastName, char gender, string image, string dateOfBirth, double gPA, string email)
		{
			FirstName = firstName;
			LastName = lastName;
			Gender = gender;
			Image = image;
			DateOfBirth = dateOfBirth;
			GPA = gPA;
			Email = email;
			IsSelected = false;
		}
	}
}
