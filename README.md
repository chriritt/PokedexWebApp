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
    - This Web Application relies heavily on the usage of a RESTful API. Calls are made to the API that return JSON data which is then deserialized and displayed to Views using Controllers. Additionally, the usage of an ___HttpPost___ allows users to extract specific data from the returned JSON and save it to an database
  * __ENTITY FRAMEWORK__
    - This app creates EF Core databases, saves items to the DB on the click of a button ~~and then displays that information to a different View.~~

### ARCHITECTURE
This app is an ASP.Net Core MVC Application with a 2-Layer structure.
 * __Pokedex.Db__
   - This layer contains all of the database access logic such as the ___Team, TeamMember, & CaughtPokemon___ models as well as the  ___PokedexContext___ repository and various Migrations.
  * __Pokedex.UI__
    - The UI layer of course contains the user interface elements such as various HMTL, CSS and JavaScript with a little bit of Bootstrap here and there. Additionally, this layer is home to the API access client  ___PokemonClient___ and it's associated models  ___Pokemon, PokemonData, and PokemonParser___.

### DEPENDENCIES
 * Entity Framework Core
 * Sqlite
 * Newtonsoft.JSON 

### FUTURE UPDATES
#### PLEASE NOTE: This app is not 100% complete. However, I still believe I've met the Project Requirements.
With that said, here are some updates I'd like to make in the future:
 * ___Get database information to display back to the Views correctly.___
 * Complete the areas that I had originally planned but weren't implemented due to time constraints, such as: Team Builder, displaying Pokémon by Type
 * Transition to a 3-layer structure by separating all API logic from the UI layer.
 * Implement a search function on the pages where Pokémon are presented in list form.
 * My original plan was to use the .Net package for the __PokéApi__ which is called __PokéApiNet__. However, I wasn't able to implement. I'd like to get that up and running at some point.
 * Display Pokémon on cards that contain more info, instead of in a table.
