# AllWorlds

AllWorlds is a codebase for a buffing system for a video game. It includes classes to represent characters (actors), shadows (effects), and players.

## Classes

### Actor

The `Actor` class represents a character in the game, including attributes, race, gender, and shadows. Attributes are managed using a dictionary, and the class includes methods to get and set attributes with validation.

### Player

The `Player` class inherits from `Actor` and represents a player character in the game.

### Shadow

The `Shadow` class represents a shadow effect in the game, including name, level, bonus, and duration. The class includes validation to ensure non-negative values and a non-empty name.

## Tests

The repository includes unit tests for the `Actor` and `Shadow` classes, covering name validation, attribute setting, and shadow management.

## Future Work

- Implement shadow tags to categorize shadows.
- Expand the `Player` class with functionality specific to players.

## Contributing

Please feel free to submit issues, fork the repository and send pull requests!

## License

This project is licensed under the terms of the MIT license.
