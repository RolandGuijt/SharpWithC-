namespace Syntax
{
    internal class _2TypeOmissionNew
    {
        public DateTime MyProperty { get; set; }

        public void Test()
        {
            DateTime d = new();
            MyProperty = new();

            //In C# 12 also [] syntax
            var a = new[] { 1, 4, 1, 53 };


        }
    }
}
