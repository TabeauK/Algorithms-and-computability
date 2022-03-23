# Teoria algorytmów i obliczeń (Algorithms and computability)
Pełny opis w Delivery/Docs/TAIO.pdf
## Wstęp
Poniższa praca opisuje problem i rozwiązanie zadania, które można porównać do popularnej gry Tetris. Zadanie
polega na ułożeniu w zamkniętym obszarze lub przestrzeni elementów o różnych kształtach. Występuje tu
wiele wariantów problemu. Jednym z nich jest poszukiwanie ułożenia, w którym uda nam się zmieścić w
wyznaczonym obszarze jak najwięcej zadanych na wejściu elementów. Rozwiązanie takiego problemu może
być przydatne w sytuacji w której trzeba zaplanować przeprowadzkę mając do dyspozycji dużo rzeczy i mało
miejsca bagażowego.
Nasz problem definiujemy w ten sposób, że chcemy dopasować zadane elementy do minimalnego obszaru w
jakim się zmieszczą wykonując jak najmniej operacji na elementach. Realnym przykładem naszego problemu
może być ułożenie prostokątnego placu z kostek o różnych kształtach. Na placu nie mogą pozostawać puste
miejsca, a kostki można ciąć (koszt przecięcia jest niezerowy).
## Opis problemu
Problem optymalizacyjny ścieżki podstawowej - Tetris.
W naszej wersji na wstępie otrzymujemy zadaną liczbę klocków, złożonych z 5 kwadratów (bloków), o różnych predefiniowanych kształtach. Każdy blok jest kwadratem 1x1. Bloki w klockach muszą stykać się całą
krawędzią. Należy je ułożyć w taki sposób, aby bloki na siebie nie zachodziły oraz wszystkie zawierały się
w prostokącie o polu równym sumie pól wszystkich kawałków. Prostokąt w którym zawierają się kawałki ma
kształt jak najbardziej zbliżony do kwadratu (na przykład prostokąt o polu 24 powinien mieć boki 6x4, a nie
24x1, 12x2 czy 8x3).
Informacja o klockach przekazywana jest w pliku tekstowym w postaci kolejnych liczb mówiących ile razy występuje dany kawałek.
Na każdym z klocków, jeśli jest to konieczne, można wykonać cięcia tak, aby otrzymać klocki o innych kształtach, składające się z mniejszej liczby bloków. Cięcia możemy wykonywać w linii prostej, wzdłuż brzegów
bloków od pustej przestrzeni do pustej przestrzeni. Rozwiązanie tego problemu wykonamy w dwóch wariantach:
1. Algorytmem znajdującym optymalne rozwiązanie - rozwiązanie, w którym do ułożenia klocków musieliśmy
wykonać najmniej cięć kawałków
2. Wykorzystując algorytm heurystyczny - czyli algorytm nie dający gwarancji znalezienia rozwiązania optymalnego, ale umożliwiający znalezienie rozwiązania w rozsądnym czasie.

### Użycie
Sama aplikacja ma być przykładem popierającym dowód działania algorytmu.
Aplikacja jest konsolowa i nie przyjmuje argumentów wejściowych, tylko rozwiązuje problem zaszyty w kodzie (tablica 3x6).
