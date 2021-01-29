//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminPlatfform.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    /// <summary>
    /// Tabelle des Geschäftsführers -- Models 
    /// Alle Eigenschaft sind hier 
    /// </summary>
    public partial class Admin_Geschäftfuehrer
    {
        public int Admin_id { get; set; }
        [Required(ErrorMessage = "Das Feld ist Erfolgreich")]
        public string Vorname { get; set; }
        [Required(ErrorMessage = "Das Feld ist Erfolgreich")]
        public string Nachname { get; set; }
        [Required(ErrorMessage = "Das Feld ist Erfolgreich")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Das Feld ist Erfolgreich")]
        [DataType(DataType.Password)]
        [RegularExpression(@".*([@$!%*#?&]{2,})", ErrorMessage = "Bitte Mindest Zwei ziffer")]
        [MinLength(8, ErrorMessage = "Mindesten 8 Zeichen bitte in password")]
        public string Password { get; set; }
        [Display(Name ="Confrim Password")]
        [DataType(DataType.Password)]
        [Compare("Password" , ErrorMessage ="Confirm password muss abstimmen")]
        public string ConfirmPassword { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}
