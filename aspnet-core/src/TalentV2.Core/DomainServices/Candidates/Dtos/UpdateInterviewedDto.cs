﻿using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentV2.Constants.Enum;
using TalentV2.Entities;

namespace TalentV2.DomainServices.Candidates.Dtos
{
    [AutoMapTo(typeof(RequestCV))]
    public class UpdateInterviewedDto
    {
        public long RequestCvId { get; set; }
        public bool? Interviewed { get; set; }
    }
}
