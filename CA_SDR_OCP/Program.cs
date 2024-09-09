namespace CA_SDR_OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonnelOps personnelOps = new PersonnelOps();
            personnelOps.Select();
            personnelOps.EMail();
            personnelOps.ViewPersonnel();
            personnelOps.ViewEmail();
        }
    }
}