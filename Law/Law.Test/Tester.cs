using System;
using System.Collections.Generic;
using Law.Models;
using System.Linq;

namespace Law.Test
{
    public static class Tester
    {
        public static Random random = new Random();
        public static List<Article> TestArticles = new List<Article>();
        public static List<City> TestCities = new List<City>();
        public static List<Country> TestCountries = new List<Country>();
        public static List<PracticeArea> TestPracticeAreas = new List<PracticeArea>();
        public static List<Affiliate> TestAffiliates = new List<Affiliate>();
        public static List<Contributor> TestContributors = new List<Contributor>();

        public static void GenerateTestData()
        {
            if(TestCities.Count>0)
            {
                return;
            }
            GenerateCities();
            GenerateCountries();

            Affiliate affiliate = new Affiliate("1", "LL.M.");
            TestAffiliates.Add(affiliate);

            Contributor contributor = new Contributor("1", "Orçun Çetinkaya");
            contributor.CountryID = TestCountries.FirstOrDefault(x => x.Name == "Turkey").ID;
            contributor.CityID = TestCities.FirstOrDefault(x => x.Name == "İstanbul").ID;
            contributor.CreationDate = DateTime.Now;
            contributor.TotalContributions = 0;
            contributor.AffiliateID = affiliate.ID;
            contributor.Bio = "";
            contributor.Education = "";
            contributor.ImageURL = "/img/orcun-cetinkaya.jpg";
            contributor.Language = "tr-TR";

            TestContributors.Add(contributor);


            Contributor contributor2 = new Contributor("2", "Burcu Tuzcu Ersin");
            contributor2.CountryID = TestCountries.FirstOrDefault(x => x.Name == "Turkey").ID;
            contributor2.CityID = TestCities.FirstOrDefault(x => x.Name == "İstanbul").ID;
            contributor2.CreationDate = DateTime.Now;
            contributor2.TotalContributions = 0;
            contributor2.AffiliateID = affiliate.ID;
            contributor2.Bio = "";
            contributor2.Education = "";
            contributor2.ImageURL = "/img/burcu-tuzcu-ersin.jpg";
            contributor2.Language = "tr-TR";

            TestContributors.Add(contributor);

            Article a1 = new Article();
            a1.ID = "1";
            a1.AffiliateID = contributor.AffiliateID;
            a1.Body = "<p>Following the incident of a Russian Su-24 jet being downed by Turkish F-16 fighters on 24 November 2015 causing the Russian aircraft crash in the Bayirbucak region of northern Syria, Russia imposed a series of economic measures and sanctions against Turkey. The first step in this direction was a decree prohibiting Turkish products along with other sanctions, approved by the President of Russia Vladimir Putin on 28 November 2015. With this presidential decree (numbered 583), the legal ground was prepared for economic embargos on Turkey and Turkish goods and services.</p><p>Following this decree, the Russian Government fleshed out the decree’s commercial sanctions with an Executive Order on 30 November 2015 (numbered 1296). On 28 December 2015, some amendments were introduced to the previously approved decree, indicating the specifics and scope of previously determined sanctions.</p><p>Major sectors that are affected by the commercial sanctions are construction, tourism and hotel management, architecture, engineering-technical projects (technical tests, research, analysis) and woodworking. Additionally, from 1 January 2016, it is also prohibited for companies that are subject to Turkish legislation and/or controlled by Turkish citizens to do business with the Russian government or municipalities, regardless of the sector these companies operate in. A public statement by the Russian government explains that the sanctions in the Executive Order do not apply to projects contracted before 1 January 2016.</p><p>As of the date of writing, the types of the sanctions, limitations and prohibitions applied by Russia against Turkey include:</p><h2>Imports of Agricultural Goods, Raw Materials and Food Products Prohibited:</p><p>The Russian government imposed an embargo on Turkish products, especially fruits, vegetables, flowers, chicken, turkey and salt. In this regard:</h2><h2>Fruits:      </h2><p>GTIP 0805 10- Orange, fresh or dried</p><p>GTIP 0805 20- Tangerine (all kinds and hybrids), fresh or dried,</p><p>GTIP 0806 10- Grapes, fresh</p><p>GTIP 0808 10- Apple, fresh</p><p>GTIP 0808 30- Pear, fresh</p><p>GTIP 0809 10- Apricot, fresh</p><p>GTIP 0809 30- Peach and nectarine, fresh</p><p>GTIP 0809 40- Plum and sloe, fresh</p><p>GTIP 0810 10- Strawberry, fresh</p><h2>Vegetables:</h2><p>GTIP 0207 14- Tomato, fresh or cooled</p><p>GTIP 0207 27- Onion, fresh or cooled</p><p>GTIP 0704 10- Cauli and broccoli, fresh or cooled</p><p>GTIP 0707 00- Cucumber and gherkin, fresh or cooled</p><h2>Birds:</h2><p>GTIP 0207 14- Pieces and giblets of chicken, frozen</p><p>GTIP 0207 27- Pieces and giblets of turkey, frozen</p><h2>Others:</h2><p>GTIP 0603 12- Clove, fresh</p><p>GTIP 2501 00- Salt and pure sodium chloride; sea water</p><h2>Turkish Companies Prohibited From Carrying Out Certain Activities in Russia:</h2><p>In certain operation fields, prohibitions and limitations apply to the activities of companies and organizations which are headquartered in Turkey, or are controlled by Turkish citizens.</p><p>Russian legislation defines criteria for “control” in Articles 5(1) and 5(2) of the Federal Law titled Order of Foreign Investment in Economic Structures Strategically Important for State Defense and Security, numbered 57-F3 and dated 29 April 2008. Accordingly, persons are deemed to have authority to control the company or organization where they:</p><p>– Hold more than 50% of votes as shareholders,</p><p>– Hold less than 50% of votes as shareholders, but control the company’s decision making mechanism,</p><p>– Are authorized to appoint the CEO or more than half of the executive body members of the company or organization, or</p><p>– Are authorized to appoint more than half of the board of management or the executive body without any conditions,</p><p>Another important point is that sanctions in the decree also cover Turkish companies with their headquarters located in Russia. However, the Russian government failed to indicate the fields of operation for companies which are subject to these sanctions.</p><p>As for the operation fields included, The Resolution of the Government of the Russian Federation No. 1457 dated 29 December 2015 approved the list of certain types of works which are banned for performance in the territory of the Russian Federation by organizations under the jurisdiction of Turkey as well as organizations controlled by Turkish citizens effective from 1 January 2016.The restriction covers the following operation fields:</p><p>– construction of buildings, construction of engineering and special construction works.</p><p>– activities in the area of architecture and engineering design, technical testing, research and analysis.</p><p>– activities of travel agencies and other organization providing services in the tourism sector.</p><p>– operation of hotels and other places of temporary residence.</p><p>– works and services for the state and municipal needs.</p><p>– woodwork.</p><p>It is important to note that here is an exemption from this ban for works (services) performance of which is envisaged by the contracts entered into before the adoption of the Resolution of the Government of Russian Federation No. 1457 dated 29 December 2015, for the term of validity of such contracts.</p><h2>Employing Turkish Citizens Prohibited</h2><p>Employers and contractors are prohibited from employing Turkish citizens as of 1 January 2016. However, Turkish employees which were already in an employment or legal relationship with an employer in Russia on 31 December 2015 may continue to be employed.</p><p>The Russian government created an exemption for 53 companies to continue employing Turkish citizens:</p><img src='/img/1-1.png' /><p> </p><h2>Visa-Free Travel Agreement Suspended</h2><p>The visa-free travel agreement between Russia and Turkey has been suspended from 1 January 2016. Previously, Russian and Turkish citizens could travel freely between the two countries without a visa.</p><h2>Charter Flights From Russia To Turkey Banned</h2><p>The Russian government has banned charter flights to Turkey, except those used to bring Russian tourists from Turkey back to Russia. Additionally, supervision of regular commercial flights has increased.</p><h2>Tourism Banned</h2><p>Russian tour operators and tourism agencies have abstained from selling Russian citizens tour packages to Turkey.</p><h2>Transportation Prohibited</h2><p>Supervision has increased for Turkish sea transportation companies operating in the Sea of Azov and Black Sea ports, as well as companies involved in land transportation through Russia. The number of trucks and lorries from Turkey which are accepted to pass through Russia is now limited. In 2015, around 8,000 trucks and lorries were accepted to pass through Russia. However, this number is set as at a maximum of 2,000 for 2016.</p><h2>Joint Activities Suspended at Government Level</h2><p>Commercial and economic activities between Turkey and Russia at the government level have been suspended. However the Russian government has appointed their Ministry of Economy to negotiate with Turkey about:</p><p>– The bilateral Agreement on Trade in Services and Investments,</p><p>– The Middle-term program for economic, trade, scientific, technical and cultural cooperation for 2016-2019,</p><p>– Formation of the joint Fund for Financing Investment Projects in Russia and Turkey.</p><p>Russia’s sanctions directly affect Turkey, Turkish companies and Turkish citizens. However, they also indirectly affect many European and American companies. Some of these companies face severe procurement problems where they have production facilities in Russia, yet source raw materials or parts required for these facilities from Turkey.</p><p>On the other hand, it is positive that the sanctions exclude on-going investment undertakings in Russia, as well as Russia’s gas exportation to Turkey. These are the two largest goods and services exchanged between the countries.</p><p>It is important to note that penal clause or compensation claims will inevitably arise for Turkish and foreign parties which are unable to fulfill their undertakings and are forced to cancel reservations.</p><p>Therefore, serious and legitimate concerns exist regarding the rights and obligations of parties involved in agreements which are already executed in Turkey for future expected businesses in Russia, or agreements which would have been executed in connection with the on-going agreements in Russia.</p><p>Parties who are obliged to provide goods or services are preparing to file for objective impossibility and force majeure objections. Meanwhile, parties which have made a payment or submitted a guarantee letter are preparing for collection of penal clauses and compensation.</p><p>Investment arbitration against Russia is considered possible for investors whose long term undertakings are affected by the sanctions. Investors would be able to seek penal and compensation amounts which they might have to pay for breach of these undertakings.</p><p>The Russian government – as if acknowledging the affects and results of the sanctions which cause a logarithmic domino effect for governments and companies – has given some signals indicating that the sanctions will be eased. In this regard, it is speculated that the Russian Ministry of Commerce is working on draft legislation to ease the sanctions.</p><p>Considering the stadiums and other facilities required to be built for the FIFA World Cup to be held in Russia in 2018, Sberbank’s activities in Turkey, Rosatom’s nuclear center in Turkey, as well as all other commercial projects and benefits, the clear preference is to lift the sanctions altogether. However, if this cannot be done in the near future, it is best for both Turkey and Russia to ease these sanctions to keep the commercial effects at minimum.</p>";
            a1.BodyPreview = "Following the incident of a Russian Su-24 jetbeing downed by Turkish F-16 fighters on 24 November 2015 causing the Russianaircraft crash in...";
            a1.CityID = contributor.CityID;
            a1.CountryID = contributor.CountryID;
            a1.ContributorID = contributor.ID;
            a1.LanguageID = contributor.Language;
            a1.PracticeAreaID = "";
            a1.Tags = "";
            a1.Title = "Russian Sanctions Against Turkey";
            a1.ViewCount = 0;
            a1.CreationDate = DateTime.Parse("09/02/2016");
            TestArticles.Add(a1);

            Article a2 = new Article();
            a2.ID = "2";
            a2.AffiliateID = contributor.AffiliateID;
            a2.Body = "<p>The Turkish legislative regime for doctors’ advertising involves contradictions between provisions in primary and secondary legislation. The uncertainty and legislative gaps mean that in practice, government enforcement and interpretation of advertising limitations are inconsistent.</p><p>The legislative regime should be updated, to ensure predictability of government enforcement, encourage innovation by private enterprises, as well as keep pace with wider technological developments (particularly online).</p><p>An improved legislative framework will stimulate and encourage financial investment in the area. It will also serve public interests because increased consistency and reliability of information about doctors will ensure prospective patients can more confidently identify the most appropriate medical specialist for their personal ailment.</p><h2>General advertising rules</h2><p>Advertising commercial products or services is permitted in Turkey, provided the advertising contents are not false, misleading, deceptive, or manipulate the consumer’s will. Advertisements containing exaggeration, which are very encouraging and prideful, are not necessarily unlawful.</p><p>As in other countries though, Turkish legislation restricts advertisements for certain sensitive industries and subjects. Such restrictions apply to Turkey’s health sector, prohibiting promotion of many health-related products and services.</p><p>Advertisements can generally be categorized as either deceptive (always forbidden) or non-deceptive. Non-deceptive advertisements include two sub-categories: “promotional” and “attractive” advertisements.</p><h2>Contradictory rules</h2><p>Restrictions on health-related advertising in Turkey are not clear though. In fact, provisions found in separate pieces of legislation and ethical rules arguably contradict each other. Viewed as a whole, the primary legislation’s wording seems to be narrower than the scope of information which secondary legislation considers acceptable.</p><p>– Doctors are permitted to announce their clinic, working hours and specialties, but cannot make advertisements and announcements (Article 24, Law No. 1219; Primary legislation).</p><p>– Doctors and dentists are permitted to write their name, surname, address, specialty, academic title and examination times/days in newspapers, as well as other platforms and on prescription papers (Article 9, Medical Deontology Statement; Secondary legislation).</p><p>– Doctors and dentists are prohibited from publishing thank you messages in newspapers, or via other means (Article 8, Medical Deontology Statement; Secondary legislation).</p><p>– Healthcare organizations cannot make promotions (Article 29(1), Regulation on Private Healthcare Organizations which Provide Outpatient Diagnosis and Treatment; Secondary legislation)</p><p>– Private hospitals can make promotions and provide information which improves and protects healthcare, as well as inform the community about the scope of their current/future services. However, information which is misleading, exaggerated and not scientifically proven cannot be used for promotion and providing information (Article 60(1), Regulation on Private Hospitals; Secondary legislation).</p><p>– Private hospital websites can contain information about the services offered by health professionals, who have the relevant knowledge and experience. However, websites cannot include treatment information of any kind. (Article 60(2), Regulation on Private Hospitals; Secondary legislation).</p><p>– Ethical rules say doctors should not (Article 11, Turkish Medical Association’s Medical Ethics Rules):</p><p>– Advertise while practicing their profession.</p><p>– Use advertisements for commercial means.</p><p>– Give a commercial appearance to their work.</p><p>– Act in a misleading way.</p><p>– Cause panic among patients and create unfair competition among colleagues.</p><p>According to legislative hierarchy principles, provisions contained in secondary legislation carry less weight than provisions in primary legislation. Therefore, reconciling the contradiction would appear to be easy in practice. However, to ensure clarity, the overall regime needs to be revised to ensure consistency.</p><h2>Permitted advertisements for doctors</h2><p>Doctors in Turkey are subject to the general advertising rules (above). A further restriction arises from the Turkish Medical Association’s Medical Ethics Rules, which prohibits doctors from undertaking “attractive” advertisements for healthcare services.</p><p>The key difference between promotional and attractive advertisement is that the information contained in promotional advertisements represents the only method of informing potential consumers about the product or service. Promotional advertisement falls short of containing exaggerated, overly ambitious, incentives and appealing elements.</p><p>– Promotional Advertisements – Permitted advertisements, involving promotion of a specific product or service, via general information, but avoiding exaggeration. For example, a doctor’s statement that she “carried out the first operation in the country using this technique“, provided she actually did perform the operation for the first time in Turkey using that technique and this fact is verifiable.</p><p>– Attractive Advertisements – Prohibited advertisements, involving exaggerated praise or encouragement, as well as seductive elements of the product or service, although fall short of being deemed to manipulate the consumer’s will. For example, a doctor’s statement that she is “the country’s” or “the world’s” leading specialist in a specific medical field, even if disproving such claim is impossible.</p><h2>Applying the Restrictions in Practice</h2><p>Developments in medical science have led to a wide variety and depth of sub-specialties emerging, at ever smaller degrees of distinction.</p><p>Under the current regime, doctors in Turkey are permitted to publish their qualifications, medical specialties, and contact information. Such information makes it easier for potential patients to identify the most appropriate doctor for their illness.</p><p>However, under a strict interpretation of provisions in secondary legislation (as is usually adopted by Medical Chambers in cities across Turkey, as well as by the Turkish Medical Association), any information going beyond these limited items is technically prohibited in Turkey.</p><p>Primary legislation clearly states that doctors can make declarations about their expertise, but cannot make advertisements and announcements (Article 24, Law No. 1219). However, modern life’s ubiquitous electronic and mass media combine to mean that consumers receive a constant flow of information. Therefore, perhaps a more realistic interpretation of this legislative provision is that doctors can make “promotional” advertisements, provided the advertisements do not stray into the “attractive” classification.</p><p>Under current practices, regulators in Turkey have adopted inconsistent approaches to interpreting and applying the various provisions. The overall result is that the collective bans on certain types of advertising for doctors are not always implemented in practice by local Medical Chambers or the Turkish Medical Association.</p><p>From a commercial point of view, the uncertain legislative framework and inconsistent enforcement have a dampening effect for innovation by private enterprises. These businesses become less willing to develop alternative business models or technology, since their efforts and investments may later be deemed to violate the legislative framework.</p><h2>The way forward</h2><p>Turkey’s approach to regulating health-related advertising has clearly not kept pace with developments in the industry, other legal systems, nor with wider technological and media advancements.</p><p>Prospective patients demand tools to simplify their search for appropriate medical specialists. Counter intuitively though, the trend towards simplification requires prospective patients to have access to an increased volume and complexity of information about candidate medical professionals. Detailed information allows prospective patients to assess and compare medical professionals, to ultimately identify the most appropriate person for their purposes, based on whatever indicator the patient deems most appropriate.</p><p>For example, when comparing and selecting a doctor for a given procedure, a prospective patient might wish to know all of the candidate doctors’ patient volumes, track records with that procedure, surgery mortality rate, average recovery times, or even review references from past patients.</p><p>However, making such detailed information about health professionals publicly available in Turkey involves a range of logistical and regulatory compliance difficulties. Logistical difficulties will immediately arise in ensuring the information is accurate and up to date.</p><p>More notably though, complying with unclear and arguably contradictory advertising restrictions will complicate such a project and discourage investments. Without doubt, publicly disclosing detailed information about medical professionals will attract close attention from local regulators.</p><p>As a result, it seems that regulatory bodies should actively consider Turkey’s legislative regime for doctors’ advertisements, in order to update, clarify and realign the substantive provisions to ensure they achieve their practical effects. Until this occurs, health consumers in Turkey will face challenges in consistently and reliably accessing the level of information they seek in this respect.</p>";
            a2.BodyPreview = "The Turkish legislative regime for doctors’ advertising involves contradictions between provisions in primary and secondary legislation...";
            a2.CityID = contributor.CityID;
            a2.CountryID = contributor.CountryID;
            a2.ContributorID = contributor.ID;
            a2.LanguageID = contributor.Language;
            a2.PracticeAreaID = "";
            a2.Tags = "";
            a2.Title = "Limitations on Doctors’ Advertising in Turkey: An Inconsistent Framework, Ripe for Reform";
            //a2.CreationDate = DateTime.Parse("24/10/2017");
            a2.ViewCount = 0;

            TestArticles.Add(a2);

            Article a3 = new Article();
            a3.ID = "3";
            a3.AffiliateID = contributor.AffiliateID;
            a3.Body = "<p>The following article gives a summary of decrees by the Council of Ministers and communiqués by the Ministry of Economy regarding prevention of unfair competition in imports, made between 1 November 2017 and 30 November 2017.</p><h2>Expiry Revision Investigation Launched for Latex Thread from Thailand</h2><p>At the request of local manufacturers, the Import General Directorate of the Ministry has initiated an expiry revision investigation regarding imports of vulcanized rubber thread and ropes (latex thread) classified under the tariff code 4007.00, imported from Thailand.</p><p>The investigation was launched by the Communiqué on Prevention of Unfair Competition in Imports number 2017/26, published in Official Gazette number 30247 on 21 November 2017, entering into effect on the same date. Please see this link for the full text of the relevant Communiqué (only available in Turkish).</p><h2>Anti-Dumping Duty Will Continue for Polyester Fibre Imports from Iran</h2><p>The Cabinet of Ministry resolved to continue existing definitive measures for polyester fibre imports from Iran, classified under tariff code 5503.20.00.00.00, as well as to impose an additional anti-dumping duty lasting three years.</p><p>The additional anti-dumping duty will therefore be as follows:</p><img src='/img/3-1.gif' ><p>Please see this link for the full text of the Decision on Surveillance Application in Imports number 2017/10799 published in Official Gazette number 30248 on 22 November 2017 (only available in Turkish).</p><h2>Anti-Dumping Duty Will Continue for Polyester Texturized Thread Imports from India and Taiwan</h2><p>At the request of local manufacturers, the Import General Directorate of the Ministry initiated an expiry revision investigation into imports of texturized thread from polyester, classified under the tariff code 5402.33, imported from the Republic of India and Chinese Taiwan.</p><p>The investigation was launched by the Communiqué on Safeguard Measures in Imports number 2017/27, published in Official Gazette number 30249 on 23 November 2017, entering into effect on the same date. Please see this link for the full text of the relevant Communiqué (only available in Turkish).</p><h2>Anti-Dumping Duty Placed on Thick Plate Imports from People’s Republic of China</h2><p>The Import General Directorate decided to impose definitive measure on imports of hot non-rolled steel plate (thick plate) from the People’s Republic of China, classified under tariff code 5402.33.</p><p>The anti-dumping duty rates are as follows for the goods mentioned:</p><img src='/img/3-2.gif'><p>The investigation was initiated by the Communiqué on Surveillance Application in Imports numbered 2017/32, published in Official Gazette number 30255 on 29 November 2017. Please see this link for the full text of the relevant Communiqué (only available in Turkish).</p>";
            a3.BodyPreview = "The following article gives a summary of decrees by the Council of Ministers and communiqués by the Ministry of Economy regarding prevention...";
            a3.CityID = contributor.CityID;
            a3.CountryID = contributor.CountryID;
            a3.ContributorID = contributor.ID;
            a3.LanguageID = contributor.Language;
            a3.PracticeAreaID = "";
            a3.Tags = "";
            a3.Title = "Turkish Trade Remedies – November 2017";
            a3.CreationDate = DateTime.Parse("11/12/2017");
            a3.ViewCount = 0;

            TestArticles.Add(a3);



            //GeneratePracticeAreas();
            //GenerateAffiliates();
            //GenerateContributors();
            //GenerateArticles(1000);
        }

