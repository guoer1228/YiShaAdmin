﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiSha.Util;

namespace YiSha.Entity.OrganizationManage
{
    [Table("sys_department")]
    public class DepartmentEntity : BaseEntity
    {
        [JsonConverter(typeof(StringJsonConverter))]
        public long? ParentId { get; set; }
        public string DepartmentName { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public long? PrincipalId { get; set; }
        public int? DepartmentSort { get; set; }
        public string Remark { get; set; }

        /// <summary>
        /// 多个部门Id
        /// </summary>
        [NotMapped]
        public string Ids { get; set; }
        /// <summary>
        /// 负责人名称
        /// </summary>
        [NotMapped]
        public string PrincipalName { get; set; }
    }
}
