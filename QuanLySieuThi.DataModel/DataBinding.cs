namespace QuanLySieuThi.DataModel
{
    public class DataBinding
    {
        public string[] Names { get; set; }
        public object[] Values { get; set; }
		
		public DataBinding(int count)
        {
            Names = new string[count];
            Values = new object[count];
        }
    }
}
