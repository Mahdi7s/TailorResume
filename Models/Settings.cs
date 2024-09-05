using Realms;
using Realms.Schema;
using Realms.Weaving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorResume.Models
{
    internal class Settings : RealmObject
    {
        [PrimaryKey]
        public Guid Id { get; set; }

        public string? CvFilePath { get; set; }
        public string? ClFilePath { get; set; }
        public string? OutputFolder { get; set; }
        public string? ApplicantName { get; set; }
        public bool ChangeCvFileNameBasedOnPosition {  get; set; } = true;
    }
}
