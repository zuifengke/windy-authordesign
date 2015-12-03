using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthorDesign.Web.Areas.Admin.Models
{
    public class AdminModel
    {
        /// <summary>
        /// 管理员ID（主键）
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        [StringLength(11, MinimumLength = 11, ErrorMessage = "手机号码格式不正确")]
        [Display(Name = "手机号码")]
        [Required(ErrorMessage="手机号码不能为空")]
        public string Mobile { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [StringLength(11, MinimumLength = 1, ErrorMessage = "用户名不能为空")]
        [Display(Name = "用户名")]
        [Required(ErrorMessage = "用户名不能为空")]
        public string AdminName { get; set; }

        /// <summary>
        /// 对应角色Id
        /// </summary>
        [Display(Name = "对应角色Id")]
        [Range(1,int.MaxValue,ErrorMessage="请选择角色")]
        public int AuthoryId { get; set; }
        /// <summary>
        /// 是否可登录
        /// </summary>
        [Display(Name = "是否可登录")]
        public Byte IsLogin { get; set; }
    }
}