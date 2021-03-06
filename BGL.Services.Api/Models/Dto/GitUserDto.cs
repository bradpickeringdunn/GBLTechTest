﻿using System.Runtime.Serialization;

namespace BGL.Services.Api.Models.Dto
{
    [DataContract]
    public class GitUserDto
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string AvatarUrl { get; set; }

        [DataMember]
        public string Location { get; set; }

    }
}
