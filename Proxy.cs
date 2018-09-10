using System;

using static IVAS2.DbSetup.Model;

namespace IVAS2.DbSetup
{
    public static class Proxy
    {
        public static void CreateData()
        {
            using (var db = new IVAS2Context())
            {
               db.AnswerType.AddRange(
                    new AnswerType { AnswerTypeName = "AssureIdAuthentication" }
                    , new AnswerType { AnswerTypeName = "AssureIdIrImage"}
                    , new AnswerType { AnswerTypeName = "AssureIdPhoto" }
                    , new AnswerType { AnswerTypeName = "AssureIdRisk" }
                    , new AnswerType { AnswerTypeName = "AssureIdUvImage" }
                    , new AnswerType { AnswerTypeName = "AssureIdBackImage"}
                    , new AnswerType { AnswerTypeName = "AssureIdVisibleImage" }
                    , new AnswerType { AnswerTypeName = "BKR" }
                );

                db.Language.AddRange(
                     new Language { English = "Couldn't find username '", Dutch = "De gebruiker '" }
                    , new Language { English = "' and/or terminal name '", Dutch = "' en/of de terminal naam kon niet gevonden worden '" }
                    , new Language { English = "' in the database. Quitting...	'", Dutch = " in the database. Bezig met afsluiten..." }
                    , new Language { English = "of", Dutch = "van" }
                    , new Language { English = "Back", Dutch = "Terug" }
                    , new Language { English = "Save", Dutch = "Bewaar" }
                    , new Language { English = "Last Name", Dutch = "Achternaam" }
                    , new Language { English = "First Name", Dutch = "Voornaam" }
                    , new Language { English = "Scan Time", Dutch = "Tijdstip van Scan" }
                    , new Language { English = "Username", Dutch = "Gebruikers Naam" }
                    , new Language { English = "Invalid date of birth. Must be dd/mm/yyyy, e.g. 30/07/1967", Dutch = "Geboortedatum invoer niet correct. Het zou moeten zijn dd/mm/jjjj, b.v. 30/07/1967" }
                    , new Language { English = "Check", Dutch = "Controleer" }
                    , new Language { English = "Failed to save the scan", Dutch = "Het is niet gelukt de scan op te slaan" }
                    , new Language { English = "Manual check is not allowed if either Last Name, First Name, Date of Birth is empty. Please correct and then check.", Dutch = "Handmatige controle is niet mogelijk indien het veld Voornaam, achternaam of geboortedatum leeg is. Corrigeer dit en probeer het nogmaals." }
                    , new Language { English = "Save is not allowed if either Last Name, First Name, Date of Birth is empty. Manually correct or scan again and then save.", Dutch = "Opslaan is niet mogelijk indien het veld Voornaam, achternaam of geboortedatum leeg is. Corrigeer dit en probeer het nogmaals." }
                    , new Language { English = "Mismatch in basic details. Are you sure you want to save?", Dutch = "Er is geen overeenkomst gevonden in persoonsgegevens. Weet u zeker dat u wilt opslaan?" }
                    , new Language { English = "Reference Library", Dutch = "Bibliotheek" }
                    , new Language { English = "Search Database", Dutch = "Doorzoek Database" }
                    , new Language { English = "Manual Check", Dutch = "Handmatige Controle" }
                    , new Language { English = "Add Document", Dutch = "Document Toevoegen" }
                    , new Language { English = "Edit / View Comment", Dutch = "Bekijk / Bewerk Notitie" }
                    , new Language { English = "View Comment", Dutch = "Bekijk Notitie" }
                    , new Language { English = "Add / View Comment", Dutch = "Notities" }
                    , new Language { English = "Details Screen", Dutch = "Details Bekijken" }
                    , new Language { English = "Delete", Dutch = "Verwijder" }
                    , new Language { English = "Edit / View", Dutch = "Bewerk / Bekijk" }
                    , new Language { English = "View", Dutch = "Bekijk" }
                    , new Language { English = "Too many matches found. The maximum allowed for presentation is", Dutch = "Teveel resultaten gevonden. Het maximaal toegestane resultaten is" }
                    , new Language { English = ". Please narrow your search.", Dutch = ". Verfijn uw zoek criteria." }
                    , new Language { English = "Total matches found:", Dutch = "Totaal gevonden resultaten:" }
                    , new Language { English = "Date of Birth", Dutch = "Geboortedatum" }
                    , new Language { English = "Age", Dutch = "Leeftijd" }
                    , new Language { English = "Issuing Country", Dutch = "Land van Uitgifte" }
                    , new Language { English = "Nationality", Dutch = "Nationaliteit" }
                    , new Language { English = "Document Type", Dutch = "Document Type" }
                    , new Language { English = "Authentication", Dutch = "Authenticatie" }
                    , new Language { English = "Watch List", Dutch = "Watch List" }
                    , new Language { English = "Inactive", Dutch = "Inactief" }
                    , new Language { English = "Risk From", Dutch = "Risico Vanaf" }
                    , new Language { English = "To", Dutch = "t/m" }
                    , new Language { English = "History", Dutch = "Historie" }
                    , new Language { English = "Scan From", Dutch = "Tijdstip van Scan Vanaf" }
                    , new Language { English = "Scan To", Dutch = "t/m" }
                    , new Language { English = "Risk", Dutch = "Risico" }
                    , new Language { English = "Last Visit", Dutch = "Vorig Bezoek" }
                    , new Language { English = "Document Number", Dutch = "Document Nummer" }
                    , new Language { English = "Comment Type", Dutch = "Notitie Type" }
                    , new Language { English = "Document", Dutch = "Document" }
                    , new Language { English = "Add:", Dutch = "Toevoegen:" }
                    , new Language { English = "History:", Dutch = "Historie:" }
                    , new Language { English = "Add", Dutch = "Toevoegen" }
                    , new Language { English = "Comment", Dutch = "Notitie" }
                    , new Language { English = "Date & Time", Dutch = "Datum & Tijd" }
                    , new Language { English = "Basic", Dutch = "Eenvoudig" }
                    , new Language { English = "Advanced", Dutch = "Geavanceerd" }
                    , new Language { English = "Are you sure you want to delete this case from the database?", Dutch = "Weet u zeker dat u deze volledige invoer wilt verwijderen?" }
                    , new Language { English = "Please flip the current document in the reader.", Dutch = "Draai het document op de scanner alstublieft om." }
                    , new Language { English = "Cancel", Dutch = "Annuleer" }
                    , new Language { English = "Yes", Dutch = "Ja" }
                    , new Language { English = "No", Dutch = "Nee" }
                    , new Language { English = "Last name is empty.", Dutch = "Achternaam is niet ingevuld." }
                    , new Language { English = "First name is empty.", Dutch = "Voornaam is niet ingevuld." }
                    , new Language { English = "Date of birth is empty.", Dutch = "Geboortedatum is niet ingevuld." }
                    , new Language { English = "Document number is empty.", Dutch = "Documentnummer is niet ingevuld." }
                    , new Language { English = "Note: Information is missing in basic details:", Dutch = "Let op: De informatie in de basis details is incompleet:" }
                    , new Language { English = "Warning!", Dutch = "Pas op!" }
                    , new Language { English = "Recheck", Dutch = "Verifieer" }
                    , new Language { English = "Note: no match in at least one of first name, last name, date of birth.", Dutch = "Let op: voornaam, achternaam en/of geboortedatum komen niet overeen." }
                    , new Language { English = "Couldn't find the username '", Dutch = "Kan de gebruikersnaam '" }
                    , new Language { English = "' in any of the groups defined in the Active Directory groups. Quitting...", Dutch = "' niet vinden in de groepen gedefinieerd in de Active Directory groepen. Sluit nu af..." }
                    , new Language { English = "Error: No week code for this week in the database.", Dutch = "Error: Geen week code voor deze week in de database." }
                    , new Language { English = "Failed to connect to the database. Quitting...", Dutch = "Kan geen connectie met de database maken. Afsluiten..." }
                    , new Language { English = "Sample is not available", Dutch = "Voorbeeld is niet beschikbaar" }
                    , new Language { English = "Not all comment types are valid. Please correct and try again. Save failed.", Dutch = "Niet alle notitie types zijn geldig. Corrigeer dit alstublieft. Bewaren is mislukt." }
                    , new Language { English = "Error: the document check was failed.", Dutch = "Foutmelding: de document controle is mislukt." }
                    , new Language { English = "The document was checked and it is not reported as missing.", Dutch = "Het document is gecontroleerd en niet opgegeven als vermist." }
                    , new Language { English = "The document was checked and it is reported as missing.", Dutch = "Het document is gecontroleerd en opgegeven als vermist." }
                    , new Language { English = "Checked", Dutch = "Gecontroleerd" }
                    , new Language { English = "Error", Dutch = "Foutmelding" }
                    , new Language { English = "More data is required about the document:", Dutch = "Er zijn meer gegevens nodig omtrent het document:" }
                    , new Language { English = "Busy. Please wait...", Dutch = "Bezig. Even geduld aub..." }
                    , new Language { English = "The updated nationality has successfully been saved to the database.", Dutch = "De bijgewerkte nationaliteit is succesvol opgeslagen in de database." }
                    , new Language { English = "Quit", Dutch = "Afsluiten" }
                );

                db.Color.AddRange(
                        new Color { ColorName = "Black" }
                        , new Color { ColorName = "Green" }
                        , new Color { ColorName = "Red" }
                        , new Color { ColorName = "Orange" }
                );

                db.CommentType.AddRange(
                        new CommentType { CommentTypeName = "Algemeen", Popup = false }
                        , new CommentType { CommentTypeName = "Waarschuwing", Popup = false }
                        , new CommentType { CommentTypeName = "Training", Popup = false }
                        , new CommentType { CommentTypeName = "Handmatige controle", Popup = false }
                        , new CommentType { CommentTypeName = "Risico", Popup = true }
                );

                db.Examiner.AddRange(
                    new Examiner { ExaminerName = "AssureID" }
                    , new Examiner { ExaminerName = "BKR" }
                    );

                db.IVAS2_User.AddRange(
                    new IVAS2_User { UserName = "ISECAST\\USER1", UserLevel = "Unauthorised" }
                    , new IVAS2_User { UserName = "ISECAST\\Administrator", UserLevel = "Administrator" }
                    , new IVAS2_User { UserName = "ISECAST\\teamlead", UserLevel = "TeamLeader" }
                    );

                db.SaveChanges();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
