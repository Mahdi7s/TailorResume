using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorResume.Models;

namespace TailorResume.DTOs
{
    internal class WordReplaceDTO
    {
        public Guid Id { get; set; }
        public string? Word { get; set; }
        public string? Replace { get; set; }
        public bool Resume { get; set; }
        public bool Selected { get; set; } = true;

        public override string ToString()
        {
            return $"{Word} > {Replace}";
        }
    }

    internal static class WordReplaceDTOExt
    {
        public static WordReplaceDTO ToDto(this WordReplace wordReplace)
        {
            return new WordReplaceDTO
            {
                Id = wordReplace.Id,
                Word = wordReplace.Word,
                Replace = wordReplace.Replace,
                Resume = wordReplace.Resume,
                Selected = wordReplace.Selected
            };
        }

        public static WordReplace ToObject(this WordReplaceDTO dto)
        {
            return new WordReplace
            {
                Id = dto.Id,
                Word = dto.Word,
                Replace = dto.Replace,
                Resume = dto.Resume,
                Selected = dto.Selected
            };
        }
    }
}
