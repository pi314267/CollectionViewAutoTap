using CollectionViewAutoTap.Models;
using CollectionViewAutoTap.SampleListMaker;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewAutoTap.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public List<MyModel> myModels;

        [ObservableProperty]
        public MyModel selectMyModel;

        [ObservableProperty]
        public string id;

        [ObservableProperty]
        public string name;

        public MainViewModel() 
        {
            //데이터 바인딩 소스 만들기
            MyModels = SampleData.MakeItemSource();
        }

        [RelayCommand]
        public void Click()
        {


            //어떤 방법으로 Collection View의 Item을 선택되게 할 수 있을까?

            //방법1 : SelectedItem을 넣어 본다.(안됨)
            //Select Item을 잡아 봤으나, 클릭되지 않음
            SelectMyModel = new MyModel { Id = 3, Name = "Test3" };


            //방법2 : MyModel에 IsSelect 부분을 넣고 Apprence가 되는 이벤트에 함수를 넣어 Frame에 BackGroundColor를 넣는다?
            // 뭔가 너무 돌아가는 느낌이다..(시도전)

            //방법3 : 뭔가 유사하긴 한데, Focus를 놓는방법을 설명하는 StackOverFlow
            //https://stackoverflow.com/questions/75316643/make-focus-go-to-next-entry-in-a-collection-view
            //시도 필요

        }
    }
}
