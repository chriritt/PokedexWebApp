## Pokedex Web App

The Pokedex Web App was created as my Capstone for Code Kentucky Software Development session 2.

### APP DESCRIPTION
The Pokedex Web App displays a list of Pokémon that are in the Official Pokédex. From there, the user can mark a Pokémon as caught ~~or add them to a team. Once added to a team, the user can then select their Pokémon's moveset and held items.~~

### FEATURES
The following are a list of features from the Project Specifications that I've implemented:
  * __MAKE YOUR APP ASYNCRONOUS__
    - Pokédex asycronously fetches data from the __PokéApi__ and displays in on an MVC View. Pokémon in the list load into the View asyncronously so as not to slow down the application. Then after the list is loaded and displayed, the user can move a Pokémon to either the CaughtPokemon list or the MyTeams list, which happens asyncronously through a ___Javascript___ Function and an ___Ajax___ Method.
  * __CREATE A DICTIONARY OR LIST__
    - Using the __PokéApi__ and it's corresponding JSON data, I generated a List<> of over 1000 Pokémon, that list was then displayed to the Pokémon View by way of an API Call in the Home Controller.
  * __HAVE 2 OR MORE ENTITIES__
    - This app contains 3 Entities, ___(Team, TeamMember, & CaughtPokemon)___ that are used with ___PokedexContext___ to interact with an Entity Framework Core Sqlite Database.
  * __API__
    - This Web Application relies heavily on the usage of a RESTful API. Calls are made to the API that return JSON data which is then deserialized and displayed to Views using Controllers. Additionally, the usage of an ___HttpPost___ allows users to extract specific data from the returned JSON and save it to an database.
  * __SOLID PRINCIPLES__

### ARCHITECTURE 

### DEPENDENCIES

### FUTURE UPDATES

