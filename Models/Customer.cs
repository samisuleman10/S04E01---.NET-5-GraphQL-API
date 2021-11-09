using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CommanderGQL.Models
{
    /// <summary>
    /// Represents any executable command.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Represents the unique ID for the platform.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Represents the email for the platform.
        /// </summary>
        [Required]
        public string Email { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }

        public enum Status
        {
            Active,
            Inactive
        }

        public string DateAndTime { get; set; }

        public bool IsBlocked { get; set; }

    }
}