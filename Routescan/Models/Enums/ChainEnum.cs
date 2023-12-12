using System.ComponentModel.DataAnnotations;

namespace Routescan.Models.Enums
{
    public enum ChainEnum
    {
        [Display(Name = "43114")]
        C_CHAIN,

        [Display(Name = "1")]
        ETHEREUM,

        [Display(Name = "324")]
        ZKSYNC_ERA,

        [Display(Name = "10")]
        OPTIMISM,

        [Display(Name = "432204")]
        DEXALOT,

        [Display(Name = "8453")]
        BASE,

        [Display(Name = "88888")]
        CHILIZ,

        [Display(Name = "1088")]
        METIS
    }
}
