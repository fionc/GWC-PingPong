using System;
using System.ComponentModel.DataAnnotations;

//Players table to hold First Name, Last Name, and Number of Wins
namespace PingPong.Entities
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Office { get; set; }
        public int numberWins {get; set; }
        public int numberLosses {get; set;}
    }
    public enum TasteRating
    {
        Test
    }
}