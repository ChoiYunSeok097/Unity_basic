
# 목표
- 유니티의 기초를 배워보았습니다
- 강의, 영상에서 배웠던 기초나, 기법들을 이용해 여러 상황들을 제작해 보았습니다.
- 직접 사용해보고 에러를 해결해보면서 이해력을 높이는 것이 목표입니다.


# Post

<img src="https://user-images.githubusercontent.com/59460871/151491462-30a8d618-ceeb-41a9-a0db-bfc12c699350.PNG"  width="400" height="200"/>
<img src="https://user-images.githubusercontent.com/59460871/158005518-599cf25b-cdb3-41f3-9fad-3745476d144b.PNG"  width="400" height="200"/>

- 간단하게 UI로 박스를 만들었습니다. 유니티는 Canvas라는 것으로 UI를 제작하는군요
- 카메라에서 ray를 쏴서 오브젝트와 충돌체크를 합니다
- raycast를 이용해 화면에 이름이 출력을 출력합니다

<img src="https://user-images.githubusercontent.com/59460871/153783096-0172596b-a86c-4075-b83c-bfa80304586d.PNG"  width="400" height="200"/>
<img src="https://user-images.githubusercontent.com/59460871/153783127-c8c149d9-c285-49d1-8355-c388f1ada086.PNG"  width="400" height="200"/>

- 기울기 정도를 통해 양쪽을 이동
- 장애물의 위치가 다른 4개 맵을 랜덤으로 계속 배치
- 이미 지나간 장애물은 일정거리 이후 삭제
- 시간 측정후 장애물에 부딪혔을 시 보여주기

<img src="https://user-images.githubusercontent.com/59460871/153793924-44cc90b0-1e45-4bdf-ba9c-2dc7f3befcc9.PNG"  width="400" height="200"/>
<img src="https://user-images.githubusercontent.com/59460871/153793966-3a282b7e-280b-4b20-ba2e-9e691fde415d.PNG"  width="400" height="200"/>

- 마우스 클릭으로 모은 게이지만큼 새를 발사합니다
- physics meterial로 통통 튀는 물리현상을 만들어 보았습니다.
- 목표인 동물과 충돌시 점수가 오르며 동물은 다른 곳에 리스폰하게 했습니다.
- 장애물은 충돌해도 밀려나지 않게 포지션을 고정해 보았습니다.

<img src="https://user-images.githubusercontent.com/59460871/153794747-d037b4bd-5d8e-47ce-a755-7162087357e3.PNG"  width="400" height="200"/>
<img src="https://user-images.githubusercontent.com/59460871/153794828-1391b7a4-ef17-4ce5-9436-679cdd40fe02.PNG"  width="400" height="200"/>
<img src="https://user-images.githubusercontent.com/59460871/158006036-237cde57-bb9a-46f0-a129-2a60d3e21e5b.PNG"  width="400" height="200"/>

- 씬의 이동을 활용해보기 위해 여러 씬들을 만들어 보았습니다.
- 여러 비행기중 하나를 선택해 사용하는 것으로 이전 씬이 다음씬에 영향을 주는 것을 실험했습니다.
- 위 기능을 구현하는게 고민이었는데 비행기를 카메라가 따라지 않고 카메라를 이동하는 것을 비행기가 따라가는 것으로 구현하기 쉬워졌었습니다.
- 운석을 소환하는 곳을 플레이어의 위치에 따라 달리 해보았습니다.

<img src="https://user-images.githubusercontent.com/59460871/157852936-1dd85001-9519-4055-b57f-60a3c930af3a.PNG"  width="400" height="200"/>
<img src="https://user-images.githubusercontent.com/59460871/158006263-379578a5-ba2a-4f01-b4b5-0422e90734ff.PNG"  width="400" height="200"/>

- 계속 리스폰 되는 슬라임을 잡는 게임입니다
- raycast를 이용해 탑다운 뷰를 만들어 보았습니다. 근 일주일을 고민했는데, 카메라에서 마우스방향으로 바닥에 ray를 쏘면 되는 것을 알았을 때 정말 신기했습니다.
- 일정 포지션에서 슬라임 생성을 합니다
- NavMesh를 이용해 플레이어 위치를 찾고 네비게이션을 사용해 보았습니다.
- 버튼 UI를 이용해 게임 스타트와 리스타트를 만들었습니다.
- 적이 공격 할 때와 플레이어가 이동할 때 에셋에 있는 에니메이션을 처음 써보았습니다.
- 처음 animator를 써본게 신선했습니다




