using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorResume.Models
{
    internal class WordReplace : RealmObject
    {
        [PrimaryKey]
        public Guid Id {  get; set; }
        public string? Word {  get; set; }
        public string? Replace { get; set; }
        public bool Resume {  get; set; }
        public bool Selected { get; set; } = true;
    }
}
