using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.Base
{
    public interface IBaseRecord : IBase
    {
        [Display(Name = "İptal Mi")]
        bool IsCancelled { get; set; }


        /*Belge Lokasyon Bilgileri*/
        [Display(Name = "Firma")]
        [StringLength(50)]
        string Firm { get; set; }


        /*Veri aktarım bilgileri*/
        [Display(Name = "Veri Kaynağı")]
        [StringLength(50)]
        string DbSource { get; set; }

        [Display(Name = "Veri Kaynağı Referansı")]
        [StringLength(50)]
        string DbSourceRef { get; set; }



        [Display(Name = "Son Güncelleme ")]
        DateTime LastUpdate { get; set; }


    }
}
