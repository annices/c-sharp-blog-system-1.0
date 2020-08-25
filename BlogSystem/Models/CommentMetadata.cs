﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Bloggsystem.Models
{
    [MetadataType(typeof(CommentMetadata))]
    public partial class Comment
    {
        // An empty class based on an original entity class autogenerated by EF. It's just here to add the class-level attribute.
    }

    /// <summary>
    /// Occasionally EF model classes tend to be automatically regenerated. In turn these regenerations tend to wipe out manually added
    /// code such as data annotations. This class is manually created and binded to the partial class above to prevent these wipe outs.
    /// </summary>
    public class CommentMetadata
    {

        // AllowHtml has to be used with regex here to prevent HttpRequestValidationException (which cannot be catched as a common exception):
        [AllowHtml]
        [RegularExpression(@"[^<>]*$", ErrorMessage = "HTML-kod är ej tillåtet. Uteslut tecken som '<' och '>'.")]
        [DisplayName("Av:")]
        public string name { get; set; }

        [DisplayName("Mejladress:")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Vänligen ange en giltig mejladress.")]
        public string mail { get; set; }

        [DisplayName("Datum:")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> date { get; set; }

        [DisplayName("Webbadress:")]
        [DataType(DataType.Url, ErrorMessage = "Vänligen ange en giltig webbadress.")]
        public string website { get; set; }

        // AllowHtml is necessary here too to work around HttpRequestValidationException:
        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [RegularExpression(@"[^<>]*$", ErrorMessage = "HTML-kod är ej tillåtet. Uteslut tecken som '<' och '>'.")]
        [Required(ErrorMessage = "Vänligen ange en kommentar.")]
        [DisplayName("Kommentar:")]
        public string comment1 { get; set; }

        [DataType(DataType.MultilineText)]
        [AllowHtml]
        [DisplayName("Svar:")]
        public string answer { get; set; }

    }
}