namespace TreehouseDefense
{
    class TreehouseDefenseException : System.Exception
    {
        private string message;

        public void OutOfBoundsException()
        {

        }

        public TreehouseDefenseException(string message) : base(message)
        {
            this.message = message;
        }
    }

    class OutOfBoundsException : TreehouseDefenseException
    {
        

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
