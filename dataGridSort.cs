using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNumber.dataGrid
{
    public class DataGridSort
    {
        public int addres { get; set; }
        public int data { get; set; }   
    public DataGridSort(int addres, int data)
    {
        this.addres = addres;
        this.data = data;
    }
    public DataGridSort()
    {

    }
    }
}
