# TerraTex-GT-MP-ServerControl

Das ist ein einfach Servercontrol tool um GT-MP Server zu überwachen. 
Es können damit Zwei Server configuriert werden (Dev + Live).

Je nach Einstellung zeigt es nur den Status oder kann nach einer Eingestellten Zeit den Server restarten.

Die derzeitige Variante ist so programmiert, dass sie nach einen Servershutdown den Server erst wieder startet wenn bei build.terratex.eu:8080 kein Build mehr erstellt wird.
Zusätzlich wird bei einem starten Build der Dev Server abgeschaltet. 

Diese Funktionalität wird von TerraTex im Serverbetrieb benötigt. 
Sollte dieses Tool von anderen genutzt werden wollen, müsste der Code für den Jenkins Server entweder angepasst oder entfernt werden.

In einer späteren Version wird das vermutlich configurierbar sein.
