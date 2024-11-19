namespace AzurePipelines
{
    public class Calculator
    {
        public int Total {  get; private set; }

        public Calculator()
        {
            Total = 0;
        }

        public void Add(int value)
        {
            Total += value;
        }

        public void Subtract(int value)
        {
            Total -= value;
        }

        public void Multiply(int value)
        {
            Total *= value;
        }

        public void Divide(int value)
        {
            Total /= value;
        }
    }
}
