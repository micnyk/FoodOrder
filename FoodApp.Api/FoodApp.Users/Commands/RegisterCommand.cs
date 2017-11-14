﻿using System.ComponentModel;
using ChatRoom.Infrastructure.CQS.Command;
using ChatRoom.Users.Dtos;

namespace ChatRoom.Users.Commands
{
    public class RegisterCommand : ICommand<RegisterResult>
    {
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        public bool IsGuest { get; set; }
    }
}
