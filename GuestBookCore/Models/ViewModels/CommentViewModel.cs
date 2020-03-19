using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GuestBookCore.Models.ViewModels
{
    public class CommentViewModel
    {
        [Required(ErrorMessage ="Не введено имя пользователя!")]
        [MinLength(3,ErrorMessage ="Длина имени пользователя должна быть не короче 3 символов!")]
        [Display(Name ="Имя пользователя")]
        public string Username { get; set; }
        [Display(Name ="Комментарий")]
        public string Text { get; set; }
    }
}
