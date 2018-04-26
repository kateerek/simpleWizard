# simpleWizardLukaszZylaStazPGS
Project of application  of simple wizard that helps user display informations he specify.

The specification of task was:
/*********************************************************************************************
Napisz prostą aplikację okienkową, czy konsolową, która umożliwi wpisanie użytkownikowi swojego
Imienia [tekst]
Nazwiska [tekst]
Adresu zamieszkania [tekst]
Numeru telefonu [tekst]

Po wpisaniu danych aplikacja ma ponownie wyświetlić je na ekranie jedna pod drugą.
Przed wyświetleniem danych, użytkownik może cofnąć się do dowolnego ekranu/kroku i zmienić wpisane wartości.
W jednym kroku/ekranie można wpisać tylko jedną informację, np. imię

Coś na podobieństwo „wizarda” instalacji.

W trakcie rozwiązywania zadania stwórz możliwie najlepszy a jednocześnie najprostszy kod jaki jesteś w stanie napisać.
Pamiętaj że na jego podstawie będziesz oceniany.
*********************************************************************************************/

In project i used a NuGet called "Advanced Wizard" that helps create an interface of popular installation wizards. The reason of 
my choice were words "Coś na podobieństwo „wizarda” instalacji". All conditions were fulfilled, so:
-User can specify all from 5 informations.
-After specifying informations user can display informations on the screen one below another. 
-Before displaying data user can return to previous steps and change written informations.
-In one step user can specify only one information.

I also added the condition to prevent displaying empty data so applications warns user to specify them all if he didn't do that.
