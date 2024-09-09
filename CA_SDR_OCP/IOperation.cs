namespace CA_SDR_OCP
{
    internal abstract class IOperation
    {
        public abstract string Select(Candidate candidate);
        public abstract string EMail(Candidate candidate);
    }
}