        private static void GenerateArticles(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Article testArticle = new Article(i.ToString(),
                        MockData.Titles.PickRandomItem(),
                        MockData.Content.PickRandomItem(),
                        TestContributors.PickRandomItem().ID,
                        "tr-TR",
                        TestCountries.PickRandomItem().ID,
                        TestCities.PickRandomItem().ID,
                        TestAffiliates.PickRandomItem().ID,
                        TestPracticeAreas.PickRandomItem().ID,
                        MockData.Bios.PickRandomItem().Substring(0, 200)+"..."
                     );
                testArticle.ViewCount = random.Next(10000);
                testArticle.CreationDate = DateTime.Now.AddDays(-random.Next(100)).AddHours(-random.Next(100));
                TestArticles.Add(testArticle);
            }
        }

        private static void GenerateContributors()
        {
            List<string> names = new List<string>() { "Sophia Jackson", "Emma Aiden", "Olivia Lucas", "Ava Liam", "Mia Noah", "Isabella Ethan", "Riley Mason", "Aria Caden", "Zoe Oliver", "Charlotte Elijah", "Lily Grayson", "Layla Jacob", "Amelia Michael", "Emily Benjamin", "Madelyn Carter", "Aubrey James", "Adalyn Jayden", "Madison Logan", "Chloe Alexander", "Harper Caleb", "Abigail Ryan", "Aaliyah Luke", "Avery Daniel", "Evelyn Jack", "Kaylee William", "Ella Owen", "Ellie Gabriel", "Scarlett Matthew", "Arianna Connor", "Hailey Jayce", "Nora Isaac", "Addison Sebastian", "Brooklyn Henry", "Hannah Muhammad", "Mila Cameron", "Leah Wyatt", "Elizabeth Dylan", "Sarah Nathan", "Eliana Nicholas", "Mackenzie Julian", "Peyton Eli", "Maria Levi", "Grace Isaiah", "Adeline Landon", "Elena David", "Anna Christian", "Victoria Andrew", "Camilla Brayden", "Lillian John", "Natalie Lincoln" };

            foreach (string name in names)
            {
                TestContributors.Add(
                    new Contributor(
                        names.IndexOf(name).ToString(),
                        name,
                        TestCountries.PickRandomItem().ID,
                        TestCities.PickRandomItem().ID,
                        TestAffiliates.PickRandomItem().ID,
                        MockData.ImageURLs.PickRandomItem(),
                        MockData.Bios.PickRandomItem()
                        )
                    );
            }

        }

