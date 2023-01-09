namespace Task1{
    
    class NumberArray{

        List<double> _nums = new List<double>();
        public NumberArray()
        {
        }
        public void AddNum(double num)
        {
            _nums.Add(num);
        }

        public double Count()
        {
            return _nums.Count();
        }

        public double SumAll()
        {
            return _nums.Sum();
        }

        public List<double> SortAscending()
        {
             _nums.Sort();
            return _nums;
        }

        public List<double> SortDescending()
        {
             _nums.Reverse();
            return _nums;
        }

        public List<double> ReturnNums()
        {
            return _nums;
        }

        public int CountEvenNumbers()
        {
            int i = 0;

            foreach(int num in _nums)
            {
                if(num % 2 == 0)
                { 
                    i++;
                }
            }
            return i;
        }

        public int CountOddNumbers()
        {
            int i = 0;

            foreach(int num in _nums)
            {
                if(!(num % 2 == 0))
                { 
                    i++;
                }
            }
            return i;
        }

    }
}