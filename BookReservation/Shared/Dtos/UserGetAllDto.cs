using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReservation.Shared.Dtos
{
    public class UserGetAllDto
    {
        public int Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public int CreateBy { get; set; }
        public bool IsActive { get; set; }
    }
}