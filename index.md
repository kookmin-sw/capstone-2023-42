<img src = './images/logo.png' width="80%" height="40%">   
<div style="float: left">
    <img src = './images/dice.png' height="10px" width="10px">
</div>

### 1. 프로젝트 소개
주사위 기반 2D RPG 로그라이크 게임   
적과 플레이어가 번갈아 가면서 공격하는 턴제 게임이고, Top view로 구현했습니다.

* **맵**   
캐릭터가 랜덤으로 생성된 맵을 이동하는데 적을 만나면 전투장면으로 들어갑니다. 정해진 아이템 개수 만큼 맵의 랜덤 위치에 생성이 되도록 했고, 일정 수의 몬스터가 맵의 랜덤 위치에 등장합니다.   
* **캐릭터 이동**   
격자형식으로 이동하고, 가고 싶은 위치를 키보드 입력을 통해 이동할 수 있습니다. 빛을 플레이어 캐릭터 주변에만 켜지도록 시야를 조절하였습니다. 그리고 맵을 이동하는 중에 아이템을 획득하면 가방에 저장되고 몬스터와 플레이어가 만나면 전투장면으로 이동합니다.   
* **전투**   
몬스터와 플레이어가 한 턴씩 공격합니다. 랜덤한 주사위 값에 따라 공격 강도가 정해지며 가방에 있는 아이템을 사용할 수 있습니다. 전투에서 승리하거나 도망버튼을 누르면 다시 맵으로 가서 던전을 탐색할 수 있습니다. 전투에서 패배하면 로그라이크 게임 특성상 바로 게임이 끝이 납니다.   

<img src = './images/dice.png' height="10px" width="10px"> ### 2. 소개 영상
<iframe width="560" height="315" src="https://www.youtube.com/embed/V9eildmhIRQ" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>
<iframe width="560" height="315" src="https://www.youtube.com/embed/q2Ls2-C5apU" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>

### 3. 팀 소개
20203052 김지훈   
역할 : 맵 구현  
Email : ricon4246@kookmin.ac.kr   

20191682 최지원   
역할 : 캐릭터 이동 구현   
Email : spasis12@kookmin.ac.kr   

20202075 김채린   
역할 : 전투장면 구현   
Email : chearin0410@kookmin.ac.kr   

### 4. 사용법
Capstone 폴더의 파일을 내려받아서 유니티로 열면 게임 개발 상태를 확인할 수 있고, 시작버튼을 눌러서 게임을 플레이 할 수 있습니다.

