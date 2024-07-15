﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class PersonName : BaseEntity
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        [JsonIgnore]
        public override MetaData MetaData { get => base.MetaData; set => base.MetaData = value; }
    }
}
