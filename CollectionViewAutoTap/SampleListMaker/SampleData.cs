using CollectionViewAutoTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewAutoTap.SampleListMaker
{
    public static class SampleData
    {
        public static List<MyModel> MakeItemSource()
        {
            List<MyModel> myModels= new List<MyModel>();
            myModels.Add(new MyModel() { Id = 0,  Name = "Test0" });
            myModels.Add(new MyModel() { Id = 1,  Name = "Test1" });
            myModels.Add(new MyModel() { Id = 2,  Name = "Test2" });
            myModels.Add(new MyModel() { Id = 3,  Name = "Test3" });
            myModels.Add(new MyModel() { Id = 4,  Name = "Test4" });
            myModels.Add(new MyModel() { Id = 5,  Name = "Test5" });
            myModels.Add(new MyModel() { Id = 6,  Name = "Test6" });
            myModels.Add(new MyModel() { Id = 7,  Name = "Test7" });
            myModels.Add(new MyModel() { Id = 8,  Name = "Test8" });
            myModels.Add(new MyModel() { Id = 9,  Name = "Test9" });
            myModels.Add(new MyModel() { Id = 10, Name = "Test10" });

            return myModels;
        }
    }
}
