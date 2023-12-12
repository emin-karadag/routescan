using System.ComponentModel.DataAnnotations;

namespace Routescan.Models.Enums
{
    public enum TagEnum
    {
        [Display(Name = "latest")]
        LATEST,

        [Display(Name = "earliest")]
        EARLIEST,

        [Display(Name = "pending")]
        PENDING
    }
}
