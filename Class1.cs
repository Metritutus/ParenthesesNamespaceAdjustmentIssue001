namespace ParenthesesNamespaceAdjustmentIssue001
{
    internal class Class1
    {
        private bool Condition1 { get; }
        private bool Condition2 { get; }
        private bool Condition3 { get; }

        public void Method1()
        {
            if ((Condition1 && Condition2) || Condition3)
            { }
        }
    }
}
