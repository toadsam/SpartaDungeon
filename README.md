# SpartaDungeon

# 😁스파르타 타운만들기

## 프로젝트 소개

- 유니티를 이용해 게더와 비슷한 환경을 만들어보는 프로젝트 입니다.

## 개발기간

- 2023/09/04 ~ 2023/09/07

## ❤맴버 구성❤

- 팀원 : 정재훈
    - 🔴 **필수 요구사항** 1. 캐릭터 만들기    2. 캐릭터 이동   3. 방만들기 4. 카메라 따라가기
    - 🟢 **선택 요구사항 : 1. 캐릭터 애니메이션 추가  2. 이름 입력시스템  3. 캐릭터 선택시스템**

## **⚙️ 개발 환경**

- Visual Studio - C#
- 유니티 2022.3.2

## 🌐주요 기능

- 캐릭터 이동
    
    **Input System을 통해 입력 행동을 정의하여 캐릭터의 이동을 구현하였습니다.**
    

- 방 만들기
    
    타일 맵을 이용하여 바닥이 되는 부분을 꾸며주고 캐릭터가 나가면 안되는 부분에는 따로 타일을 만들어서 충돌 컴포넌트를 추가하였습니다.
    

- 카메라 따라가기
    
    Vector3.Lerp을 이용하여 Time.deltaTime만큼 플레이어와 메인카메라의 백터사이의 값을 반환하도록 하므로써 카메라가 플레이어에게 다가갈 때 자연스럽게 이동할 수 있도록 구현하였습니다.
    
    ```csharp
    public ReSpawn reSpawn;
     void LateUpdate()
     {
         transform.position = Vector3.Lerp(transform.position, reSpawn.player.transform.position, Time.deltaTime);
         transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    ```
    

- 캐릭터 애니메이션 추가
    
    캐릭터에 애니메이션 컴포넌트를 추가해서 구현할 애니메이션을 만든 후 루프로 설정하여 지속적으로 애니메이션이 작동되도록 구현하였습니다.
    

- 이름 입력시스템
    
    시작씬에서 이름을 입력받고 데이터메니저에게 이름을 받고 메인씬으로 넘겨주도록 구현하였습니다.
    
    ```csharp
    DataMgr.Instance.bringName = makeName.text;    //입력한 텍스트를 데이터매니저에 저장
    
    nameTxt.text = DataMgr.Instance.bringName;  //데이터 매니저를 통해 전달
    ```
    

- 캐릭터 선택시스템
    
    시작씬에서 캐릭터을 입력받도록 하였습니다. 
    
    캐릭터 열거형을 만들어 각 캐릭터에게 맞는 열거형의 값을 입력받고 OnMouseUpAsButton()함수를 통해 입력받은 캐릭터가 데이터 매니저를 통해 메인씬으로 전달하여 스타트포인트 지점에 프리팹시킨 캐릭터를 생성하도록 구현하였습니다.
    
     
    
    ```csharp
    public enum Character    //1. 열거형 캐릭터 만들기  
    {
        Player1, Player2, Player3, Player4
    
    }
    
    public  Character currentCharacter;   //2. 현재캐릭터 생성
    
    private void OnMouseUpAsButton()  //3. 마우스를 누르면 발동하는 함수
    {
        DataMgr.Instance.currentCharacter = character;  // 누르면 캐릭터를 데이터 매니저한테 저장
    }
    
    player = Instantiate(cahrPrefabs[(int)DataMgr.Instance.currentCharacter]);  //4. 캐릭터를 생성하는데 캐리터 프리팹에 있는 배열을 가져와서 소환)
    
    ```
