using OnTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnTest.Data.Services
{
    public interface IDataHelper<Table>
    {
        //Read
        List<Table> GetAllData();
        List<Table> Search(string searchItem);
        Table Find(int id);
        void Add(Product item);
        void Remove(int id);
		void Apply();

	}

}
