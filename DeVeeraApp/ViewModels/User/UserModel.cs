﻿using CRM.Core.Domain.Users;
using CRM.Core.ViewModels;
using DeVeeraApp.Model.Common;
using DeVeeraApp.ViewModels.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeVeeraApp.ViewModels.User
{
    public partial class UserModel : BaseEntityModel
    {
        public UserModel()
        {
            this.AvailableUserRoles = new List<SelectListItem>();
            this.AvailableCountries = new List<SelectListItem>();
            this.AvailableStates = new List<SelectListItem>();
            this.AvailableUsers = new List<SelectListItem>();
        }

        public string Username { get; set; }

        public Gender GenderType { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public Education EducationType { get; set; }
        public bool IncomeAboveOrBelow80K { get; set; }
        public FamilyOrRelationship FamilyOrRelationshipType { get; set; }


        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string ImageUrl { get; set; }
        public UserPassword UserPassword { get; set; }
        [NotMapped]
        public string OldPassword { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the username
        /// </summary>
        public string Alias { get; set; }

        //billing info
        public AddressModel UserAddress { get; set; }
       


        public string ActiveTab { get; set; }

        public int UserRoleId { get; set; }
        public UserRoleModel UserRole { get; set; }
        public bool Active { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }
        public IList<SelectListItem> AvailableUsers { get; set; }
        public List<SelectListItem> AvailableUserRoles { get; set; }


        /// <summary>
        /// Gets or sets the User GUID
        /// </summary>
        public Guid UserGuid { get; set; }

     

        /// <summary>
        /// Gets or sets the username
        /// </summary>
        public string Companyname { get; set; }

        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the email that should be re-validated. Used in scenarios when a User is already registered and wants to change an email address.
        /// </summary>
        public string EmailToRevalidate { get; set; }

        /// <summary>
        /// Gets or sets the admin comment
        /// </summary>
        public string AdminComment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the User is tax exempt
        /// </summary>
        public bool IsTaxExempt { get; set; }

        /// <summary>
        /// Gets or sets the affiliate identifier
        /// </summary>
        public int AffiliateId { get; set; }

        /// <summary>
        /// Gets or sets the vendor identifier with which this User is associated (maganer)
        /// </summary>
        public int VendorId { get; set; }



        /// <summary>
        /// Gets or sets a value indicating whether the User is required to re-login
        /// </summary>
        public bool RequireReLogin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating number of failed login attempts (wrong password)
        /// </summary>
        public int FailedLoginAttempts { get; set; }

        /// <summary>
        /// Gets or sets the date and time until which a User cannot login (locked out)
        /// </summary>
        public DateTime? CannotLoginUntilDateUtc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the User is active
        /// </summary>
    

        /// <summary>
        /// Gets or sets a value indicating whether the User has been deleted
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the User account is system
        /// </summary>
        public bool IsSystemAccount { get; set; }

        /// <summary>
        /// Gets or sets the User system name
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// Gets or sets the User Role Id
        /// </summary>
    

        /// <summary>
        /// Gets or sets the User Role Id
        /// </summary>
        public int? ParentUserId { get; set; }

        /// <summary>
        /// Gets or sets the last IP address
        /// </summary>
        public string LastIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the date and time of entity creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of last login
        /// </summary>
        public DateTime? LastLoginDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of last activity
        /// </summary>
        public DateTime LastActivityDateUtc { get; set; }






    }
    public enum Gender
    {
        Male = 1,
        Female = 2,
        Other = 3,
        DontWantToSay = 4
    }

    public enum Education
    {
        HighSchool = 1,
        AssociateDegree = 2,
        Bachelor = 3,
        Master = 4,
        Doctorate = 5
    }

    public enum FamilyOrRelationship
    {
        Marriied = 1,
        Divorced = 2,
        Separated = 3,
        Other = 4
    }
}
