2.Ce este anti-aliasing? Prezentați această tehnică pe scurt.
	
	Anti-aliasing este o tehnică utilizată pentru a netezi marginile zimțate ale obiectelor grafice, cum ar fi linii sau muchii ale poligoanelor, atunci când sunt afișate pe un ecran cu o rezoluție limitată. Această tehnică aplică o tranziție graduală între culorileobiectului și fundal pentru a crea o margine mai netedă și mai realistă. OpenGL oferă funcții pentru a activa anti-aliasing-ul, cum ar fi GL.Enable(GL_LINE_SMOOTH) pentru linii sau GL.Enable(GL_POLYGON_SMOOTH) pentru poligoane.

3.Care este efectul rulării comenzii GL.LineWidth(float)? Dar pentru GL.PointSize(float)? Funcționează în interiorul unei zoneGL.Begin()?

	GL.LineWidth(float) setează grosimea liniilor desenate. Valoarea sa are efect în interiorul unei zone GL.Begin() atunci când desenăm segmente de linie. Dacă este setată în afara unui apel GL.Begin(), aceasta va afecta grosimea liniilor desenate în următorul apel.
	GL.PointSize(float) setează dimensiunea punctelor individuale desenate. Aceasta funcționează, de asemenea, în interiorul unui apel GL.Begin() când sunt specificate primitive de tip puncte.

4.Efectele diferitelor directive OpenGL:
	LineLoop: Conectează o serie de puncte pentru a forma o linie închisă (primul și ultimul punct sunt unite automat).
	LineStrip: Conectează o serie de puncte în linie deschisă, fără a uni primul punct cu ultimul.
	TriangleFan: Desenează un set de triunghiuri împărțind fiecare triunghi cu un vârf central comun (primul vertex specificat) și folosind ceilalți ca vârfuri exterioare.
	TriangleStrip: Creează o bandă de triunghiuri unde fiecare triunghi este definit cu un nou vertex adăugat, folosind ultimele două vertexuri din triunghiul anterior.

6.De ce este importantă utilizarea de culori diferite (în gradient sauculori selectate per suprafață) în desenarea obiectelor 3D? Care esteavantajul?

	Culorile variate, fie per fațetă, fie în gradient, oferă obiectelor 3D profunzime și realism. Acestea ajută la perceperea formeiși orientării suprafețelor prin simularea schimbărilor de lumină și umbră. Aplicând culori diferite pe fațetele unui obiect, observatorii pot înțelege mai bine structura și adâncimea acestuia.

7.Ce reprezintă un gradient de culoare? Cum se obține acesta în OpenGL?

	Gradientul de culoare este o trecere continuă între două sau mai multe culori. În OpenGL, acest efect poate fi obținut prin setarea diferitelor culori pentru vertexurile unui poligon. OpenGL va interpola culorile între vertexuri, generând astfel un efect de gradient.

10.Ce efect are utilizarea unei culori diferite pentru fiecare vertexatunci când desenați o linie sau un triunghi în modul strip?

	Culori diferite pentru fiecare vertex: În modul TriangleStrip, specificarea culorilor diferite pentru fiecare vertex va produce o tranziție de culoare lină între vertexurile triunghiurilor adiacente. Aceasta creează un efect de gradient, oferind o tranziție netedă a culorilor între fațetele triunghiurilor.