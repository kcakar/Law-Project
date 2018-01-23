using System;
using System.Collections.Generic;
using Law.Models;

namespace Law.Test
{
    public static class Tester
    {
        public static Random random = new Random();
        //public static TestArticles

        public static List<Article> GenerateArticles(int amount)
        {
            string body = "Aenean mi lacus, pellentesque sed bibendum at, vestibulum nec augue. Nam pellentesque ornare bibendum. Cras bibendum neque a nunc condimentum, ac laoreet ex porttitor. Pellentesque vitae semper lorem, vitae posuere neque. Vivamus laoreet erat ligula, quis accumsan lectus mattis vitae. Morbi eget purus laoreet, venenatis elit quis, varius enim. Vestibulum erat ante, vestibulum et congue aliquam, tincidunt nec sem. Nullam vel ligula sodales, varius neque a, lacinia diam.Vestibulum aliquam dui leo, nec vestibulum enim laoreet sed. Integer sed maximus arcu, sed consectetur quam. Maecenas lacinia ultricies mauris, quis tincidunt lacus mattis pharetra. Vivamus ullamcorper ipsum dui, vel egestas risus convallis ut. Etiam vulputate purus erat, eu imperdiet urna placerat ac. Mauris dignissim facilisis dapibus. Donec quis metus condimentum felis ornare auctor. Donec fermentum, massa a facilisis aliquet, arcu libero accumsan sem, ac mattis erat massa eu ligula.";

            for(int i=0;i<amount;i++)
            {

            }
            return new List<Article>();
        }

        public static List<Contributor> GenerateContributors(int amount)
        {
            List<string> names = new List<string>() { "Sophia Jackson", "Emma Aiden", "Olivia Lucas", "Ava Liam", "Mia Noah", "Isabella Ethan", "Riley Mason", "Aria Caden", "Zoe Oliver", "Charlotte Elijah", "Lily Grayson", "Layla Jacob", "Amelia Michael", "Emily Benjamin", "Madelyn Carter", "Aubrey James", "Adalyn Jayden", "Madison Logan", "Chloe Alexander", "Harper Caleb", "Abigail Ryan", "Aaliyah Luke", "Avery Daniel", "Evelyn Jack", "Kaylee William", "Ella Owen", "Ellie Gabriel", "Scarlett Matthew", "Arianna Connor", "Hailey Jayce", "Nora Isaac", "Addison Sebastian", "Brooklyn Henry", "Hannah Muhammad", "Mila Cameron", "Leah Wyatt", "Elizabeth Dylan", "Sarah Nathan", "Eliana Nicholas", "Mackenzie Julian", "Peyton Eli", "Maria Levi", "Grace Isaiah", "Adeline Landon", "Elena David", "Anna Christian", "Victoria Andrew", "Camilla Brayden", "Lillian John", "Natalie Lincoln" };

            return new List<Contributor>();
        }

        public static List<City> GenerateCities()
        {
            List<string> cities = new List<string> { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };
            return new List<City>();
        }

        public static List<Country> GenerateCountries()
        {
            List<string> countries = new List<string> { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Anguilla", "Antigua & Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia & Herzegovina", "Botswana", "Brazil", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Myanmar/Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominican Republic", "Dominica", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "French Guiana", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Great Britain", "Greece", "Grenada", "Guadeloupe", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Israel and the Occupied Territories", "Italy", "Ivory Coast (Cote d'Ivoire)", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kosovo", "Kuwait", "Kyrgyz Republic (Kyrgyzstan)", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Republic of Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Moldova, Republic of", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Namibia", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Korea, Democratic Republic of (North Korea)", "Norway", "Oman", "Pacific Islands", "Pakistan", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent's & Grenadines", "Samoa", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovak Republic (Slovakia)", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Korea, Republic of (South Korea)", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Tajikistan", "Tanzania", "Thailand", "Timor Leste", "Togo", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks & Caicos Islands", "Uganda", "Ukraine", "United Arab Emirates", "United States of America (USA)", "Uruguay", "Uzbekistan", "Venezuela", "Vietnam", "Virgin Islands (UK)", "Virgin Islands (US)", "Yemen", "Zambia", "Zimbabwe", };
            return new List<Country>();
        }

        public static List<PracticeArea> GeneratePracticeAreas()
        {
            List<string> cities = new List<string> { "Administrative law", "Advertising law", "Admiralty law", "Agency law", "Alcohol law", "Alternative dispute resolution", "Animal law", "Antitrust law (or competition law)", "Appellate practice", "Art law (or art and culture law)", "Aviation law", "Banking law", "Bankruptcy law (creditor debtor rights law or insolvency and reorganization law)", "Bioethics", "Business law (or commercial law); commercial litigation", "Business organizations law (or companies law)", "Civil law or common law", "Class action litigation/Mass tort litigation", "Common Interest Development law", "Communications law", "Computer law", "Conflict of law (or private international law)", "Constitutional law", "Construction law", "Consumer law", "Contract law", "Copyright law", "Corporate law (or company law), also corporate compliance law and corporate governance law", "Criminal law", "Cryptography law", "Cultural property law", "Custom (law)", "Cyber law", "Defamation", "Derivatives and futures law", "Drug control law", "Elder law", "Employee benefits law (ERISA)", "Employment law", "Energy law", "Entertainment law", "Environmental law", "Equipment finance law", "Family law", "FDA law", "Financial services regulation law", "Firearm law", "Food law", "Franchise law", "Gaming law", "Health and safety law", "Health law", "HOA law", "Immigration law", "Insurance law", "Intellectual property law", "International law", "International human rights law", "International trade and finance law", "Internet law", "Juvenile law", "Labour law (or Labor law)", "Land use & zoning law", "Litigation", "Martial law", "Media law", "Medical law", "Mergers & acquisitions law", "Military law", "Mining law", "Music law", "Mutual funds law", "Nationality law", "Native American law", "Obscenity law", "Oil & gas law", "Parliamentary law", "Patent law", "Poverty law", "Privacy law", "Private equity law", "Private funds law / Hedge funds law", "Procedural law", "Product liability litigation", "Property law", "Public health law", "Public International Law", "Railway law", "Real estate law", "Securities law / Capital markets law", "Social Security disability law", "Space law", "Sports law", "Statutory law", "Tax law", "Technology law", "Timber law", "Tort law", "Trademark law", "Transport law / Transportation law", "Trusts & estates law", "Utilities Regulation", "Venture capital law", "Water law", };
            return new List<PracticeArea>();
        }

        public static List<Affiliate> GenerateAffiliates()
        {
            List<string> names = new List<string>() { "Cravath, Swaine & Moore.", "Wachtell, Lipton, Rosen & Katz.", "Skadden, Arps, Slate, Meagher & Flom.", "Sullivan & Cromwell.", "Davis Polk & Wardwell.", "Simpson Thacher & Bartlett.", "Latham & Watkins.", "Kirkland & Ellis." };
            return new List<Affiliate>();
        }

        public static int PickRandomIndex<T>(List<T> list)
        {
            return Tester.random.Next(list.Count);
        }
    }
}


