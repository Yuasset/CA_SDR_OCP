namespace CA_SDR_OCP
{
    internal class PersonnelOps
    {
        InformationTechnology informationTechnology;
        Accounting accounting;
        HumanResources humanResources;
        public PersonnelOps()
        {
            informationTechnology = new InformationTechnology();
            accounting = new Accounting();
            humanResources = new HumanResources();
        }
        public void Select()
        {
            informationTechnology.Select(Candidate.Arif);
            informationTechnology.Select(Candidate.Süleyman);
            accounting.Select(Candidate.Onur);
            humanResources.Select(Candidate.Kemal);
            humanResources.Select(Candidate.Hayati);
        }
        public void EMail()
        {
            informationTechnology.EMail(Candidate.Arif);
            informationTechnology.EMail(Candidate.Süleyman);
            accounting.EMail(Candidate.Onur);
            humanResources.EMail(Candidate.Kemal);
            humanResources.EMail(Candidate.Hayati);
        }

        public void ViewPersonnel()
        {
            foreach (string item in informationTechnology.Personnel)
            {
                Console.WriteLine("Personel: " + item);
            }
            foreach (string item in humanResources.Personnel)
            {
                Console.WriteLine("Personel: " + item);
            }
            foreach (string item in accounting.Personnel)
            {
                Console.WriteLine("Personel: " + item);
            }
        }
        public void ViewEmail()
        {
            foreach (string item in informationTechnology.Email)
            {
                Console.WriteLine("E-Mail: " + item);
            }
            foreach (string item in humanResources.Email)
            {
                Console.WriteLine("E-Mail: " + item);
            }
            foreach (string item in accounting.Email)
            {
                Console.WriteLine("E-Mail: " + item);
            }
        }
    }
}
