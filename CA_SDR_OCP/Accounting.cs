namespace CA_SDR_OCP
{
    internal class Accounting : IOperation
    {
        public Accounting()
        {
            Personnel = new List<string>();
            Email = new List<string>();
        }
        public List<string> Personnel { get; set; }
        public List<string> Email { get; set; }
        public override string EMail(Candidate candidate)
        {
            Email.Add(candidate.ToString() + "@sirket.com");
            return "Email Tanımlandı";
        }
        public override string Select(Candidate candidate)
        {
            Personnel.Add(candidate.ToString());
            return "Personel Seçildi";
            
        }
    }
}
