# CollectionViewAutoTap


Collection View의 Select Mode를 Single로 줬을 때
클릭을 하면 ***주황색***으로 선택이 됩니다.

그런데 가끔 Navigation Page로 왔다 갔다 했을 때 
Collection View의 특정 Row가 선택이 되게 되어야 하는 Needs가 있습니다.

해당 Source의 버튼 부분에 SelectItem을 미리 넣어 두면 자동으로 선택이 될까 했지만
데이터는 가지고 있으나 Select 되는 주황 부분이 표시가 되지 않았습니다.

이 부분은 Select Event 정확하게는 Tab Event 가 되어야 선택이 되고
BackGround가 주황색이 되는것 같은데 이 부분을 파악해 보고자 합니다.




#어떤 방법으로 Collection View의 Item을 선택되게 할 수 있을까?

1.방법1 : SelectedItem을 넣어 본다.(안됨)

```c#
SelectMyModel = new MyModel { Id = 3, Name = "Test3" };
```


2.방법2 : MyModel에 IsSelect 부분을 넣고 Apprence가 되는 이벤트에 함수를 넣어 Frame에 BackGroundColor를 넣는다?
          뭔가 너무 돌아가는 느낌이다..(시도전)

3.방법3 : 뭔가 유사하긴 한데, Focus를 놓는방법을 설명하는 StackOverFlow
          https://stackoverflow.com/questions/75316643/make-focus-go-to-next-entry-in-a-collection-view
          시도 필요
            
##해결하였습니다.

```c#
SelectMyModel = MyModels.Where<MyModel>(e => e.Id == 3).ToList().FirstOrDefault();
```

Call by Value, Reference by Value 오류였습니다.
제가 한 부분은 값만 똑같으면 알아서 찾아갈거라고 생각했는데
CollectionView의 값은 일단 ItemSource 에서 있는 데이터를 Selectitem에 넣어야 선택이 되는 부분입니다.
Linq 형식으로 위 코드와 같이 작성하면 Navigation으로 왔다 갔다 했을때도 미리 선택이 필요한 사용자 Needs에 맞게
처리가 가능할것 같습니다.


감사합니다.
