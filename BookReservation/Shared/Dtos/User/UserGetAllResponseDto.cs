using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReservation.Shared.Dtos.User
{
    public class UserGetAllResponseDto : BaseDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}