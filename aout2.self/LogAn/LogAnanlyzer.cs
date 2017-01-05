namespace LogAn
{
    public class LogAnanlyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (!fileName.EndsWith(".SLF"))
            {
                return false;
            }
            return true;
        }
    }
}