        private static void GenerateCities()
        {
            List<string> cities = new List<string> { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };

            foreach (string city in cities)
            {
                TestCities.Add(new City(cities.IndexOf(city).ToString(), city, "182"));
            }
        }

        private static void GenerateCountries()
        {
            List<string> countries = new List<string> { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Anguilla", "Antigua & Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia & Herzegovina", "Botswana", "Brazil", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Myanmar/Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominican Republic", "Dominica", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "French Guiana", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Great Britain", "Greece", "Grenada", "Guadeloupe", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Israel and the Occupied Territories", "Italy", "Ivory Coast (Cote d'Ivoire)", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kosovo", "Kuwait", "Kyrgyz Republic (Kyrgyzstan)", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Republic of Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Moldova, Republic of", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Namibia", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Korea, Democratic Republic of (North Korea)", "Norway", "Oman", "Pacific Islands", "Pakistan", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent's & Grenadines", "Samoa", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovak Republic (Slovakia)", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Korea, Republic of (South Korea)", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Tajikistan", "Tanzania", "Thailand", "Timor Leste", "Togo", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks & Caicos Islands", "Uganda", "Ukraine", "United Arab Emirates", "United States of America (USA)", "Uruguay", "Uzbekistan", "Venezuela", "Vietnam", "Virgin Islands (UK)", "Virgin Islands (US)", "Yemen", "Zambia", "Zimbabwe", };

            foreach (string country in countries)
            {
                TestCountries.Add(new Country(countries.IndexOf(country).ToString(), country));
            }
        }

        private static void GeneratePracticeAreas()
        {
            List<string> practices = new List<string> { "Administrative law", "Advertising law", "Admiralty law", "Agency law", "Alcohol law", "Alternative dispute resolution", "Animal law", "Antitrust law (or competition law)", "Appellate practice", "Art law (or art and culture law)", "Aviation law", "Banking law", "Bankruptcy law (creditor debtor rights law or insolvency and reorganization law)", "Bioethics", "Business law (or commercial law); commercial litigation", "Business organizations law (or companies law)", "Civil law or common law", "Class action litigation/Mass tort litigation", "Common Interest Development law", "Communications law", "Computer law", "Conflict of law (or private international law)", "Constitutional law", "Construction law", "Consumer law", "Contract law", "Copyright law", "Corporate law (or company law), also corporate compliance law and corporate governance law", "Criminal law", "Cryptography law", "Cultural property law", "Custom (law)", "Cyber law", "Defamation", "Derivatives and futures law", "Drug control law", "Elder law", "Employee benefits law (ERISA)", "Employment law", "Energy law", "Entertainment law", "Environmental law", "Equipment finance law", "Family law", "FDA law", "Financial services regulation law", "Firearm law", "Food law", "Franchise law", "Gaming law", "Health and safety law", "Health law", "HOA law", "Immigration law", "Insurance law", "Intellectual property law", "International law", "International human rights law", "International trade and finance law", "Internet law", "Juvenile law", "Labour law (or Labor law)", "Land use & zoning law", "Litigation", "Martial law", "Media law", "Medical law", "Mergers & acquisitions law", "Military law", "Mining law", "Music law", "Mutual funds law", "Nationality law", "Native American law", "Obscenity law", "Oil & gas law", "Parliamentary law", "Patent law", "Poverty law", "Privacy law", "Private equity law", "Private funds law / Hedge funds law", "Procedural law", "Product liability litigation", "Property law", "Public health law", "Public International Law", "Railway law", "Real estate law", "Securities law / Capital markets law", "Social Security disability law", "Space law", "Sports law", "Statutory law", "Tax law", "Technology law", "Timber law", "Tort law", "Trademark law", "Transport law / Transportation law", "Trusts & estates law", "Utilities Regulation", "Venture capital law", "Water law", };

            foreach (string practice in practices)
            {
                TestPracticeAreas.Add(new PracticeArea(practices.IndexOf(practice).ToString(), practice));
            }
        }

        private static void GenerateAffiliates()
        {
            List<string> affiliates = new List<string>() { "Cravath, Swaine & Moore.", "Wachtell, Lipton, Rosen & Katz.", "Skadden, Arps, Slate, Meagher & Flom.", "Sullivan & Cromwell.", "Davis Polk & Wardwell.", "Simpson Thacher & Bartlett.", "Latham & Watkins.", "Kirkland & Ellis." };

            foreach (string affiliate in affiliates)
            {
                TestAffiliates.Add(new Affiliate(affiliates.IndexOf(affiliate).ToString(), affiliate));
            }
        }

        private static T PickRandomItem<T>(this List<T> list)
        {
            int index = random.Next(list.Count);
            return list[index];
        }
    }
}


